﻿using APITester;
using DBS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data.SqlClient;
using System.IO;

namespace DBS.Controllers
{
    [Route("IDN")]
    [ApiController]
    public class IDNController : ControllerBase
    {
        [HttpPost]
        public IActionResult IDN([FromBody] string responseMsg)
        {
            string query = "";
            string account = "";

            try
            {
                if (!Utils.IsValidJson(responseMsg))
                {
                    Decrypt decrypt = new Decrypt();
                    decrypt.IsVerify = true;
                    decrypt.PublicKeyFilePath = ServerData.publicKey;
                    decrypt.PrivateKeyFilePath = ServerData.privateKey;
                    decrypt.PrivateKeyPassword = ServerData.privayeKeyPwd;

                    BCPGPDecryptor objPgpDecrypt = new BCPGPDecryptor(decrypt);
                    responseMsg = objPgpDecrypt.DecryptMessage(responseMsg);
                }

                #region Write data into DB
                JObject jsonObj = (JObject)JsonConvert.DeserializeObject(responseMsg);

                query = "INSERT INTO DBS_IDN (Id, orgId, timeStamp, ctry, txnType, customerReference, txnRefId, txnDate, valueDt, receivingParty_name, receivingParty_accountNo, txnCcy, txnAmt, senderParty_name, senderParty_accountNo, senderParty_bankId, paymentDetails)VALUES(@Id, @orgId, @timeStamp, @ctry, @txnType, @customerReference, @txnRefId, @txnDate, @valueDt, @receivingParty_name, @receivingParty_accountNo, @txnCcy, @txnAmt, @senderParty_name, @senderParty_accountNo, @senderParty_bankId, @paymentDetails)";
                
                using (SqlConnection cn = new SqlConnection(Data.SqlData.Sql_ConnectStr))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        account = jsonObj["txnInfo"]["receivingParty"]["accountNo"].ToString();
                        cmd.Parameters.AddWithValue("@Id", jsonObj["header"]["msgId"].ToString());
                        cmd.Parameters.AddWithValue("@orgId", jsonObj["header"]["orgId"].ToString());
                        cmd.Parameters.AddWithValue("@timeStamp", DateTime.Parse(Convert.ToDateTime(jsonObj["header"]["timeStamp"]).ToString("yyyy-MM-dd HH:mm:ss.fff")));
                        cmd.Parameters.AddWithValue("@ctry", jsonObj["header"]["ctry"].ToString());
                        cmd.Parameters.AddWithValue("@txnType", jsonObj["txnInfo"]["txnType"].ToString());
                        cmd.Parameters.AddWithValue("@customerReference", jsonObj["txnInfo"]["customerReference"].ToString());
                        cmd.Parameters.AddWithValue("@txnRefId", jsonObj["txnInfo"]["txnRefId"].ToString());
                        cmd.Parameters.AddWithValue("@txnDate", Convert.ToDateTime(jsonObj["txnInfo"]["txnDate"]));
                        cmd.Parameters.AddWithValue("@valueDt", Convert.ToDateTime(jsonObj["txnInfo"]["valueDt"]));
                        cmd.Parameters.AddWithValue("@receivingParty_name", jsonObj["txnInfo"]["receivingParty"]["name"].ToString());
                        cmd.Parameters.AddWithValue("@receivingParty_accountNo", jsonObj["txnInfo"]["receivingParty"]["accountNo"].ToString());
                        cmd.Parameters.AddWithValue("@txnCcy", jsonObj["txnInfo"]["amtDtls"]["txnCcy"].ToString());
                        cmd.Parameters.AddWithValue("@txnAmt", Convert.ToDecimal(jsonObj["txnInfo"]["amtDtls"]["txnAmt"]));
                        cmd.Parameters.AddWithValue("@senderParty_name", jsonObj["txnInfo"]["senderParty"]["name"].ToString());
                        cmd.Parameters.AddWithValue("@senderParty_accountNo", jsonObj["txnInfo"]["senderParty"]["accountNo"].ToString());
                        cmd.Parameters.AddWithValue("@senderParty_bankId", jsonObj["txnInfo"]["senderParty"]["senderBankId"].ToString());
                        cmd.Parameters.AddWithValue("@paymentDetails", jsonObj["txnInfo"]["rmtInf"]["paymentDetails"].ToString());

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                #endregion

                #region Log
                query = "Insert Into DBS_LOG(bank,type,accountNo,data,date,status) values('DBS','IDN','" + account + "','" + responseMsg + "','" + DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "") + "','S')";
                SQLSite.ExecuteComm(query);
                #endregion

                return Ok();
            }
            catch (Exception ex)
            {
                query = "Insert Into DBS_LOG(bank,type,accountNo,data,date,message,status) values('DBS','IDN','" + account + "','" + responseMsg + "','" + DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "") + "','" + ex.Message + "','N')";
                SQLSite.ExecuteComm(query);

                return NotFound();
            }
        }
    }
}
