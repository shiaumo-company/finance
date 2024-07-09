using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DBS.Pages;
using Microsoft.AspNetCore.Components;

namespace DBS.Data
{
    public static class ServerData
    {
        public static string publicKey = "C:\\keys\\DBS\\Prod\\DBS_IDEAL_RAPID_PROD_PGP_PUBLIC_KEY_2024.ASC";
        public static string privateKey = "C:\\keys\\DBS\\Prod\\samson_private.asc";
        public static string privayeKeyPwd = "$jo%3dcc3";
        public static string keyId = "135fe963-2492-44d7-b510-24584881b5f6";
        public static string CAMT052_Api_Url = "https://enterprise-api.dbs.com/api/rg/account/v4/bankstatement/intraday";
        public static string CAMT053_Api_Url = "https://enterprise-api.dbs.com/api/rg/account/v4/bankstatement/eod";

        public static List<Transaction> m_TransactionS = new List<Transaction>();//old
        public static List<Account> m_AccountS = new List<Account>();//old
        public static List<Log> m_LogS = new List<Log>();
		public static List<NewAccount> m_NewAccountS = new List<NewAccount>();
        public static List<AccountRepair>m_AccountRepairS= new List<AccountRepair>();
        public static List<BankInfo> m_NewBankS = new List<BankInfo>();
	}
	public static class SqlData
    {
#if RELEASE
        public static readonly string Sql_DataSource = ".";
        public static readonly string Sql_InitialCatalog = "Platform";
        public static readonly string Sql_UserID = "sa";
        public static readonly string Sql_Password = "DBSsa@2022";
        //3edc$RFV5tgb;
#elif DEBUG
        public static readonly string Sql_DataSource = ".";
        public static readonly string Sql_InitialCatalog = "Platform";
        public static readonly string Sql_UserID = "sa";
        public static readonly string Sql_Password = "3edc$RFV5tgb";
    #else
    #endif
        private static readonly string _Sql_ConnectStr = "Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}";
        public static string Sql_ConnectStr
        {
            get { return string.Format(_Sql_ConnectStr, Sql_DataSource, Sql_InitialCatalog, Sql_UserID, Sql_Password); }
        }
     
