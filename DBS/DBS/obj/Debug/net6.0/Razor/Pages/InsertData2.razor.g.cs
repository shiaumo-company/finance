#pragma checksum "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4eabca5969074e072285ddae8c8671fc8ee20fa9cc7a362324701705b2fe6ad8"
// <auto-generated/>
#pragma warning disable 1591
namespace DBS.Pages
{
    #line hidden
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
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Insertdata2")]
    public partial class InsertData2 : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>InsertData</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h2 style=\"margin-bottom:15px\">每日報表</h2>\r\n\t\t");
                __builder2.AddMarkupContent(4, "<td>交易日期</td>\r\n\t\t");
                __builder2.OpenElement(5, "td");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "date");
                __builder2.AddAttribute(8, "value", "");
                __builder2.AddAttribute(9, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
                                          EditDateChange 

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n\t\t\t");
                __builder2.OpenElement(11, "select");
                __builder2.AddAttribute(12, "style", "height: 30px;");
                __builder2.AddAttribute(13, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
                                            AccountChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(14, "option");
                __builder2.AddAttribute(15, "value");
                __builder2.AddAttribute(16, "disabled");
                __builder2.AddAttribute(17, "selected");
                __builder2.AddMarkupContent(18, "請選擇帳號");
                __builder2.CloseElement();
#nullable restore
#line 22 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
    foreach (var account2 in ServerData.m_NewAccountS.Where(item => item.baccountDate == editDate)
																			.GroupBy(item => new { item.baccountNo })
																			.Select(group => group.First())
																			.ToArray())
			{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "option");
#nullable restore
#line (27,15)-(27,34) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(20, account2.baccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 28 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
			}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\t\t");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "style", "height: 30px;width :100px;");
                __builder2.AddAttribute(24, "id", "SelectTotal_btn");
                __builder2.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
                                                                           OnClickSelectTotal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(26, "每日總報表");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\t\t");
                __builder2.OpenElement(28, "button");
                __builder2.AddAttribute(29, "style", "height: 30px;width :130px;");
                __builder2.AddAttribute(30, "id", "SelectTotal_btn");
                __builder2.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
                                                                           OnClickSelectIndivual

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "每日各帳戶報表");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\t\t");
                __builder2.OpenElement(34, "table");
                __builder2.AddAttribute(35, "class", "table");
                __builder2.AddAttribute(36, "style", "text-align:right");
                __builder2.AddMarkupContent(37, "<thead><tr><th style=\"text-align:center\">交易日期</th>\r\n\t\t\t\t\t<th>帳號代碼</th>\r\n\t\t\t\t\t<th>我的帳號</th>\r\n\t\t\t\t\t<th>付款方式</th>\r\n\t\t\t\t\t<th>收入</th>\r\n\t\t\t\t\t<th>支出</th>\r\n\t\t\t\t\t<th>對方行帳號</th>\r\n\t\t\t\t\t<th>備註</th></tr></thead>\r\n\t\t\t");
                __builder2.OpenElement(38, "tbody");
                __builder2.AddAttribute(39, "border", "3");
#nullable restore
#line 48 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
     if (m_NewAccountS != null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
      foreach (var account in m_NewAccountS)
					{
						var index = Array.IndexOf(m_NewAccountS, account);
						var isEditing = editStates.ContainsKey(index) && editStates[index];

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(40, "tr");
                __builder2.OpenElement(41, "td");
                __builder2.AddAttribute(42, "style", "text-align:center");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
                            () => toggleDetails(index)

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 57 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
          if (editStates.ContainsKey(index) && editStates[index])
									{

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(45, "<span>▼</span>");
#nullable restore
#line 60 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
									}
									else
									{

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(46, "<span>▶</span>");
#nullable restore
#line 64 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
									}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\t\t\t\t\t\t\t\t    ");
#nullable restore
#line (66,14)-(66,54) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(48, account.baccountDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(50, "td");
#nullable restore
#line (69,15)-(69,37) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(51, account.baccountBankNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line (69,38)-(69,58) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(52, account.baccountBank);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(54, "td");
#nullable restore
#line (70,15)-(70,33) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(55, account.baccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(57, "td");
#nullable restore
#line (71,15)-(71,35) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(58, account.baccountType);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(60, "td");
#nullable restore
#line (72,15)-(72,33) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(61, account.baccountIn);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(63, "td");
#nullable restore
#line (74,15)-(74,34) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(64, account.baccountOut);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(66, "td");
#nullable restore
#line (75,15)-(75,38) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(67, account.baccountOtherNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\t\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(69, "td");
#nullable restore
#line (76,15)-(76,30) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(70, account.bremark);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 78 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
         if (editStates.ContainsKey(index) && editStates[index])
								{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "td");
                __builder2.AddMarkupContent(72, "結存餘額：");
#nullable restore
#line (80,19)-(80,29) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(73, totalmoney);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(74, ", ");
#nullable restore
#line (80,32)-(80,50) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(75, account.baccountIn);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(76, ", ");
#nullable restore
#line (80,53)-(80,72) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(77, account.baccountOut);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(78, ",");
#nullable restore
#line (80,74)-(80,95) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
__builder2.AddContent(79, account.baccountTotal);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 81 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
         
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
      
				}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
       
	private NewAccount[] m_NewAccountS;
	bool bError = false;

	decimal  totalmoney=0;
	public void cal()
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
   foreach (var account in m_NewAccountS)
		{
			totalmoney +=  account.baccountIn - account.baccountOut;

		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\InsertData2.razor"
   
	}
	DateTime editDate;
	public void EditDateChange(ChangeEventArgs e)
	{
		editDate = Convert.ToDateTime(e.Value);
	}
	string account;
	public void AccountChange(ChangeEventArgs e)
	{
		account = e.Value.ToString();
	}
	Dictionary<int, bool> editStates = new Dictionary<int, bool>();
	public void toggleDetails(int index)
	{
		if (editStates.ContainsKey(index))
		{
			editStates[index] = !editStates[index];
		}
		else
		{
			editStates.Add(index, true);
		}
	}
	//每日總報表
	public void OnClickSelectTotal(MouseEventArgs e)
	{
		if (editDate.ToString() == "0001/1/1 上午 12:00:00")
		{
			bError = true;
			AlertService.Error("請輸入開始日期");
		}
		m_NewAccountS = ServerData.m_NewAccountS.Where(item => item.baccountDate == editDate).ToArray();
	}
	//每日各帳戶報表
	public void OnClickSelectIndivual(MouseEventArgs e)
	{
		if (editDate.ToString() == "0001/1/1 上午 12:00:00")
		{
			bError = true;
			AlertService.Error("請輸入開始日期");
		}
		if (string.IsNullOrEmpty(account))
		{
			AlertService.Error("請選擇帳號");
			return;
		}
		m_NewAccountS = ServerData.m_NewAccountS.Where(item => item.baccountDate == editDate && item.baccountNo == account).ToArray();
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591
