#pragma checksum "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6116db53cd2132a5636f97ccc22d23d1f522c003a5b7931cdb62460fa4edd27c"
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
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/MonthlyAccountSummary/{subBank2}/{subAccount}")]
    public partial class MonthlyAccountSummary : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><link href=\"styles/site.css\" rel=\"stylesheet\"></head>\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "h2");
#nullable restore
#line (19,10)-(19,39) 25 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(4, editDate.ToString("yyyy年MM月"));

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(5, " <br>");
#nullable restore
#line (19,46)-(19,88) 25 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(6, subBank2.Substring(0, subBank2.Length - 3));

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(7, " <br>");
#nullable restore
#line (19,95)-(19,105) 25 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(8, subAccount);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(9, " 月匯表");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n\t\t");
                __builder2.AddMarkupContent(11, "<td> 查詢月份 </td>\r\n\t\t");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "style", "height: 30px;width :175px;");
                __builder2.AddAttribute(14, "type", "month");
                __builder2.AddAttribute(15, "value", "");
                __builder2.AddAttribute(16, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
                                                                             EditDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\t\t");
                __builder2.OpenElement(18, "table");
                __builder2.AddAttribute(19, "class", "table");
                __builder2.AddAttribute(20, "style", "text-align:right; margin-top:20px;");
                __builder2.AddMarkupContent(21, "<thead><tr><td>銀行名稱</td>\r\n\t\t\t\t<td>銀行帳號</td>\r\n\t\t\t\t<td>餘額</td></tr></thead>\r\n\t\t");
                __builder2.OpenElement(22, "tbody");
#nullable restore
#line 31 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
    if (ServerData.m_NewAccountS != null)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
     if (DataVersionService.DataVersion != 1)//如果有變更則要重新去資料庫抓資料，即時更新
				{
					NewAccount[] updatedData = UpdateNewDataALL2();
					var groupedAccounts = updatedData.Where(account => account.baccountDate >= editDateMin_dt && account.baccountDate <= editDateMax_dt && account.baccountNo == subAccount)
					.GroupBy(account => new { account.baccountBank, account.baccountNo })
					.Select(group => new
					{
						Bank = group.Key.baccountBank,
						Branch = group.FirstOrDefault().baccountBranch, // 取得分組中第一個元素的 baccountBranch
						AccountNo = group.Key.baccountNo,
						Total = group.Sum(account => account.baccountIn - account.baccountOut)
					}).ToList();
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
      foreach (var (account, i) in groupedAccounts.Select((account, i) => (account, i)))
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "tr");
                __builder2.OpenElement(24, "td");
#nullable restore
#line (48,13)-(48,25) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(25, account.Bank);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(26, "<br>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line (49,9)-(49,23) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(27, account.Branch);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(28, "<br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(30, "td");
#nullable restore
#line (50,13)-(50,30) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(31, account.AccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(33, "td");
#nullable restore
#line (51,13)-(51,26) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(34, account.Total);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\t\t\t\t\t\t\t<td></td>");
                __builder2.CloseElement();
#nullable restore
#line 54 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
      
				}
				else
				{
					var groupedAccounts = ServerData.m_NewAccountS.Where(account => account.baccountDate >= editDateMin_dt && account.baccountDate <= editDateMax_dt && account.baccountNo == subAccount)
					.GroupBy(account => new { account.baccountBank, account.baccountNo })
					.Select(group => new
					{
						Bank = group.Key.baccountBank,
						Branch = group.FirstOrDefault().baccountBranch, // 取得分組中第一個元素的 baccountBranch
						AccountNo = group.Key.baccountNo,
						Total = group.Sum(account => account.baccountIn - account.baccountOut)
					}).ToList();
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
      foreach (var (account, i) in groupedAccounts.Select((account, i) => (account, i)))
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "tr");
                __builder2.OpenElement(37, "td");
