#pragma checksum "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7dea6972aafb6f6ec0d86a9a9def4dd11584ebabdbac11339cc924f4e734ffc4"
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
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/SelectAccount")]
    public partial class SelectAccount : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-9c0dvomrrc>SelectAccount</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<head b-9c0dvomrrc><link href=""styles/site.css"" rel=""stylesheet"" b-9c0dvomrrc>
	<link rel=""stylesheet"" href=""https://lf3-cdn-tos.bytecdntp.com/cdn/expire-1-M/font-awesome/4.7.0/css/font-awesome.min.css"" b-9c0dvomrrc>
	<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/open-iconic/1.1.1/font/css/open-iconic-bootstrap.min.css"" integrity=""sha512-XNkCjx/a0lED2ktq3KaBz1v62cxVvLU9y+gZLnhyl4+btRhe+uxLw6J/9M+k2JvZFsX5v9FxVjH4D2u5JUdw=="" b-9c0dvomrrc>
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"" b-9c0dvomrrc>
	<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8"" crossorigin=""anonymous"" b-9c0dvomrrc></script></head>
");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.AddAttribute(6, "style", "text-align:right");
                __builder2.AddAttribute(7, "b-9c0dvomrrc");
                __builder2.OpenElement(8, "thead");
                __builder2.AddAttribute(9, "b-9c0dvomrrc");
                __builder2.OpenElement(10, "ul");
                __builder2.AddAttribute(11, "class", "nav nav-tabs");
                __builder2.AddAttribute(12, "b-9c0dvomrrc");
#nullable restore
#line 27 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
      foreach (var banks in BankData.GetBankList())
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
       if (DataVersionService.DataVersion != 1)//如果有變更則要重新去資料庫抓資料，即時更新
						{
							AccountRepair[] updatedData = UpdateAccountRepairALL();
							var distinctRepairs = updatedData.Where(repairs => repairs.baccountBankNo == banks.BankCode.ToString().Substring(0, 3))
							.GroupBy(item => item.baccountNo)
							.Select(group => group.First()).ToArray();
							if (distinctRepairs.Any())
							{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "li");
                __builder2.AddAttribute(14, "class", "nav-item");
                __builder2.AddAttribute(15, "b-9c0dvomrrc");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
                           (() => {ShowSection(int.Parse(banks.BankCode.Substring(0,3)));OnClickSelect(banks.BankCode);})

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "class", "nav-link" + " " + (
#nullable restore
#line 38 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
                                                                                                                                            GetTabClass(int.Parse(banks.BankCode.Substring(0,3)))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "b-9c0dvomrrc");
#nullable restore
#line 38 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(20, banks.BankCode.Substring(3));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 40 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
							}
						}
						else
						{
							var distinctRepairs = ServerData.m_AccountRepairS.Where(repairs => repairs.baccountBankNo == banks.BankCode.ToString().Substring(0, 3))
							.GroupBy(item => item.baccountNo)
							.Select(group => group.First()).ToArray();
							if (distinctRepairs.Any())
							{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "nav-item");
                __builder2.AddAttribute(23, "b-9c0dvomrrc");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
                           (() => {ShowSection(int.Parse(banks.BankCode.Substring(0,3)));OnClickSelect(banks.BankCode);})

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "class", "nav-link" + " " + (
#nullable restore
#line 50 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
                                                                                                                                            GetTabClass(int.Parse(banks.BankCode.Substring(0,3)))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "b-9c0dvomrrc");
#nullable restore
#line 50 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(28, banks.BankCode.Substring(3));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
							}
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
       
					}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\t\t");
                __builder2.OpenElement(30, "table");
                __builder2.AddAttribute(31, "class", "table");
                __builder2.AddAttribute(32, "style", "text-align:right");
                __builder2.AddAttribute(33, "b-9c0dvomrrc");
                __builder2.AddMarkupContent(34, "<thead b-9c0dvomrrc><tr b-9c0dvomrrc><th b-9c0dvomrrc>加入日期</th>\r\n\t\t\t\t\t\t\t\t<th b-9c0dvomrrc>銀行代碼</th>\r\n\t\t\t\t\t\t\t\t<th b-9c0dvomrrc>帳號</th>\r\n\t\t\t\t\t\t\t\t<th b-9c0dvomrrc>地址</th>\r\n\t\t\t\t\t\t\t\t<th b-9c0dvomrrc>備註</th></tr></thead>\r\n\t\t\t");
                __builder2.OpenElement(35, "tbody");
                __builder2.AddAttribute(36, "b-9c0dvomrrc");
