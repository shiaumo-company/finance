#pragma checksum "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e8fb081c3aea4f9563d29018307435f55827c4d1092a0971c69e252faedb757c"
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
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/DailyBankSelect/{subBank}")]
    public partial class DailyBankSelect : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DailyBankSelect</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<head><link href=\"styles/site.css\" rel=\"stylesheet\"></head>\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "h2");
#nullable restore
#line 19 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(5, subBank.Substring(3));

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(6, " 查詢資料");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n\t\t");
                __builder2.OpenElement(8, "table");
                __builder2.AddAttribute(9, "class", "table");
                __builder2.AddAttribute(10, "style", "text-align:right; margin-top:20px;");
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "id", "Select_btn");
                __builder2.AddAttribute(13, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
                                       OnClickSelect

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(14, "查詢");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n\t\t\t\t\t");
                __builder2.AddMarkupContent(16, "<td>開始日期</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "style", "height: 30px;width :175px;");
                __builder2.AddAttribute(19, "type", "date");
                __builder2.AddAttribute(20, "value", "");
                __builder2.AddAttribute(21, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
                                                                               BeginDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\t\t\t\t\t");
                __builder2.AddMarkupContent(23, "<td>結束日期</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "style", "height: 30px;width :175px;");
                __builder2.AddAttribute(26, "type", "date");
                __builder2.AddAttribute(27, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
                                                                      EndDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\t\t");
                __builder2.OpenElement(29, "table");
                __builder2.AddAttribute(30, "class", "table");
                __builder2.AddAttribute(31, "style", "text-align:right; margin-top:20px;");
                __builder2.AddMarkupContent(32, "<thead><tr><th style=\"text-align:center\">交易日期</th>\r\n\t\t\t\t<th>銀行名稱</th>\r\n\t\t\t\t<th>銀行帳號帳號</th>\r\n\t\t\t\t<th>方式</th>\r\n\t\t\t\t<th>收入</th>\r\n\t\t\t\t<th>支出</th>\r\n\t\t\t\t<th>結存餘額</th>\r\n\t\t\t\t<th>對方行帳號</th>\r\n\t\t\t\t<th>備註</th></tr></thead>\r\n\t\t");
                __builder2.OpenElement(33, "tbody");
#nullable restore
#line 42 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
     if (m_NewAccountS != null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
      foreach (var (account, i) in m_NewAccountS.Select((account, i) => (account, i)))
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(34, "tr");
                __builder2.OpenElement(35, "td");
                __builder2.AddAttribute(36, "style", "text-align:center");
#nullable restore
#line 47 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(37, account.baccountDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(39, "td");
#nullable restore
#line 48 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(40, account.baccountBankNo);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, " ");
#nullable restore
#line 48 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(42, account.baccountBank);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(43, "<br>");
#nullable restore
#line 49 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
         foreach (var repair in ServerData.m_AccountRepairS.Where(r => r.baccountNo == account.baccountNo))
								{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(44, "span");
#nullable restore
#line 51 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(45, repair.baccountBranchNo);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(46, " ");
#nullable restore
#line 51 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(47, repair.baccountBranch);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\t\t\t\t\t\t\t\t\t\t<br>");
#nullable restore
#line 53 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
								}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(50, "td");
#nullable restore
#line 55 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(51, account.baccountNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(53, "td");
#nullable restore
#line 56 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(54, account.baccountType);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(56, "td");
#nullable restore
#line 57 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(57, account.baccountIn);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(59, "td");
#nullable restore
#line 58 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(60, account.baccountOut);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(62, "td");
#nullable restore
#line 59 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(63, account.baccountTotal);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(65, "td");
#nullable restore
#line 60 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(66, account.baccountOtherNo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\t\t\t\t\t\t\t\t");
                __builder2.OpenElement(68, "td");
#nullable restore
#line 61 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
__builder2.AddContent(69, account.bremark);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 63 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
      
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
#line 71 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\DailyBankSelect.razor"
       
	private NewAccount[] m_NewAccountS;
	private AccountRepair[] m_AccountRepairS;
	[Parameter]
	public string subBank { get; set; }

	string kkk = "";

	DateTime accountInsert;
	string money;
	public void MoneyChange(ChangeEventArgs e)
	{
		money = e.Value.ToString();
	}

	string bank, bankName, bankCode;
	public void BankChange(ChangeEventArgs e)
	{
		bank = e.Value.ToString();
		bankName = e.Value.ToString().Substring(3);
		bankCode = e.Value.ToString().Substring(0, 3);
	}
	string bank2, bankName2, bankCode2;
	public void BankChangeOther(ChangeEventArgs e)
	{
		bank2 = e.Value.ToString();
		bankName2 = e.Value.ToString().Substring(3);
		bankCode2 = e.Value.ToString().Substring(0, 3);
	}
	string account;
	string previousAccount;// 新增變數用來存儲上一次的 account
	public void AccountChange(ChangeEventArgs e)
	{
		account = e.Value?.ToString();
	}
	DateTime beginDate;
	public void BeginDateChange(ChangeEventArgs e)
	{
		beginDate = Convert.ToDateTime(e.Value);
	}
	DateTime endDate;
	public void EndDateChange(ChangeEventArgs e)
	{
		endDate = Convert.ToDateTime(e.Value);
	}
	DateTime editDate;
	public void EditDateChange(ChangeEventArgs e)
	{
		editDate = Convert.ToDateTime(e.Value);
	}


	public void OnClickSelect(MouseEventArgs e)
	{
		bool bError = false;

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
			m_NewAccountS = null;
			return;
		}
		try
		{
			// 判斷資料庫是否有變動
			if (DataVersionService.DataVersion != 1)
			{
				m_NewAccountS = Array.Empty<NewAccount>();
				UpdateNewDataPart();
			}
			else
			{
				if (m_NewAccountS == null)
				{
					m_NewAccountS = ServerData.m_NewAccountS.Where(item => item.baccountBankNo == subBank.Substring(0,3)  && item.baccountDate >= beginDate && item.baccountDate <= endDate)
					.GroupBy(item => item.baccountNo) // 按帳號分組
					.Select(group => group.OrderBy(item => item.baccountBank)
										.ThenBy(item => item.baccountNo)
										.ThenBy(item => item.baccountDate)
										.ThenBy(item => item.baccountInsert))
					.SelectMany(sortedGroup => sortedGroup).ToArray();
				}
				else
				{
					//m_NewAccountS = Array.Empty<NewAccount>();
					m_NewAccountS = ServerData.m_NewAccountS.ToArray();
					m_NewAccountS = ServerData.m_NewAccountS.Where(item => item.baccountBankNo == subBank.Substring(0,3)  && item.baccountDate >= beginDate && item.baccountDate <= endDate)
					.GroupBy(item => item.baccountNo) // 按帳號分組
					.Select(group => group.OrderBy(item => item.baccountBank)
											.ThenBy(item => item.baccountNo)
											.ThenBy(item => item.baccountDate)
											.ThenBy(item => item.baccountInsert))
					.SelectMany(sortedGroup => sortedGroup).ToArray();
				}
			}
		}
		catch (Exception msg)
		{
			kkk = msg.Message;
		}
		AlertService.Success($"總共查詢到{m_NewAccountS.Count()}筆資料");
		if (m_NewAccountS == null)
		{
			AlertService.Warn("尚無資料");
		}
	}
	public void UpdateNewDataPart()
	{
		// 將 NewAccount[] 陣列轉換為 List<NewAccount>
		List<NewAccount> newList = m_NewAccountS.ToList();
		// 新資料列表
		List<NewAccount> newDataList = GetNewData();
		// 使用 LINQ 的 Except 方法排除已經存在的資料
		newDataList = newDataList.Except(newList).ToList();
		// 使用 AddRange 將新資料列表添加到現有的列表中
		newList.AddRange(newDataList);
		// 將結果轉換回陣列
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_NewAccountS = newList.Where(item => item.baccountBankNo == subBank.Substring(0,3) && item.baccountDate >= beginDate && item.baccountDate <= endDate)
		.GroupBy(item => item.baccountNo) // 按帳號分組
		.Select(group => group.OrderBy(item => item.baccountBank)
							.ThenBy(item => item.baccountNo)
							.ThenBy(item => item.baccountDate)
							.ThenBy(item => item.baccountInsert))
		.SelectMany(sortedGroup => sortedGroup).ToArray();


	}

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

	public AccountRepair[] UpdateAccountRepairALL()
	//專門給選擇銀行後跳出對應帳戶用的更新資料(有時候可能會先使用銀行維護去新增資料，這時候就要用他嚕)
	{
		// 將 NewAccount[] 陣列轉換為 List<NewAccount>
		List<AccountRepair> newList = ServerData.m_AccountRepairS.ToList();
		// 新資料列表
		List<AccountRepair> newDataList = GetAccountRepair();
		// 使用 LINQ 的 Except 方法排除已經存在的資料
		newDataList = newDataList.Except(newList).ToList();
		// 使用 AddRange 將新資料列表添加到現有的列表中
		newList.AddRange(newDataList);
		// 將結果轉換回陣列
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_AccountRepairS = newList.ToArray();
		return m_AccountRepairS;
	}

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
