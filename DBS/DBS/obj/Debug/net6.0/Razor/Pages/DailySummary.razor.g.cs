#pragma checksum "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c32d4d3ce70911c40dacfa2645306124ddcca31859dced8c162a8193a4fbf18"
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
#line 2 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/DailySummary")]
    public partial class DailySummary : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><link href=\"styles/site.css\" rel=\"stylesheet\"></head>\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "h2");
#nullable restore
#line (18,8)-(18,40) 25 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(4, editDate.ToString("yyyy年MM月dd日"));

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(5, "<br> 銀行日匯總表");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n\t\t");
                __builder2.AddMarkupContent(7, "<td>查詢日期</td>\r\n\t\t");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "style", "height: 30px;width :175px;");
                __builder2.AddAttribute(10, "type", "date");
                __builder2.AddAttribute(11, "value", "");
                __builder2.AddAttribute(12, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
                                                                            EditDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n\t\t");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "table");
                __builder2.AddAttribute(16, "style", "text-align:right; margin-top:20px;");
                __builder2.AddMarkupContent(17, "<thead><tr><td>銀行名稱</td>\r\n\t\t\t\t<td>銀行帳號</td>\r\n\t\t\t\t<td>餘額</td></tr></thead>\r\n\t\t");
                __builder2.OpenElement(18, "tbody");
#nullable restore
#line 30 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
     if (ServerData.m_NewAccountS != null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
      if (DataVersionService.DataVersion != 1)//如果有變更則要重新去資料庫抓資料，即時更新
					{
						NewAccount[] updatedData = UpdateNewDataALL2();
						var groupedAccounts = updatedData.Where(account => account.baccountDate == editDate)
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
#line 44 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
       foreach (var (account, i) in groupedAccounts.Select((account, i) => (account, i)))
						{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "tr");
                __builder2.OpenElement(20, "td");
#nullable restore
#line (47,13)-(47,25) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(21, account.Bank);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(22, "<br>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line (48,9)-(48,23) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(23, account.Branch);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(24, "<br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(26, "td");
#nullable restore
#line (49,13)-(49,30) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(27, account.AccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(29, "td");
#nullable restore
#line (50,13)-(50,26) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(30, account.Total);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\t\t\t\t\t\t\t<td></td>");
                __builder2.CloseElement();
#nullable restore
#line 53 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
       
					}
					else
					{
					 var groupedAccounts = ServerData.m_NewAccountS.Where(account=>account.baccountDate==editDate)
																   .GroupBy(account => new { account.baccountBank, account.baccountNo })
																   .Select(group => new
																   {
																	Bank = group.Key.baccountBank,
																	Branch = group.FirstOrDefault().baccountBranch, // 取得分組中第一個元素的 baccountBranch
																	AccountNo = group.Key.baccountNo,
																	Total = group.Sum(account => account.baccountIn-account.baccountOut)
																	}).ToList();
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
      foreach (var (account, i) in groupedAccounts.Select((account, i) => (account, i)))
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "tr");
                __builder2.OpenElement(33, "td");
#nullable restore
#line (69,13)-(69,25) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(34, account.Bank);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(35, "<br>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line (70,10)-(70,24) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(36, account.Branch);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(37, "<br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(39, "td");
#nullable restore
#line (71,13)-(71,30) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(40, account.AccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(42, "td");
#nullable restore
#line (72,13)-(72,26) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(43, account.Total);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\t\t\t\t\t\t\t<td></td>");
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
      
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
     
			}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\t\t");
                __builder2.OpenElement(46, "tfoot");
#nullable restore
#line 80 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
    if (ServerData.m_NewAccountS != null)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
     if (DataVersionService.DataVersion != 1)//如果有變更則要重新去資料庫抓資料，即時更新
				{
					NewAccount[] updatedData = UpdateNewDataALL2();
					var groupedAccounts = updatedData.Where(account => account.baccountDate == editDate)
													 .GroupBy(account => new { account.baccountBank, account.baccountNo })
													 .Select(group => new
													{
														Total = group.Sum(account => account.baccountIn - account.baccountOut)
													}).ToList();

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "tr");
                __builder2.AddMarkupContent(48, "<td></td>\r\n\t\t\t\t\t\t");
                __builder2.AddMarkupContent(49, "<td>合計</td>\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(50, "td");
#nullable restore
#line (94,12)-(94,57) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(51, groupedAccounts.Sum(account => account.Total));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 96 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
				}
				else
				{
					 var groupedAccounts = ServerData.m_NewAccountS.Where(account=>account.baccountDate==editDate)
																   .GroupBy(account => new { account.baccountBank, account.baccountNo })
																   .Select(group => new
																   {
																	Total = group.Sum(account => account.baccountIn-account.baccountOut)
																	}).ToList();

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(52, "tr");
                __builder2.AddMarkupContent(53, "<td></td>\r\n\t\t\t\t\t");
                __builder2.AddMarkupContent(54, "<td>合計</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(55, "td");
#nullable restore
#line (108,11)-(108,56) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
__builder2.AddContent(56, groupedAccounts.Sum(account => account.Total));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 110 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
     
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
#line 117 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\DailySummary.razor"
       
	[Parameter]
	public string SubBranch { get; set; }

	protected override void OnInitialized()
	{
		// 初始化 editDate 為今天的日期
		editDate = DateTime.Today;
	}

	DateTime editDate;
	public void EditDateChange(ChangeEventArgs e)
	{
		editDate = Convert.ToDateTime(e.Value);
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