#nullable restore
#line 70 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
     if (m_AccountRepairS != null)
				{					
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
      foreach (var (account, i) in m_AccountRepairS.Select((account, i) => (account, i)))
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "tr");
                __builder2.AddAttribute(38, "b-9c0dvomrrc");
                __builder2.OpenElement(39, "td");
                __builder2.AddAttribute(40, "style", "text-align:center");
                __builder2.AddAttribute(41, "b-9c0dvomrrc");
#nullable restore
#line 75 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(42, account.baccountInsert.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(44, "td");
                __builder2.AddAttribute(45, "b-9c0dvomrrc");
#nullable restore
#line 76 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(46, account.baccountBankNo);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(47, " ");
#nullable restore
#line 76 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(48, account.baccountBank);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(49, "<br b-9c0dvomrrc>\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(50, "span");
                __builder2.AddAttribute(51, "b-9c0dvomrrc");
#nullable restore
#line 77 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(52, account.baccountBranchNo);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, " ");
#nullable restore
#line 77 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(54, account.baccountBranch);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\t\t\t\t\t\t<br b-9c0dvomrrc>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(57, "td");
                __builder2.AddAttribute(58, "b-9c0dvomrrc");
#nullable restore
#line 80 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(59, account.baccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(61, "td");
                __builder2.AddAttribute(62, "b-9c0dvomrrc");
#nullable restore
#line 81 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(63, account.baccountAddress);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(65, "td");
                __builder2.AddAttribute(66, "b-9c0dvomrrc");
#nullable restore
#line 82 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
__builder2.AddContent(67, account.bremark);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\t\t\t\t\t\t<td b-9c0dvomrrc></td>");
                __builder2.CloseElement();
