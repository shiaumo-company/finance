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
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/AccountRepairData")]
    public partial class AccountRepairData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 243 "C:\Users\013590\source\repos\DBS\DBS\DBS\Pages\AccountRepairData.razor"
       
	bool isEdit = false;
	int editingIndex = -1;
	Dictionary<int, bool> editStates = new Dictionary<int, bool>();

	public class DataSharedVision
	{
		public static int dataVersion { get; set; } = 1;// 初始化一個版本號，可以是時間戳記或其他唯一識別號
	}
	public static int GetDataVersion()
	{
		return DataSharedVision.dataVersion;
	}

	// 在City2Change事件處理程序中調用JavaScript函數
	private async Task City2Change(ChangeEventArgs e)
	{
		// 调用 JavaScript 函数重置分行下拉列表
		await JSRuntime.InvokeVoidAsync("resetBranchDropdown");
	}

	string kkk = "";
	private string GetItemStyle(CityInfo city)
	{
		// 根據特定條件設置樣式
		if (city.IsLargeFont)
		{
			return " font-weight: bold; color: red; ";
		}
		else
		{
			return "font-size: 16px;";
		}
	}
	public List<BranchInfo> selectedBranchList;
	public BankInfo[] selectBankList;
	string selectBank;
	string bank, bankName, bankCode, branch, branchCode, branchCodeFull, branchName, selectedBankWeb;
	public void BankChange(ChangeEventArgs e)
	{
		bank = e.Value?.ToString();
		bankName = e.Value?.ToString().Substring(3);
		bankCode = e.Value?.ToString().Substring(0, 3);
		selectedBankWeb = GetBankWeb(bank);
		branchCode = "";
		switch (bankCode)
		{
			case "004":
				selectedBranchList = BankData.GetBranchList_004();
				break;
			case "005":
				selectedBranchList = BankData.GetBranchList_005();
				break;
			case "006":
				selectedBranchList = BankData.GetBranchList_006();
				break;
			case "007":
				selectedBranchList = BankData.GetBranchList_007();
				break;
			case "008":
				selectedBranchList = BankData.GetBranchList_008();
				break;
			case "009":
				selectedBranchList = BankData.GetBranchList_009();
				break;
			case "011":
				selectedBranchList = BankData.GetBranchList_011();
				break;
			case "012":
				selectedBranchList = BankData.GetBranchList_012();
				break;
			case "013":
				selectedBranchList = BankData.GetBranchList_013();
				break;
			case "015":
				selectedBranchList = BankData.GetBranchList_015();
				break;
			case "016":
				selectedBranchList = BankData.GetBranchList_016();
				break;
			case "017":
				selectedBranchList = BankData.GetBranchList_017();
				break;
			case "018":
				selectedBranchList = BankData.GetBranchList_018();
				break;
			case "021":
				selectedBranchList = BankData.GetBranchList_021();
				break;
			case "040":
				selectedBranchList = BankData.GetBranchList_040();
				break;
			case "048":
				selectedBranchList = BankData.GetBranchList_048();
				break;
			case "050":
				selectedBranchList = BankData.GetBranchList_050();
				break;
			case "052":
				selectedBranchList = BankData.GetBranchList_052();
				break;
			case "053":
				selectedBranchList = BankData.GetBranchList_053();
				break;
			case "054":
				selectedBranchList = BankData.GetBranchList_054();
				break;
			case "081":
				selectedBranchList = BankData.GetBranchList_081();
				break;
			case "101":
				selectedBranchList = BankData.GetBranchList_101();
				break;
			case "102":
				selectedBranchList = BankData.GetBranchList_102();
				break;
			case "103":
				selectedBranchList = BankData.GetBranchList_103();
				break;
			case "108":
				selectedBranchList = BankData.GetBranchList_108();
				break;
			case "147":
				selectedBranchList = BankData.GetBranchList_147();
				break;
			case "803":
				selectedBranchList = BankData.GetBranchList_803();
				break;
			case "805":
				selectedBranchList = BankData.GetBranchList_805();
				break;
			case "806":
				selectedBranchList = BankData.GetBranchList_806();
				break;
			case "807":
				selectedBranchList = BankData.GetBranchList_807();
				break;
			case "808":
				selectedBranchList = BankData.GetBranchList_808();
				break;
			case "809":
				selectedBranchList = BankData.GetBranchList_809();
				break;
			case "810":
				selectedBranchList = BankData.GetBranchList_810();
				break;
			case "812":
				selectedBranchList = BankData.GetBranchList_812();
				break;

			case "816":
				selectedBranchList = BankData.GetBranchList_816();
				break;
			case "822":
				selectedBranchList = BankData.GetBranchList_822();
				break;
		}
	}
	string getBank, lastBankCode, lastBranchCode;
	public void getbank(string bankCode, string branchCode)
	{

		getBank = bankCode + branchCode;
		// Update last values
		lastBankCode = bankCode;
		lastBranchCode = branchCode;
	}
	public static string GetBankWeb(string bank)
	{
		var bankInfo = BankData.GetBankList().Where(item => item.BankCode == @bank)
		.FirstOrDefault();
		return bankInfo?.BankWeb ?? "未找到網頁銀行";
	}
	public void BranchChange(ChangeEventArgs e)
	{
		branch = e.Value.ToString();
		branchName = e.Value.ToString().Substring(7);
		branchCodeFull = e.Value.ToString().Substring(0, 8);
		branchCode = e.Value.ToString().Substring(3, 4);
		// 获取相应的 BranchInfo 对象
		var selectedBranch = selectedBranchList.FirstOrDefault(item => item.BranchCode.ToString().Substring(0, 8) == @branchCodeFull);
		//// 设置 BankAddress
		BankAddress = selectedBranch != null ? selectedBranch.BranchAddress : "未知地址";
	}

	string region;
	public void RegionChange(ChangeEventArgs e)
	{
		region = e.Value.ToString();
	}

	string city;
	public void CityChange(ChangeEventArgs e)
	{
		city = e.Value.ToString();
	}
	string money;

	string BankAddress, remark, InitialMoney, InitialAccount;
	public void MoneyChange(ChangeEventArgs e)
	{
		InitialAccount = e.Value.ToString();
	}


	string datee;
	public AccountRepair[] m_AccountRepairS;//帳戶維護的列表
	public void OnClickSave(MouseEventArgs e)
	{
		datee = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		SqlConnection sqlconnection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
		DataSet dataset1 = new DataSet();
		if (string.IsNullOrEmpty(bankName))
		{
			AlertService.Error("請選擇銀行");
			return;
		}
		if (string.IsNullOrEmpty(city))
		{
			AlertService.Error("請選擇地區");
			return;
		}
		if (string.IsNullOrEmpty(branch))
		{
			AlertService.Error("請選擇分行");
			return;
		}
		if (string.IsNullOrEmpty(InitialAccount))
		{
			AlertService.Error("請填寫銀行帳號");
			return;
		}
		m_AccountRepairS = ServerData.m_AccountRepairS.ToArray();
		for (int i = 0; i < m_AccountRepairS.Length; i++)
		{
			if (m_AccountRepairS[i].baccountNo == InitialAccount)
			{
				AlertService.Error("該帳戶已存在");
				return;
			}
		}

		//Insert Into dbo.NewAccountRepair 
		string SQLString = "INSERT INTO dbo.NewAccountRepair ([accountBank],[accountBankNo],[accountBranch], [accountBranchNo], [accountNo], [accountAddress],[accountInitialMoney],[accountInsert],[accountUpdate]) VALUES (	@bankName,@bankCode,@branchName,@branchCode,@InitialAccount,@BankAddress,@InitialMoney,@accountInsert,@accountUpdate)";
		if (sqlconnection.State == System.Data.ConnectionState.Closed)
		{
			//kkk += $"銀行{bankName}銀行代號{bankCode}分行{branchName}分行代號{branchCode}帳號{InitialAccount}地址{BankAddress}";

			//@bankName,@bankCode,@branchName,@branchCode,@InitialAccount,@BankAddress
			sqlconnection.Open();
			SqlCommand sqlcommand = new SqlCommand(SQLString, sqlconnection);
			sqlcommand.Parameters.AddWithValue("@bankName", bankName);//銀行
			sqlcommand.Parameters.AddWithValue("@bankCode", bankCode);//銀行代馬
			sqlcommand.Parameters.AddWithValue("@branchName", branchName);//分行
			sqlcommand.Parameters.AddWithValue("@branchCode", branchCode);//分行代碼
			sqlcommand.Parameters.AddWithValue("@InitialAccount", InitialAccount);//帳戶
			sqlcommand.Parameters.AddWithValue("@BankAddress", BankAddress);//地址
			sqlcommand.Parameters.AddWithValue("@InitialMoney", (object)InitialMoney ?? 0);//期初金額
			sqlcommand.Parameters.AddWithValue("@accountInsert", datee);//加入時間
			sqlcommand.Parameters.AddWithValue("@accountUpdate", datee);//更新時間
			int rowsAffected = sqlcommand.ExecuteNonQuery();
			if (rowsAffected > 0)
			{
				AlertService.Success($"成功新增{rowsAffected}條");
				DataVersionService.IncrementDataVersion();
				kkk += DataVersionService.DataVersion.ToString();
				// 清空輸入字段

				InitialAccount = string.Empty;
				BankAddress = string.Empty;
				bankCode = string.Empty;
				branchCode = string.Empty;
				remark = string.Empty;
				showTable_save = false;
				showTable_select = false;
				showTable_selectall = false;
				showTable_selectpart = false;
			}
			else
			{
				AlertService.Error("更新失敗");
			}
			SqlTransaction sqlTransaction = sqlconnection.BeginTransaction();
			sqlTransaction.Commit();
		}


	}
	public bool showTable_select = false;
	public bool showTable_save = false;
	public bool showTable_selectall = false;
	public bool showTable_selectpart = false;
	public void OnClickAdd(MouseEventArgs e)
	{
		showTable_save = true;
		showTable_selectall = false;
		showTable_selectpart = false;
		showTable_select = false;
	}

	public void OnClickSelect_All(MouseEventArgs e)
	{
		showTable_select = true;
		showTable_save = false;
		showTable_selectall = true;
		showTable_selectpart = false;
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
					m_AccountRepairS = ServerData.m_AccountRepairS.ToArray();
				}
				else
				{
					m_AccountRepairS = Array.Empty<AccountRepair>();
					m_AccountRepairS = ServerData.m_AccountRepairS.ToArray();
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

	public DataSet dataset = new DataSet();
	public void UpdateNewDataALL()
	{
		// 將 NewAccount[] 陣列轉換為 List<NewAccount>
		List<AccountRepair> newList = m_AccountRepairS.ToList();
		// 新資料列表
		List<AccountRepair> newDataList = GetAccountRepair();
		// 使用 LINQ 的 Except 方法排除已經存在的資料
		newDataList = newDataList.Except(newList).ToList();
		// 使用 AddRange 將新資料列表添加到現有的列表中
		newList.AddRange(newDataList);
		// 將結果轉換回陣列
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_AccountRepairS = newList.ToArray();
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

	public DataSet dataset1 = new DataSet();
	public void OnClickDel(int index)
	{
		if (index >= 0 && index < m_AccountRepairS.Length)
		{
			// 1. 在資料庫中刪除資料
			string SQLString = "DELETE FROM dbo.NewAccountRepair WHERE [accountInsert] = @accountInsert AND [accountBankNo] = @bank AND [accountNo] =@accountNo  ";
			SqlConnection sqlconnection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
			dataset1 = new DataSet();

			if (sqlconnection.State == System.Data.ConnectionState.Closed)
			{
				sqlconnection.Open();
				SqlCommand sqlcommand = new SqlCommand(SQLString, sqlconnection);
				sqlcommand.Parameters.AddWithValue("@accountInsert", m_AccountRepairS[index].baccountInsert);
				sqlcommand.Parameters.AddWithValue("@bank", m_AccountRepairS[index].baccountBankNo);
				sqlcommand.Parameters.AddWithValue("@accountNo", m_AccountRepairS[index].baccountNo);
				try
				{
					int rowsAffected = sqlcommand.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						AlertService.Info($"成功刪除{rowsAffected}條");
						DataVersionService.IncrementDataVersion();
					}
					else
					{
						AlertService.Warn($"刪除失敗 ");
					}
				}
				catch (Exception ex)
				{
					kkk = ex.Message;
				}
				finally
				{
					sqlconnection.Close();
				}
			}
			// 2. 在本地資料結構中刪除資料
			List<AccountRepair> newDataList = m_AccountRepairS.ToList();
			//要在newDataList.RemoveAt(index)存取accountno2,bankno2,accountinsert2
			//因為這是要存取被刪除資料的帳號、銀行、加入時間
			string accountno2 = m_AccountRepairS[index].baccountNo;
			string bankno2 = m_AccountRepairS[index].baccountBankNo;
			DateTime accountinsert2 = m_AccountRepairS[index].baccountInsert;
			//網頁上刪除該資料
			newDataList.RemoveAt(index);
			//m_NewAccountS變成新的(已刪除掉那筆資料ㄌ)
			m_AccountRepairS = newDataList.ToArray();
			//3.更新資料庫的總額
		}
	}
	public void OnClickSelect(MouseEventArgs e)
	{
		showTable_select = true;
		showTable_selectall = false;
		showTable_save = false;
		showTable_selectpart = true;
		bool bError = false;
		if (string.IsNullOrWhiteSpace(bank))
		{
			bError = true;
			AlertService.Error("請選擇銀行");
		}

		if (bError)
		{
			m_AccountRepairS = null;
			return;
		}
		try
		{
			// 判斷資料庫是否有變動
			if (DataVersionService.DataVersion != 1)
			{
				m_AccountRepairS = Array.Empty<AccountRepair>();
				AccountRepair[] updatedData = UpdateAccountRepairALL();
				m_AccountRepairS = updatedData.Where(item => item.baccountBankNo == bankCode)
																.GroupBy(item => new { item.baccountBank, item.baccountNo })
																.SelectMany(group => group.OrderBy(item => item.baccountInsert))
																.ToArray();
				//m_AccountRepairS.ToArray();
				kkk += "hello";
				showTable_selectpart = false;

			}
			else
			{
				if (m_AccountRepairS == null)
				{
					m_AccountRepairS = ServerData.m_AccountRepairS.Where(item => item.baccountBankNo == bankCode)
																.GroupBy(item => new { item.baccountBank, item.baccountNo })
																.SelectMany(group => group.OrderBy(item => item.baccountInsert))
																.ToArray();
					kkk += "nono";
				}
				else
				{
					m_AccountRepairS = Array.Empty<AccountRepair>();
					//m_AccountRepairS = ServerData.m_AccountRepairS.ToArray();
					m_AccountRepairS = ServerData.m_AccountRepairS.Where(item => item.baccountBankNo == bankCode)
																.GroupBy(item => new { item.baccountBank, item.baccountNo })
																.SelectMany(group => group.OrderBy(item => item.baccountInsert))
																.ToArray();
					kkk += "peace";
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

	public void UpdateNewDataPart()
	{
		// 將 NewAccount[] 陣列轉換為 List<NewAccount>
		List<AccountRepair> newList = m_AccountRepairS.ToList();
		// 新資料列表
		List<AccountRepair> newDataList = GetAccountRepair();
		// 使用 LINQ 的 Except 方法排除已經存在的資料
		newDataList = newDataList.Except(newList).ToList();
		// 使用 AddRange 將新資料列表添加到現有的列表中
		newList.AddRange(newDataList);
		// 將結果轉換回陣列
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_AccountRepairS = newList.Where(item => item.baccountBankNo == bankCode)
		.GroupBy(item => new { item.baccountBank, item.baccountNo })
		.SelectMany(group => group)
		.ToArray();
	}

	public AccountRepair[] UpdateAccountRepairALL()
	//專門給選擇銀行後跳出對應帳戶用的更新資料(有時候可能會先使用銀行維護去新增資料，這時候就要用他嚕)
	{
		// 新資料列表
		List<AccountRepair> newDataList = GetAccountRepair();
		// 將新資料列表添加到現有的 m_NewAccountS 中
		m_AccountRepairS = newDataList.ToArray();
		kkk += "hello";
		return m_AccountRepairS;

	}
	public void OnClickCancel(MouseEventArgs e)
	{
		showTable_save = false;
		showTable_select = false;
		showTable_selectall = false;
		showTable_selectpart = false;
	}
	public void UpdateNewDataPart2()
	{
		List<AccountRepair> newList = m_AccountRepairS != null ? m_AccountRepairS.ToList() : new List<AccountRepair>();
		List<AccountRepair> newDataList = GetAccountRepair();
		newDataList = newDataList.Except(newList).ToList();
		newList.AddRange(newDataList);
		m_AccountRepairS = newList.Where(item => item.baccountBankNo == bankCode)
								.GroupBy(item => new { item.baccountBank, item.baccountNo })
								.SelectMany(group => group)
								.ToArray();
		kkk += "hello";
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
