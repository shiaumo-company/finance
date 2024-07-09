// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/SelectAccount")]
    public partial class SelectAccount : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 139 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\SelectAccount.razor"
 
	public IPagedList<AccountRepair> PagedList { get; set; }
	public const int PageSize = 9;//設定每一頁只會有時行
	protected override void OnInitialized()
	{
		base.OnInitialized();
		OnClickSelect_All(); // 在頁面初始化時自動調用 onclickselect_all 方法
								// Simulate fetching data from a data source
		LoadPage(1);
	}

	public void LoadPage(int pageNumber)
	{
		PagedList = m_AccountRepairS.ToPagedList(pageNumber, PageSize);
	}

	public void HandlePageChange(int newPageNumber)
	{
		LoadPage(newPageNumber);
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
				LoadPage(1);
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
				LoadPage(1);
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
	private void ShowSection(int section)//tab標籤使用的
	{
		currentSection = section;
	}

	private string GetTabClass(int section)
	{
		return section == currentSection ? "active" : "";
	}

	string kkk = "";
	private NewAccount[] m_NewAccountS;
	private AccountRepair[] m_AccountRepairS { get; set; }
	public void OnClickSelect(string bankcode)
	{
		try
		{
			// 判斷資料庫是否有變動
			if (DataVersionService.DataVersion != 1)
			{
				m_AccountRepairS = Array.Empty<AccountRepair>();
				AccountRepair[] updatedData = UpdateAccountRepairALL();
				m_AccountRepairS = updatedData.Where(item => item.baccountBank == bankcode.Substring(3)).ToArray();
				LoadPage(1);
			}
			else
			{
				//UpdateNewData();
				if (m_AccountRepairS == null)
				{
					m_AccountRepairS = ServerData.m_AccountRepairS.Where(item => item.baccountBank == bankcode.Substring(3)).ToArray();
					LoadPage(1);
				}
				else
				{
					m_AccountRepairS = Array.Empty<AccountRepair>();
					m_AccountRepairS = ServerData.m_AccountRepairS.Where(item => item.baccountBank == bankcode.Substring(3)).ToArray();
					LoadPage(1);
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
