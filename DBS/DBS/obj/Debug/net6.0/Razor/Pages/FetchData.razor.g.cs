#pragma checksum "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0172213171fbe0ca20909c8afdfcfbdc00aa835f1c5b7907bbdca12ed0276652"
// <auto-generated/>
#pragma warning disable 1591
namespace DBS.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using DBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\_Imports.razor"
using DBS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 10 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
         if (ServerData.m_TransactionS == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
        }
        else
        {
            //確保有資料!
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
             if (ServerData.m_TransactionS != null && ServerData.m_TransactionS.Any())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(3, "<p>有可顯示的資料。</p>");
#nullable restore
#line 20 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, "<p>沒有可顯示的資料。</p>");
#nullable restore
#line 24 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
             if (ServerData.m_AccountS != null && ServerData.m_AccountS.Any())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(5, "<p>有可顯示的資料。</p>");
#nullable restore
#line 29 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(6, "<p>沒有可顯示的資料。</p>");
#nullable restore
#line 33 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(7, "<h2 style=\"margin-bottom:15px\">歷史交易</h2>\r\n            ");
                __builder2.OpenElement(8, "select");
                __builder2.AddAttribute(9, "style", "height: 30px;");
                __builder2.AddAttribute(10, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                                     BankChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(11, "option");
                __builder2.AddAttribute(12, "value");
                __builder2.AddAttribute(13, "disabled");
                __builder2.AddAttribute(14, "selected");
                __builder2.AddMarkupContent(15, "請選擇銀行");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "option");
                __builder2.AddAttribute(18, "value", "DBS");
                __builder2.AddContent(19, "DBS");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "select");
                __builder2.AddAttribute(22, "style", "height: 30px;");
                __builder2.AddAttribute(23, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                                     AccountChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(24, "option");
                __builder2.AddAttribute(25, "value");
                __builder2.AddAttribute(26, "disabled");
                __builder2.AddAttribute(27, "selected");
                __builder2.AddMarkupContent(28, "請選擇帳號");
                __builder2.CloseElement();
#nullable restore
#line 42 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                 foreach (var account in ServerData.m_AccountS)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", 
#nullable restore
#line 44 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                   account.accountNo

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (44,55)-(44,72) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(31, account.accountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 45 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "date");
                __builder2.AddAttribute(35, "value", "");
                __builder2.AddAttribute(36, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                                   BeginDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "date");
                __builder2.AddAttribute(40, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                          EndDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                              OnClickSearch

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(44, "查詢");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                              CheckDatabaseConnection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(48, "測試連接");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "p");
#nullable restore
#line (51,17)-(51,30) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(51, resultMessage);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            <div style=\"height:40px\"></div>");
                __builder2.OpenElement(53, "table");
                __builder2.AddAttribute(54, "class", "table");
                __builder2.AddAttribute(55, "style", "text-align:right");
                __builder2.AddMarkupContent(56, @"<thead><tr><th style=""text-align:center"">交易日期</th>
                        <th>收入</th>
                        <th>支出</th>
                        <th>結存餘額</th>
                        <th>對方行帳號</th>
                        <th>備註</th></tr></thead>
                ");
                __builder2.OpenElement(57, "tbody");
#nullable restore
#line 66 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                     if (m_TransactionS != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                         foreach (var trade in m_TransactionS)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(58, "tr");
                __builder2.OpenElement(59, "td");
                __builder2.AddAttribute(60, "style", "text-align:center");
#nullable restore
#line (71,64)-(71,95) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(61, trade.valDt.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 72 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                 if (trade.cdtDbtInd.Equals("CRDT"))
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(62, "td");
#nullable restore
#line (74,42)-(74,68) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(63, trade.amount.ToString("N"));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(64, "<td>0</td>");
#nullable restore
#line 79 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                 if (trade.cdtDbtInd.Equals("DBIT"))
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(65, "td");
#nullable restore
#line (82,42)-(82,68) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(66, trade.amount.ToString("N"));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 83 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(67, "<td>0</td>");
#nullable restore
#line 87 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(68, "td");
#nullable restore
#line (88,38)-(88,65) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(69, trade.balance.ToString("N"));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                ");
                __builder2.OpenElement(71, "td");
#nullable restore
#line (89,38)-(89,54) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
__builder2.AddContent(72, trade.anotherAct);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                <td></td>");
                __builder2.CloseElement();
#nullable restore
#line 92 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 96 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(74, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\FetchData.razor"
       
    private Transaction[] m_TransactionS;
    string bank;
    string account;
    DateTime beginDate;
    DateTime endDate;


    public void BankChange(ChangeEventArgs e)
    {
        bank = e.Value.ToString();
    }

    public void AccountChange(ChangeEventArgs e)
    {
        account = e.Value.ToString();
    }

    public void BeginDateChange(ChangeEventArgs e)
    {
        beginDate = Convert.ToDateTime(e.Value);
    }

    public void EndDateChange(ChangeEventArgs e)
    {
        endDate = Convert.ToDateTime(e.Value);
    }

    public void OnClickSearch(MouseEventArgs e)
    {
        bool bError = false;
        if (string.IsNullOrWhiteSpace(bank))
        {
            bError = true;
            AlertService.Error("請選擇銀行");
        }
        if (string.IsNullOrWhiteSpace(account))
        {
            bError = true;
            AlertService.Error("請選擇帳號");
        }
        if (beginDate.ToString() == "0001/1/1 上午 12:00:00")
        {
            bError = true;
            AlertService.Error("請輸入開始日期");
        }
        if (endDate.ToString() == "0001/1/1 上午 12:00:00")
        {
            bError = true;
            AlertService.Error("請輸入結束日期");
        }

        if (bError)
        {
            m_TransactionS = null;
            return;
        }

        m_TransactionS = ServerData.m_TransactionS.Where(item => item.accountBank == bank && item.accountNo == account && item.valDt >= beginDate && item.valDt <= endDate).ToArray();

        if (m_TransactionS == null || m_TransactionS.Length <= 0)
        {
            AlertService.Error("查無資料");
        }
    }
    //確保有連接資料庫成功
    string resultMessage = "No connection attempt made yet.";
    SqlConnection connection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
    void CheckDatabaseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
            resultMessage = "Connected to the database successfully!";
        }
        else if (connection.State == System.Data.ConnectionState.Open)
        {
            resultMessage = "Connection is already open.";
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
