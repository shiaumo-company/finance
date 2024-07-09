// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DBS.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using DBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\013590\source\repos\DBS\DBS\DBS\_Imports.razor"
using DBS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
using APITester;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/repairdata")]
    public partial class RepairData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\RepairData.razor"
       
    string date;
    string msgId;
    string type;
    string orgId;
    string account;
    string accountCcy;
    string query;

    public void TypeChange(ChangeEventArgs e)
    {
        type = e.Value.ToString();
    }

    public void AccountChange(ChangeEventArgs e)
    {
        orgId = e.Value.ToString().Split(",")[0];
        account = e.Value.ToString().Split(",")[1];
        accountCcy = e.Value.ToString().Split(",")[2];
    }

    public void DateChange(ChangeEventArgs e)
    {
        date = Convert.ToDateTime(e.Value).ToString("yyyy/MM/dd").Replace("/", "");
    }

    public void OnClickClear(MouseEventArgs e)
    {
        #region 檢查
        bool bError = false;
        if (string.IsNullOrWhiteSpace(type))
        {
            bError = true;
            AlertService.Error("請選擇類型");
        }
        if (string.IsNullOrWhiteSpace(account))
        {
            bError = true;
            AlertService.Error("請選擇帳號");
        }
        if (date == null)
        {
            bError = true;
            AlertService.Error("請輸入日期");
        }

        if (bError)
        {
            return;
        }
        #endregion

        try
        {
            query = "Delete From DBS_053_Balance Where accountBank='DBS' AND type='CAMT053' AND accountNo='" + account + "' AND balanceDt='" + date + "'";
            SQLSite.ExecuteComm(query);

            query = "Delete From DBS_053_Trade Where accountBank='DBS' AND type='CAMT053' AND accountNo='" + account + "' AND valDt='" + date + "'";
            SQLSite.ExecuteComm(query);

            AlertService.Info("重設資料完成");
        }
        catch
        {
            AlertService.Error("重設資料失敗");
        }

    }

    public async Task OnClickRepair(MouseEventArgs e)
    {
        #region 檢查
        bool bError = false;
        if (string.IsNullOrWhiteSpace(type))
        {
            bError = true;
            AlertService.Error("請選擇類型");
        }
        if (string.IsNullOrWhiteSpace(account))
        {
            bError = true;
            AlertService.Error("請選擇帳號");
        }
        if (date == null)
        {
            bError = true;
            AlertService.Error("請輸入日期");
        }

        if (bError)
        {
            return;
        }
        #endregion

        msgId = type + "JSON" + date + account;
        string request = "";
        string apiUrl = "";
        string responseMsg = "";

        if (type == "CAMT052")
        {
            apiUrl = ServerData.CAMT052_Api_Url;
            request = "{\"header\": {\"msgId\": \"" + msgId + "\",\"orgId\": \"" + orgId + "\",\"timeStamp\": \"" + DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss.fff") + "\",\"ctry\": \"TW\"},\"txnInfo\": {\"accountNo\": \"" + account + "\",\"accountCcy\": \"" + accountCcy + "\",\"messageType\": \"CAMT052JSON\"}}";
        }
        if (type == "CAMT053")
        {
            apiUrl = ServerData.CAMT053_Api_Url;
            request = "{\"header\": {\"msgId\": \"" + msgId + "\",\"orgId\": \"" + orgId + "\",\"timeStamp\": \"" + DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss.fff") + "\",\"ctry\": \"TW\"},\"txnInfo\": {\"accountNo\": \"" + account + "\",\"accountCcy\": \"" + accountCcy + "\",\"bizDate\": \"" + date + "\",\"messageType\": \"CAMT053JSON\"}}";
        }

        try
        {
            // 加密
            Encrypt encrypt = new Encrypt();
            encrypt.IsArmored = true;
            encrypt.IsSigning = true;
            encrypt.CheckIntegrity = true;
            encrypt.PublicKeyFilePath = ServerData.publicKey;
            encrypt.PrivateKeyFilePath = ServerData.privateKey;
            encrypt.PrivateKeyPassword = ServerData.privayeKeyPwd;
            BCPGPEncryptor objPgpEncrypt = new BCPGPEncryptor(encrypt);

            // 送請求
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-api-key", ServerData.keyId);
            httpClient.DefaultRequestHeaders.Add("X-DBS-ORG_ID", orgId);

            string encryptedMessage = objPgpEncrypt.EncryptMessage(request);
            HttpContent httpContent = new StringContent(encryptedMessage);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

            var response = await httpClient.PostAsync(apiUrl, httpContent);
            responseMsg = await response.Content.ReadAsStringAsync();

            // 解密
            Decrypt decrypt = new Decrypt();
            decrypt.IsVerify = true;
            decrypt.PublicKeyFilePath = ServerData.publicKey;
            decrypt.PrivateKeyFilePath = ServerData.privateKey;
            decrypt.PrivateKeyPassword = ServerData.privayeKeyPwd;
            BCPGPDecryptor objPgpDecrypt = new BCPGPDecryptor(decrypt);
            responseMsg = objPgpDecrypt.DecryptMessage(responseMsg);
            Console.WriteLine(responseMsg);


            #region Write data into DB
            //responseMsg = "{\"header\":{\"msgId\":\"CAMT053JSON20220429210589883\",\"orgId\":\"2031842\",\"timeStamp\":\"2022-04-29T10:24:25.326\",\"ctry\":\"TW\"},\"txnEnqResponse\":{\"enqStatus\":\"RJCT\",\"enqRejectCode\":\"I301\",\"enqStatusDescription\":\"No statement available\"}}";//要刪掉
            JObject jsonObj = (JObject)JsonConvert.DeserializeObject(responseMsg);
            if (type == "CAMT052")
            {

            }


            if (type == "CAMT053")
            {
                if (jsonObj["txnEnqResponse"]["enqRejectCode"] == null && jsonObj["txnEnqResponse"]["enqStatus"].ToString() == "ACSP")
                {
                    var repeatBalance = jsonObj["txnEnqResponse"]["statements"][0]["bkToCstmrStmt"]["stmt"][0]["bal"];
                    var repeatTrade = jsonObj["txnEnqResponse"]["statements"][0]["bkToCstmrStmt"]["stmt"][0]["ntry"];
                    decimal startBal, endBal;
                    Dictionary<string, decimal> MyDic = new Dictionary<string, decimal>();

                    if (repeatBalance != null)
                    {
                        foreach (JObject arr in repeatBalance)
                        {
                            string id = jsonObj["header"]["msgId"].ToString();
                            string creDt = Convert.ToDateTime(jsonObj["txnEnqResponse"]["statements"][0]["bkToCstmrStmt"]["stmt"][0]["creDtTm"]).ToString("yyyy-MM-dd'T'HH:mm:sszzz");
                            string accountNo = jsonObj["txnEnqResponse"]["acctInfo"]["accountNo"].ToString();
                            string accountCcy = jsonObj["txnEnqResponse"]["acctInfo"]["accountCcy"].ToString();
                            string balanceType = arr["tp"]["cdOrPrtry"]["cd"].ToString();
                            decimal balanceAmount = Convert.ToDecimal(arr["amt"]["value"]);
                            string balanceDt = Convert.ToString(arr["dt"]["dt"]);
                            MyDic.Add(balanceType, balanceAmount);

                            query = "Insert Into DBS_053_Balance(id,type,creDt,accountBank,accountNo,accountCcy,balanceType,balanceAmount,balanceDt)values('" + id + "','CAMT053','" + creDt + "','DBS','" + accountNo + "','" + accountCcy + "','" + balanceType + "'," + balanceAmount + ",'" + balanceDt + "')";
                            SQLSite.ExecuteComm(query);
                        }
                    }

                    startBal = MyDic["OPBD"];
                    endBal = MyDic["CLBD"];

                    if (repeatTrade != null)
                    {
                        var i = 0;
                        foreach (JObject arr in repeatTrade)
                        {
                            string id = jsonObj["header"]["msgId"].ToString();
                            string creDt = Convert.ToDateTime(jsonObj["txnEnqResponse"]["statements"][0]["bkToCstmrStmt"]["stmt"][0]["creDtTm"]).ToString("yyyy-MM-dd'T'HH:mm:sszzz");
                            string accountNo = jsonObj["txnEnqResponse"]["acctInfo"]["accountNo"].ToString();
                            string accountCcy = jsonObj["txnEnqResponse"]["acctInfo"]["accountCcy"].ToString();
                            decimal amount = Convert.ToDecimal(arr["amt"]["value"]);
                            decimal balance;
                            string cdtDbtInd = arr["cdtDbtInd"].ToString();
                            string status = arr["sts"].ToString();
                            string bookgDt = Convert.ToDateTime(arr["bookgDt"]["dtTm"]).ToString("yyyy-MM-dd'T'HH:mm:sszzz");
                            string acctSvcrRef = arr["acctSvcrRef"].ToString();
                            string valDt = Convert.ToString(arr["valDt"]["dt"]);
                            string dbtrName = arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["dbtr"] != null ? arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["dbtr"]["nm"].ToString().Replace("'", "''") : "";
                            string cdtrName = arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["cdtr"] != null ? arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["cdtr"]["nm"].ToString().Replace("'", "''") : "";
                            string anotherAct = "";


                            if (arr["cdtDbtInd"].ToString() == "CRDT")
                            {
                                anotherAct = arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["dbtrAcct"] != null ? arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["dbtrAcct"]["id"]["othr"]["id"].ToString() : null;
                                balance = startBal + amount;
                                startBal = balance;
                            }
                            else
                            {
                                anotherAct = arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["cdtrAcct"] != null ? arr["ntryDtls"][0]["txDtls"][0]["rltdPties"]["cdtrAcct"]["id"]["othr"]["id"].ToString() : null;
                                balance = startBal - amount;
                                startBal = balance;
                            }

                            query = "Insert Into DBS_053_Trade (id,type,creDt,accountBank,accountNo,accountCcy,amount,balance,cdtDbtInd,status,bookgDt,acctSvcrRef,valDt,dbtrName,cdtrName,anotherAct) values('" + id + "', 'CAMT053', '" + creDt + "', 'DBS', '" + accountNo + "', '" + accountCcy + "', " + amount + ", " + balance + ", '" + cdtDbtInd + "', '" + status + "', '" + bookgDt + "', '" + acctSvcrRef + "', '" + valDt + "', '" + dbtrName + "', '" + cdtrName + "', '" + anotherAct + "')";

                            SQLSite.ExecuteComm(query);

                            //if (i == ((JArray)repeatTrade).Count - 1)
                            //{
                            //    if (startBal != endBal)
                            //    {
                            //        throw new Exception("金額有誤");
                            //    }
                            //}

                            //i++;
                        }
                    }
                }
                else
                {
                    throw new Exception("無法取得資料");
                }
            }
            #endregion

            //Log
            if (ServerData.m_LogS.Count(r => r.accountNo.Trim() == account && r.date.ToString("yyyyMMdd") == date) == 0)
            {
                query = "Insert Into DBS_LOG(bank,accountNo,type,date,data,status) values('DBS','" + account + "','CAMT053','" + date + "','" + responseMsg.Replace("'", "''") + "','S')";
            }
            else
            {
                query = "Update DBS_LOG Set data = '" + responseMsg + "',status = 'S',update_date = GETDATE() Where bank='DBS' AND type='CAMT053' AND accountNo='" + account + "' AND date='" + date + "'";
            }

            Console.WriteLine("Insert Into DBS_LOG SQL: " + query);
            SQLSite.ExecuteComm(query);

            AlertService.Info("補資料完成");
        }
        catch (Exception ex)
        {
            query = "Update DBS_LOG Set data = '" + responseMsg.Replace("'", "''") + "',message='" + ex.Message + "',update_date = GETDATE() Where bank='DBS' AND type='CAMT053' AND accountNo='" + account + "' AND date='" + date + "'";
            SQLSite.ExecuteComm(query);

            AlertService.Error("補資料失敗");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591
