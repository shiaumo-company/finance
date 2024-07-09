using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBS.Data
{
    public class SQLSite
    {
        private static SqlConnection _sqlConn = null;
        public static SqlConnection Connection
        {
            get
            {
                if (_sqlConn == null)
                {
                    //_sqlConn = new SqlConnection(SqlData.Sql_ConnectStr);
                    _sqlConn = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
                    _sqlConn.Open();
                }
                if (_sqlConn.State == ConnectionState.Closed)
                {
                    _sqlConn.Open();
                }
                return _sqlConn;
            }
        }

        public static DataTable GetSqlDataTable(string sSqlStr)
        {
            SqlDataAdapter sda = null;
            DataSet ds = null;
            DataTable dt = null;

            using (sda = new SqlDataAdapter(sSqlStr, Connection))
            {
                using (ds = new DataSet())
                {
                    try
                    {
                        sda.Fill(ds, "DataTest");
                        dt = ds.Tables["DataTest"];
                    }
                    catch (SqlException) { }
                    finally
                    {
                        ds.Dispose();
                        sda.Dispose();
                    }
                }
            }

            return dt;
        }

        public static bool ExecuteComm(string sSqlStr, params SqlParameter[] parameters)
        {
            SqlCommand sqlComm = null;
            bool bOK = false;

            using (sqlComm = new SqlCommand(sSqlStr, Connection))
            {
                try
                {
                    if (parameters != null)
                    {
                        sqlComm.Parameters.AddRange(parameters);
                    }
                    sqlComm.ExecuteNonQuery();
                    bOK = true;
                }
                catch (SqlException)
                {
                    bOK = false;
                }
                finally
                {
                    sqlComm.Dispose();
                }
            }

            return bOK;
        }

        public static bool ExecuteComm(List<string> sSqlStrS, params SqlParameter[] parameters)
        {
            SqlCommand sqlComm = null;
            bool bOK = false;

            foreach (var sSqlStr in sSqlStrS)
            {
                using (sqlComm = new SqlCommand(sSqlStr, Connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            sqlComm.Parameters.AddRange(parameters);
                        }
                        sqlComm.ExecuteNonQuery();
                        bOK = true;
                    }
                    catch (SqlException)
                    {
                        bOK = false;
                    }
                }
            }

            sqlComm.Dispose();

            return bOK;
        }

        public async Task<DataTable> GetSqlDataTableAsync(string sSqlStr)
        {
            return await Task<DataTable>.Factory.StartNew(() => {

                SqlDataAdapter sda = null;
                DataSet ds = null;
                DataTable dt = null;

                using (sda = new SqlDataAdapter(sSqlStr, Connection))
                {
                    using (ds = new DataSet())
                    {
                        try
                        {
                            sda.Fill(ds, "DataTest");
                            dt = ds.Tables["DataTest"];
                        }
                        catch (SqlException) { }
                        finally
                        {
                            ds.Dispose();
                            sda.Dispose();
                        }
                    }
                }

                return dt;
            });
        }

        public async Task<bool> ExecuteCommAsync(string sSqlStr, params SqlParameter[] parameters)
        {
            return await Task<bool>.Factory.StartNew(() =>
            {
                SqlCommand sqlComm = null;
                bool bOK = false;

                using (sqlComm = new SqlCommand(sSqlStr, Connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            sqlComm.Parameters.AddRange(parameters);
                        }
                        sqlComm.ExecuteNonQuery();
                        bOK = true;
                    }
                    catch (SqlException)
                    {
                        bOK = false;
                    }
                    finally
                    {
                        sqlComm.Dispose();
                    }
                }

                return bOK;
            });
        }
    }

    public class SQLTemp
    {

        #region NewBank
        public static string LoadNewBank()
        {
            ServerData.m_NewBankS.Clear();
            string strMsg = "";

            try
            {
                string strSql = "SELECT * FROM GetBankList";
                var _val = SQLSite.GetSqlDataTable(strSql);
                // 打印或記錄 DataTable 的行數
                Debug.LogShow($"資料有幾行: {_val?.Rows?.Count}");
                if (_val != null && _val.Rows.Count > 0)
                {
                    ServerData.m_NewBankS = _val.ToNewBank();
                    strMsg = "Load Finish GetBankList, Load : " + ServerData.m_NewBankS.Count.ToString();
                    Debug.LogShow("Load Finish GetBankList, Load : " + ServerData.m_NewBankS.Count);
                }
                else
                {
                    strMsg = "Error Load GetBankList";
                    Debug.LogShow("Error Load GetBankList");
                }
            }
            catch (Exception ex)
            {
                strMsg = "Error Load GetBankList ：";
                //Debug.LogShow(ex.Message);
                Debug.LogShow("Error Load GetBankList：錯誤" + ex.Message);
                // 打印堆棧跟蹤信息
                Debug.LogShow("Stack Trace追蹤訊息: " + ex.StackTrace);
                if (ex.InnerException != null)
                {
                    Debug.LogShow("Inner Exception: " + ex.InnerException.Message);
                    Debug.LogShow("Inner Exception Stack Trace: " + ex.InnerException.StackTrace);
                }
            }

            return strMsg;
        }

        #endregion
        #region AccountRepair
        public static string LoadAccountRepair()
		{
			ServerData.m_AccountRepairS.Clear();
			string strMsg = "";

			try
			{
				string strSql = "SELECT * FROM NewAccountRepair";
				var _val = SQLSite.GetSqlDataTable(strSql);
				// 打印或記錄 DataTable 的行數
				Debug.LogShow($"資料有幾行: {_val?.Rows?.Count}");
				if (_val != null && _val.Rows.Count > 0)
				{
					ServerData.m_AccountRepairS = _val.ToAccountReoair();
					strMsg = "Load Finish NewAccountRepair, Load : " + ServerData.m_AccountRepairS.Count.ToString();
					Debug.LogShow("Load Finish NewAccountRepair, Load : " + ServerData.m_AccountRepairS.Count);
				}
				else
				{
					strMsg = "Error Load NewAccountRepair";
					Debug.LogShow("Error Load NewAccountRepair");
				}
			}
			catch (Exception ex)
			{
				strMsg = "Error Load NewAccountRepair ：";
				//Debug.LogShow(ex.Message);
				Debug.LogShow("Error Load NewAccountRepair：錯誤" + ex.Message);
				// 打印堆棧跟蹤信息
				Debug.LogShow("Stack Trace追蹤訊息: " + ex.StackTrace);
				if (ex.InnerException != null)
				{
					Debug.LogShow("Inner Exception: " + ex.InnerException.Message);
					Debug.LogShow("Inner Exception Stack Trace: " + ex.InnerException.StackTrace);
				}
			}

			return strMsg;
		}
		#endregion
		#region 


		public static string LoadNewAccount()
		{
			ServerData.m_NewAccountS.Clear();
			string strMsg = "";

			try
			{
				string strSql = "SELECT * FROM NewAccountInfo";
				var _val = SQLSite.GetSqlDataTable(strSql);

				if (_val != null && _val.Rows.Count > 0)
				{
					ServerData.m_NewAccountS = _val.ToNewAccount();
					strMsg = "Load Finish AccountInfo, Load : " + ServerData.m_NewAccountS.Count.ToString();
					Debug.LogShow("Load Finish AccountInfo, Load : " + ServerData.m_NewAccountS.Count);
				}
				else
				{
					strMsg = "Error Load NewAccountInfo";
					Debug.LogShow("Error Load NewAccountInfo");
				}
			}
			catch (Exception ex)
			{
				strMsg = "Error Load NewAccountInfo";
				Debug.LogShow(ex.Message);
				Debug.LogShow("Error Load NewAccountInfo");
			}

			return strMsg;
		}
		#endregion
		#region Account
		public static string LoadAccount()
        {
            ServerData.m_AccountS.Clear();

            string strMsg = "";

            try
            {
                string strSql = "SELECT * FROM AccountInfo";
                var _val = SQLSite.GetSqlDataTable(strSql);

                if (_val != null && _val.Rows.Count > 0)
                {
                    ServerData.m_AccountS = _val.ToAccount();
                    strMsg = "Load Finish AccountInfo, Load : " + ServerData.m_AccountS.Count.ToString();
                    Debug.LogShow("Load Finish AccountInfo, Load : " + ServerData.m_AccountS.Count);
                }
                else
                {
                    strMsg = "Error Load AccountInfo";
                    Debug.LogShow("Error Load AccountInfo");
                }
            }
            catch (Exception ex)
            {
                strMsg = "Error Load AccountInfo";
                Debug.LogShow(ex.Message);
                Debug.LogShow("Error Load AccountInfo");
            }

            return strMsg;
        }
        #endregion
        #region Transaction
        public static string LoadTransaction()
        {
            ServerData.m_TransactionS.Clear();

            string strMsg = "";

            try
            {
                string strSql = "SELECT * FROM DBS_053_Trade order by bookgDt";
                var _val = SQLSite.GetSqlDataTable(strSql);

                if (_val != null && _val.Rows.Count > 0)
                {
                    ServerData.m_TransactionS = _val.ToTransaction();
                    strMsg = "Load Finish DBS_053_Trade, Load : " + ServerData.m_TransactionS.Count.ToString();
                    Debug.LogShow("Load Finish DBS_053_Trade, Load : " + ServerData.m_TransactionS.Count);
                }
                else
                {
                    strMsg = "Error Load DBS_053_Trade";
                    Debug.LogShow("Error Load DBS_053_Trade");
                }
            }
            catch (Exception ex)
            {
                strMsg = "Error Load DBS_053_Trade";
                Debug.LogShow(ex.Message);
                Debug.LogShow("Error Load DBS_053_Trade");
            }

            return strMsg;
        }
        #endregion
        #region Log
        public static string LoadLog()
        {
            ServerData.m_LogS.Clear();

            string strMsg = "";

            try
            {
                string strSql = "SELECT * FROM DBS_Log";
                var _val = SQLSite.GetSqlDataTable(strSql);

                if (_val != null && _val.Rows.Count > 0)
                {
                    ServerData.m_LogS = _val.ToLog();
                    strMsg = "Load Finish DBS_Log, Load : " + ServerData.m_LogS.Count.ToString();
                    Debug.LogShow("Load Finish DBS_Log, Load : " + ServerData.m_LogS.Count);
                }
                else
                {
                    strMsg = "Error Load DBS_Log";
                    Debug.LogShow("Error Load DBS_Log");
                }
            }
            catch (Exception ex)
            {
                strMsg = "Error Load DBS_Log";
                Debug.LogShow(ex.Message);
                Debug.LogShow("Error Load DBS_Log");
            }

            return strMsg;
        }
        #endregion
    }
}