#nullable restore
#line (70,13)-(70,25) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(38, account.Bank);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(39, "<br>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line (71,9)-(71,23) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(40, account.Branch);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(41, "<br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(43, "td");
#nullable restore
#line (72,13)-(72,30) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(44, account.AccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(46, "td");
#nullable restore
#line (73,13)-(73,26) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(47, account.Total);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\t\t\t\t\t\t\t<td></td>");
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
       
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
      
				}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\t\t");
                __builder2.OpenElement(50, "tfoot");
#nullable restore
#line 81 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
    if (ServerData.m_NewAccountS != null)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
     if (DataVersionService.DataVersion != 1)//如果有變更則要重新去資料庫抓資料，即時更新
				{
					NewAccount[] updatedData = UpdateNewDataALL2();
					var groupedAccounts = updatedData.Where(account => account.baccountDate >= editDateMin_dt && account.baccountDate <= editDateMax_dt && account.baccountNo == subAccount)
					.GroupBy(account => new { account.baccountBank, account.baccountNo })
					.Select(group => new
					{
						Total = group.Sum(account => account.baccountIn - account.baccountOut)
					}).ToList();
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
      foreach (var (account, i) in groupedAccounts.Select((account, i) => (account, i)))
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "tr");
                __builder2.AddMarkupContent(52, "<td></td>\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(53, "<td>合計</td>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(54, "td");
#nullable restore
#line (97,13)-(97,58) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(55, groupedAccounts.Sum(account => account.Total));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 99 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
      
				}
				else
				{
					var groupedAccounts = ServerData.m_NewAccountS.Where(account => account.baccountDate >= editDateMin_dt && account.baccountDate <= editDateMax_dt && account.baccountNo == subAccount)
					.GroupBy(account => new { account.baccountBank, account.baccountNo })
					.Select(group => new
					{
						Total = group.Sum(account => account.baccountIn - account.baccountOut)
					}).ToList();

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(56, "tr");
                __builder2.AddMarkupContent(57, "<td></td>\r\n\t\t\t\t\t\t");
                __builder2.AddMarkupContent(58, "<td>合計</td>\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(59, "td");
#nullable restore
#line (112,12)-(112,57) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
__builder2.AddContent(60, groupedAccounts.Sum(account => account.Total));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 114 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
     
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
#line 121 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\MonthlyAccountSummary.razor"
       
	[Parameter]
	public string subAccount { get; set; }

	[Parameter]
	public string subBank2 { get; set; }

	String editDateMin, editDateMax;
	DateTime editDate, editDateMin_dt, editDateMax_dt;
	int currentMonth;
	protected override void OnInitialized()
	{
		// 初始化 editDate 為今天的日期
		editDate = DateTime.Today;
		// 獲取今天的月份
		currentMonth = editDate.Month;
		switch (currentMonth.ToString())
		{
			case "1":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "2":
				string yearString = editDate.ToString("yyyy");
				int year = int.Parse(yearString);
				if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
				{
					editDateMin = editDate.ToString("yyyy-MM") + "-01";
					editDateMax = editDate.ToString("yyyy-MM") + "-29";
					editDateMin_dt = DateTime.Parse(editDateMin);
					editDateMax_dt = DateTime.Parse(editDateMax);
				}
				else
				{
					editDateMin = editDate.ToString("yyyy-MM") + "-01";
					editDateMax = editDate.ToString("yyyy-MM") + "-28";
					editDateMin_dt = DateTime.Parse(editDateMin);
					editDateMax_dt = DateTime.Parse(editDateMax);
				}
				break;
			case "3":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "4":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "5":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "6":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "7":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				break;
			case "8":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "9":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "10":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "11":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "12":
				editDateMin = editDate.ToString("yyyy-MM") + "-01";
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMin_dt = DateTime.Parse(editDateMin);
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;

		}
	}
	string kkk = "";
	public void EditDateChange(ChangeEventArgs e)
	{
		editDate = Convert.ToDateTime(e.Value);
		currentMonth = editDate.Month;
		editDateMin = editDate.ToString("yyyy-MM-dd");
		editDateMin_dt = DateTime.Parse(editDateMin);
		switch (currentMonth.ToString())
		{
			case "1":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "2":
				string yearString = editDate.ToString("yyyy");
				int year = int.Parse(yearString);
				if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
				{
					editDateMax = editDate.ToString("yyyy-MM") + "-29";
					editDateMax_dt = DateTime.Parse(editDateMax);
				}
				else
				{
					editDateMax = editDate.ToString("yyyy-MM") + "-28";
					editDateMax_dt = DateTime.Parse(editDateMax);
				}
				break;
			case "3":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "4":
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "5":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "6":
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "7":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "8":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "9":
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "10":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "11":
				editDateMax = editDate.ToString("yyyy-MM") + "-30";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
			case "12":
				editDateMax = editDate.ToString("yyyy-MM") + "-31";
				editDateMax_dt = DateTime.Parse(editDateMax);
				break;
		}
	}
	public NewAccount[] m_NewAccountS;
	public NewAccount[] UpdateNewDataALL2()
	{
		// 將 NewAccount[] 陣列轉換為 List<NewAccount>
		List<NewAccount> newList = ServerData.m_NewAccountS.ToList();
		// 新資料列表
		List<NewAccount> newDataList = GetNewData();
		// 使用 LINQ 的 Except 方法排除已經存在的資料
		newDataList = newDataList.Except(newList).ToList();
		// 使用 AddRange 將新資料列表添加到現有的列表中
		newList.AddRange(newDataList);
		// 將結果轉換回陣列
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_NewAccountS = newDataList.ToArray();
		return m_NewAccountS;
	}

	public DataSet dataset = new DataSet();
	public List<NewAccount> GetNewData()//再次抓取資料
	{
		List<NewAccount> newDataList = new List<NewAccount>();
		//SqlConnection sqlconnection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
		string connectionString = "Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022";
		string SQLString = "SELECT ROW_NUMBER() OVER (PARTITION　BY accountBank, accountNo ORDER BY  accountDate ASC )  , * FROM NewAccountInfo; ";
		dataset = new DataSet();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			using (SqlCommand command = new SqlCommand(SQLString, connection))
			{
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						NewAccount newData = new NewAccount
							{
								// 這裡的屬性賦值根據您的資料表結構進行調整
								baccountDate = reader.GetDateTime(reader.GetOrdinal("accountDate")),
								baccountBank = reader.GetString(reader.GetOrdinal("accountBank")),
								baccountBankNo = reader.GetString(reader.GetOrdinal("accountBankNo")),
								baccountBranch = reader.GetString(reader.GetOrdinal("accountBranch")),
								baccountBranchNo = reader.GetString(reader.GetOrdinal("accountBranchNo")),
								baccountNo = reader.GetString(reader.GetOrdinal("accountNo")),
								baccountType = reader.GetString(reader.GetOrdinal("accountType")),
								baccountIn = reader.IsDBNull(reader.GetOrdinal("accountIn")) ? 0 : reader.GetDecimal(reader.GetOrdinal("accountIn")),
								baccountOut = reader.IsDBNull(reader.GetOrdinal("accountOut")) ? 0 : reader.GetDecimal(reader.GetOrdinal("accountOut")),
								baccountTotal = reader.IsDBNull(reader.GetOrdinal("accountTotal")) ? 0 : reader.GetDecimal(reader.GetOrdinal("accountTotal")),
								baccountOtherNo = reader.GetString(reader.GetOrdinal("accountOtherNo")),
								baccountAddress = reader.GetString(reader.GetOrdinal("accountAddress")),
								bremark = reader.IsDBNull(reader.GetOrdinal("remark")) ? "" : reader.GetString(reader.GetOrdinal("remark")),
								baccountInsert = reader.GetDateTime(reader.GetOrdinal("accountInsert")),
								baccountUpdate = reader.IsDBNull(reader.GetOrdinal("accountUpdate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("accountUpdate")),
								// 其他屬性...
							};
						newDataList.Add(newData);
					}
				}
			}
			return newDataList;
		}
	}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataVersionService DataVersionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591