        #region SqlValue
        public static string GetStringValue(this DataTableReader dtr, string name, string m_default = "")
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetString(name);
            }
            else { return m_default; }
        }
        public static List<string> GetStringValue(this DataTableReader dtr, string name, int nMax, bool bEnglish = false, int padlong = 0, char padstr = '0', string pZeroSite = "", List<string> m_default = null)
        {
            List<string> tmpString = new List<string>();

            for (var i = 0; i <= nMax; i++)
            {
                if (i == 0)
                {
                    if (string.IsNullOrEmpty(pZeroSite)) continue;
                    if (dtr[pZeroSite] == null) continue;

                    if (!string.IsNullOrEmpty(dtr[pZeroSite].ToString()))
                    {
                        tmpString.Add(dtr.GetString(pZeroSite));
                    }
                }
                else
                {
                    string setName;
                    if (padlong > 0)
                    {//English 不知道有怎樣的格式~~~~~
                        setName = string.Format(name, i.ToString().PadLeft(padlong, padstr));
                    }
                    else
                    {
                        if (bEnglish)
                        {
                            string EngIndex = ((char)('A' + (i - 1))).ToString();
                            setName = string.Format(name, EngIndex);
                        }
                        else
                        {
                            setName = string.Format(name, i.ToString());
                        }
                    }

                    if (dtr.IsDBNull(setName)) continue;

                    var tmpValue = dtr[setName].ToString();
                    if (!string.IsNullOrEmpty(tmpValue))
                    {
                        tmpString.Add(tmpValue);
                    }
                }
            }

            if (tmpString.Count > 0)
                return tmpString;
            else if (m_default == null)
                return new List<string>();
            else
                return m_default;
        }
        public static int GetIntValue(this DataTableReader dtr, string name, int m_default = 0)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetInt32(name);
            }
            else { return m_default; }
        }
        public static List<int> GetIntValue(this DataTableReader dtr, string name, int nMax, int padlong = 0, char padstr = '0', string pZeroSite = "", List<int> m_default = null)
        {
            List<int> tmpString = new List<int>();

            for (var i = 0; i <= nMax; i++)
            {
                if (i == 0 && !string.IsNullOrEmpty(pZeroSite))
                {
                    if (dtr[pZeroSite] == null) continue;

                    if (!string.IsNullOrEmpty(dtr[pZeroSite].ToString()))
                    {
                        tmpString.Add(dtr.GetInt32(pZeroSite));
                    }

                    continue;
                }

                string setName;
                if (padlong > 0)
                    setName = string.Format(name, i.ToString().PadLeft(padlong, padstr));
                else
                    setName = string.Format(name, i.ToString());

                if (dtr.IsDBNull(setName)) continue;

                if (!string.IsNullOrEmpty(dtr[setName].ToString()))
                {
                    tmpString.Add(dtr.GetInt32(setName));
                }
            }

            if (tmpString.Count > 0)
                return tmpString;
            else
                return m_default;
        }
        public static uint GetUIntValue(this DataTableReader dtr, string name, uint m_default = 0)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return (uint)dtr.GetInt32(name);
            }
            else { return m_default; }
        }
        public static float GetFloatValue(this DataTableReader dtr, string name, float m_default = 0.0f)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return (float)dtr.GetDouble(name);
            }
            else { return m_default; }
        }
        public static double GetDoubleValue(this DataTableReader dtr, string name, double m_default = 0)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetDouble(name);
            }
            else { return m_default; }
        }
        public static decimal GetDecimalValue(this DataTableReader dtr, string name, decimal m_default = 0)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetDecimal(name);
            }
            else { return m_default; }
        }
        public static DateTime GetDateTimeValue(this DataTableReader dtr, string name, DateTime m_default = new DateTime())
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetDateTime(name);
            }
            else { return m_default; }
        }
        public static Byte GetByteValue(this DataTableReader dtr, string name, Byte m_default = 0)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetByte(name);
            }
            else { return m_default; }
        }
        public static bool GetBoolValue(this DataTableReader dtr, string name, bool m_default = false)
        {
            if (dtr.IsDBNull(name)) return m_default;

            if (!string.IsNullOrEmpty(dtr[name].ToString()))
            {
                return dtr.GetBoolean(name);
            }
            else { return m_default; }
        }
		#endregion

        public static List<BankInfo>ToNewBank(this DataTable dt)
        {
            List<BankInfo> ObjS = new List<BankInfo>();
            BankInfo aObj = new BankInfo();
            var dtr = dt.CreateDataReader();
            while (dtr.Read())      
            {
                aObj = new BankInfo();
                aObj.bbankCode = dtr.GetString("BankCode");
                aObj.bbankName = dtr.GetString("BankName");
                aObj.bbankWeb = dtr.GetString("BankWeb");
                ObjS.Add((aObj));
            }
            return ObjS;
        }
       
		public static List<NewAccount> ToNewAccount(this DataTable dt)
		{
			List<NewAccount> ObjS = new List<NewAccount>();
			NewAccount aObj = new NewAccount();
			var dtr = dt.CreateDataReader();
			while (dtr.Read())
			{
				aObj = new NewAccount();
				aObj.baccountDate = dtr.GetDateTimeValue("accountDate");
				aObj.baccountBank = dtr.GetStringValue("accountBank");
				aObj.baccountBankNo = dtr.GetStringValue("accountBankNo");
				aObj.baccountBranch = dtr.GetStringValue("accountBranch");
				aObj.baccountBranchNo = dtr.GetStringValue("accountBranchNo");
				aObj.baccountNo = dtr.GetStringValue("accountNo");
				aObj.baccountType = dtr.GetStringValue("accountType");
				aObj.baccountIn = dtr.GetDecimalValue("accountIn");
				aObj.baccountOut = dtr.GetDecimalValue("accountOut");
				aObj.baccountTotal = dtr.GetDecimalValue("accountTotal");
				aObj.baccountOtherNo = dtr.GetStringValue("accountOtherNo");
                aObj.baccountAddress = dtr.GetStringValue("accountAddress");
				aObj.bremark = dtr.GetStringValue("remark");
				aObj.baccountInsert = dtr.GetDateTimeValue("accountInsert");
                aObj.baccountUpdate = dtr.GetDateTimeValue("accountUpdate");
				ObjS.Add((aObj));
			}
			return ObjS;
		}

		public static List<AccountRepair>ToAccountReoair(this DataTable dt)
		{
			List<AccountRepair> ObjS = new List<AccountRepair>();
			AccountRepair aObj = new AccountRepair();
			var dtr = dt.CreateDataReader();
			while (dtr.Read())
			{
				aObj = new AccountRepair();
				aObj.baccountBank = dtr.GetStringValue("accountBank");
				aObj.baccountBankNo = dtr.GetStringValue("accountBankNo");
                aObj.baccountBranch = dtr.GetStringValue("accountBranch");
                aObj.baccountBranchNo = dtr.GetStringValue("accountBranchNo");
				aObj.baccountNo = dtr.GetStringValue("accountNo");
                aObj.baccountAddress = dtr.GetStringValue("accountAddress");
                aObj.baccountInitialMoney = dtr.GetDecimalValue("accountInitialMoney");
				aObj.bremark = dtr.GetStringValue("remark");
				aObj.baccountInsert = dtr.GetDateTimeValue("accountInsert");
				aObj.baccountUpdate = dtr.GetDateTimeValue("accountUpdate");
				ObjS.Add((aObj));
			}
			return ObjS;
		}
		public static List<Transaction> ToTransaction(this DataTable dt)//old
        {
            List<Transaction> ObjS = new List<Transaction>();
            Transaction aObj = new Transaction();

            var dtr = dt.CreateDataReader();
            while (dtr.Read())
            {
                aObj = new Transaction();

                aObj.accountBank = dtr.GetStringValue("accountBank");
                aObj.accountNo = dtr.GetStringValue("accountNo");
                aObj.accountCcy = dtr.GetStringValue("accountCcy");
                aObj.amount = dtr.GetDecimalValue("amount");
                aObj.balance = dtr.GetDecimalValue("balance");
                aObj.cdtDbtInd = dtr.GetStringValue("cdtDbtInd");
                aObj.status = dtr.GetStringValue("status");
                aObj.anotherAct = dtr.GetStringValue("anotherAct");
                aObj.valDt = dtr.GetDateTimeValue("valDt");
                ObjS.Add(aObj);
            }

            return ObjS;
        }
        public static List<Account> ToAccount(this DataTable dt)//old
        {
            List<Account> ObjS = new List<Account>();
            Account aObj = new Account();

            var dtr = dt.CreateDataReader();
            while (dtr.Read())
            {
                aObj = new Account();

                aObj.accountBank = dtr.GetStringValue("accountBank");
                aObj.orgid = dtr.GetStringValue("orgid");
                aObj.accountNo = dtr.GetStringValue("accountNo");
                aObj.accountName = dtr.GetStringValue("accountName");
                aObj.accountInit = dtr.GetDecimalValue("accountInit");
                aObj.accountCcy = dtr.GetStringValue("accountCcy");
                aObj.accountType = dtr.GetStringValue("accountType");
                aObj.remark = dtr.GetStringValue("remark");
                aObj.insertDt = dtr.GetDateTimeValue("insert_date");
                aObj.updateDt = dtr.GetDateTimeValue("update_date");
                ObjS.Add(aObj);
            }

            return ObjS;
        }
        public static List<Log> ToLog(this DataTable dt)
        {
            List<Log> ObjS = new List<Log>();
            Log aObj = new Log();

            var dtr = dt.CreateDataReader();
            while (dtr.Read())
            {
                aObj = new Log();

                aObj.bank = dtr.GetStringValue("bank");
                aObj.type = dtr.GetStringValue("type");
                aObj.accountNo = dtr.GetStringValue("accountNo");
                aObj.date = dtr.GetDateTimeValue("date");
                aObj.data = dtr.GetStringValue("data");
                aObj.message = dtr.GetStringValue("message");
                aObj.status = dtr.GetStringValue("status");
                aObj.insertDt = dtr.GetDateTimeValue("insert_date");
                aObj.updateDt = dtr.GetDateTimeValue("update_date");

                ObjS.Add(aObj);
            }

            return ObjS;
        }
    }

    public class BankInfo//getbanklist
	{
        public string bbankCode = "";
        public string bbankName = "";
        public string bbankWeb = "";
    }
	public class NewAccount
	{
		public DateTime baccountDate;
		public string baccountBank = "";
		public string baccountBankNo = "";
        public string baccountBranch = "";
        public string baccountBranchNo = "";
		public string baccountNo = "";
		public string baccountType = "";
		public decimal baccountIn;
		public decimal baccountOut;
		public decimal baccountTotal;
		public string baccountOtherNo = "";
        public string baccountAddress = "";
		public string bremark = "";
		public DateTime baccountInsert;
        public DateTime baccountUpdate;
	}
    public class AccountRepair
    {
        public string baccountBank;
        public string baccountBankNo;
        public string baccountBranch;
        public string baccountBranchNo;
        public string baccountNo;
        public string baccountAddress;
        public decimal baccountInitialMoney;
        public string bremark;
        public DateTime baccountInsert;
        public DateTime baccountUpdate;
    }
	public class Transaction//old
    {
        public string accountBank = "";
        public string accountNo = "";
        public string accountCcy = "";
        public decimal amount;
        public decimal balance;
        public string cdtDbtInd = "";
        public string status = "";
        public string anotherAct = "";
        public DateTime valDt;
    }
    public class Account//old
    {
        public string accountBank = "";
        public string orgid = "";
        public string accountNo = "";
        public string accountName = "";
        public decimal accountInit;
        public string accountCcy = "";
        public string accountType = "";
        public string remark = "";
        public DateTime insertDt;
        public DateTime updateDt;
    }
    public class Log
    {
        public string bank = "";
        public string type = "";
        public string accountNo = "";
        public DateTime date;
        public string data = "";
        public string message = "";
        public string status = "";
        public DateTime insertDt;
        public DateTime updateDt;
    }
    public static class Debug
    {
        public static void LogShow(string pStr)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(pStr);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}