#nullable restore
#line 85 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"

					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
      
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
#line 95 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\SelectAccount.razor"
 
	protected override void OnInitialized()
	{
		base.OnInitialized();
		OnClickSelect_All(); // 在頁面初始化時自動調用 onclickselect_all 方法
	}

	public void OnClickSelect_All()
	{
		try
		{
			// 判斷資料庫是否有變動
			if (DataVersionService.DataVersion != 1)
			{
				m_AccountRepairS = Array.Empty<AccountRepair>();
				AccountRepair[] updatedData = UpdateAccountRepairALL();
				m_AccountRepairS = updatedData.GroupBy(item => item.baccountBank) // 按帳號分組
				.Select(group => group.OrderBy(item => item.baccountBank)
							.ThenBy(item => item.baccountBranch)
							.ThenBy(item => item.baccountNo))
				.SelectMany(sortedGroup => sortedGroup).ToArray();
			}
			else
			{
				
				//UpdateNewData();
				m_AccountRepairS = Array.Empty<AccountRepair>();
				m_AccountRepairS = ServerData.m_AccountRepairS.GroupBy(item => item.baccountBank) // 按帳號分組
				.Select(group => group.OrderBy(item => item.baccountBank)
							.ThenBy(item => item.baccountBranch)
							.ThenBy(item => item.baccountNo))
				.SelectMany(sortedGroup => sortedGroup).ToArray();
			}
		}
		catch (Exception msg)
		{
			kkk = msg.Message;
		}
		AlertService.Success($"總共查詢到{m_AccountRepairS.Count()}筆資料");
		if (m_AccountRepairS == null)
		{
			AlertService.Warn("尚無資料");
		}

	}

	private int currentSection = 1;

	private void ShowSection(int section)
	{
		currentSection = section;
	}

	private string GetTabClass(int section)
	{
		return section == currentSection ? "active" : "";
	}

	string kkk = "";

	private NewAccount[] m_NewAccountS;
	private AccountRepair[] m_AccountRepairS;
	public void OnClickSelect(string bankcode)
	{
		try
		{
			// 判斷資料庫是否有變動
			if (DataVersionService.DataVersion != 1)
			{
				m_AccountRepairS = Array.Empty<AccountRepair>();
				AccountRepair[] updatedData = UpdateAccountRepairALL();
				m_AccountRepairS = updatedData.ToArray();
			}
			else
			{
				//UpdateNewData();
				if (m_AccountRepairS == null)
				{
					m_AccountRepairS = ServerData.m_AccountRepairS.Where(item => item.baccountBank == bankcode.Substring(3)).ToArray();
				}
				else
				{
					m_AccountRepairS = Array.Empty<AccountRepair>();
					m_AccountRepairS = ServerData.m_AccountRepairS.Where(item => item.baccountBank == bankcode.Substring(3)).ToArray();
				}
			}
		}
		catch (Exception msg)
		{
			kkk = msg.Message;
		}
		AlertService.Success($"總共查詢到{m_AccountRepairS.Count()}筆資料");
		if (m_AccountRepairS == null)
		{
			AlertService.Warn("尚無資料");
		}
	}

	public AccountRepair[] UpdateAccountRepairALL()
	//專門給選擇銀行後跳出對應帳戶用的更新資料(有時候可能會先使用銀行維護去新增資料，這時候就要用他嚕)
	{
		// 新資料列表
		List<AccountRepair> newDataList = GetAccountRepair();
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_AccountRepairS = newDataList.ToArray();
		return m_AccountRepairS;

	}
	
	public DataSet dataset = new DataSet();
	public List<AccountRepair> GetAccountRepair()//再次抓取資料
	{
		List<AccountRepair> newDataList = new List<AccountRepair>();
		//SqlConnection sqlconnection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
		string connectionString = "Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022";
		string SQLString = "SELECT * FROM NewAccountRepair ";
		dataset = new DataSet();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			using (SqlCommand command = new SqlCommand(SQLString, connection))
			{
				try
				{
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							AccountRepair newData = new AccountRepair
								{
									// 這裡的屬性賦值根據您的資料表結構進行調整
									baccountBank = reader.GetString(reader.GetOrdinal("accountBank")),
									baccountBankNo = reader.GetString(reader.GetOrdinal("accountBankNo")),
									baccountBranch = reader.GetString(reader.GetOrdinal("accountBranch")),
									baccountBranchNo = reader.GetString(reader.GetOrdinal("accountBranchNo")),
									baccountNo = reader.GetString(reader.GetOrdinal("accountNo")),
									baccountAddress = reader.GetString(reader.GetOrdinal("accountAddress")),
									baccountInitialMoney = reader.IsDBNull(reader.GetOrdinal("accountInitialMoney")) ? 0 : reader.GetDecimal(reader.GetOrdinal("accountInitialMoney")),
									bremark = reader.IsDBNull(reader.GetOrdinal("remark")) ? "" : reader.GetString(reader.GetOrdinal("remark")),
									baccountInsert = reader.IsDBNull(reader.GetOrdinal("accountInsert")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("accountInsert")),
									baccountUpdate = reader.IsDBNull(reader.GetOrdinal("accountUpdate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("accountUpdate")),

									// 其他屬性...
								};
							newDataList.Add(newData);
						}
					}
				}
				catch (Exception ex)
				{
					kkk += ex.Message;
				}
			}
		}
		return newDataList;
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
