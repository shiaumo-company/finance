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
#line 2 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailySummary.razor"
       
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
