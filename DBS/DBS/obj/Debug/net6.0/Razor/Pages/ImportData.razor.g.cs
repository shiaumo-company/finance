#pragma checksum "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a566f45414af4b7e2fcd3e7f77363dd05e3003fdbdaf0086c548638ed1ccf646"
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
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/importdata")]
    public partial class ImportData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>importdata</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h2 style=\"margin-bottom:15px\">新增收入.支出</h2>\r\n\t\t ");
                __builder2.AddMarkupContent(4, "<tr><td>ID</td>\r\n\t\t\t <td><input id=\"userid\" type=\"text\" asp-for=\"userid\"></td></tr>\r\n\t\t ");
                __builder2.AddMarkupContent(5, "<tr><td></td>\r\n\t\t\t <td></td></tr>\t\t ");
                __builder2.AddMarkupContent(6, "<tr><td></td>\r\n\t\t\t <td></td></tr>\r\n\t\t ");
                __builder2.OpenElement(7, "button");
                __builder2.AddAttribute(8, "id", "Add_btn");
                __builder2.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                                   OnClickAdd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(10, "新增");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\t\t ");
                __builder2.OpenElement(12, "button");
                __builder2.AddAttribute(13, "id", "Del_btn");
                __builder2.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                                  OnClickDel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(15, "刪除");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\t\t ");
                __builder2.OpenElement(17, "button");
                __builder2.AddAttribute(18, "id", "Update_btn");
                __builder2.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                                     OnClickUpdate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(20, "修改");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\t\t ");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "id", "Select_btn");
                __builder2.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                                     OnClickSelect

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(25, "查詢");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\t\t ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                     CheckDatabaseConnection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(29, "測試連接");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\t\t ");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                     CheckSQLConnection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(33, "測試資料表");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\t\t ");
                __builder2.OpenElement(35, "p");
#nullable restore
#line (37,8)-(37,21) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
__builder2.AddContent(36, resultMessage);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\t\t ");
                __builder2.OpenElement(38, "p");
#nullable restore
#line (38,8)-(38,26) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
__builder2.AddContent(39, resultuserpassword);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n\t\t ");
                __builder2.OpenElement(41, "select");
                __builder2.AddAttribute(42, "style", "height: 30px;");
                __builder2.AddAttribute(43, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                                            BankChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(44, "option");
                __builder2.AddAttribute(45, "value");
                __builder2.AddAttribute(46, "disabled");
                __builder2.AddAttribute(47, "selected");
                __builder2.AddMarkupContent(48, "請選擇銀行");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\t\t\t");
                __builder2.OpenElement(50, "option");
                __builder2.AddAttribute(51, "value", "bank_001");
                __builder2.AddMarkupContent(52, "中央信託");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\t\t\t");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value", "bank_002");
                __builder2.AddMarkupContent(56, "農民銀行");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\t\t\t");
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", "DBS");
                __builder2.AddContent(60, "DBS");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\t\t ");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "style", "height: 30px");
                __builder2.AddAttribute(64, ";");
                __builder2.AddAttribute(65, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                                            AccountChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(66, "option");
                __builder2.AddAttribute(67, "value");
                __builder2.AddAttribute(68, "disabled");
                __builder2.AddAttribute(69, "selected");
                __builder2.AddMarkupContent(70, "請選擇帳號");
                __builder2.CloseElement();
#nullable restore
#line 48 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
     foreach (var user in ServerData.m_AccountRepairS)
			{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value", 
#nullable restore
#line 50 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
                   user.baccountBank

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (50,39)-(50,56) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
__builder2.AddContent(73, user.baccountBank);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 51 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
			}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\t\t ");
                __builder2.OpenElement(75, "table");
                __builder2.AddAttribute(76, "class", "table");
                __builder2.AddAttribute(77, "style", "text-align:right");
                __builder2.AddMarkupContent(78, "<thead><tr><th style=\"text-align:center\">交易日期</th>\r\n\t\t\t\t\t<th>我的帳號</th>\r\n\t\t\t\t\t<th>收入</th>\r\n\t\t\t\t\t<th>支出</th>\r\n\t\t\t\t\t<th>結存餘額</th>\r\n\t\t\t\t\t<th>對方行帳號</th>\r\n\t\t\t\t\t<th>備註</th></tr></thead>\r\n\t\t\t");
                __builder2.OpenElement(79, "tbody");
#nullable restore
#line 66 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
     if (dataset != null && dataset.Tables["User_Password"] != null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
      foreach (DataRow row in dataset.Tables["User_Password"].Rows)
					{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(80, "tr");
                __builder2.OpenElement(81, "td");
#nullable restore
#line (71,13)-(71,22) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
__builder2.AddContent(82, row["ID"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(84, "td");
#nullable restore
#line (72,13)-(72,28) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
__builder2.AddContent(85, row["username"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(87, "td");
#nullable restore
#line (73,13)-(73,28) 26 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
__builder2.AddContent(88, row["password"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
      
				}
				else
				{
					
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
#line 87 "C:\Users\013590\source\repos\DBS\DBS_240313_2\DBS\DBS\Pages\ImportData.razor"
       
	public DataSet dataset = new DataSet();
	string bank;
	string account;
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
	string SQLString = "SELECT * FROM Platform..User_Password WHERE 1=1";
	string resultuserpassword = "no connectin userpassword";

	//確定有連到正確的資料表
	public void CheckSQLConnection()
	{
		string connectionString = "Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022";
		dataset = new DataSet();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			try
			{
				// 檢查是否已連接
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
					resultuserpassword = "Connected to userpassword!";
					// 創建 SqlCommand 對象
					using (SqlCommand command = new SqlCommand(SQLString, connection))
					{
						// 使用 ExecuteReader 执行 SQL 查询
						using (SqlDataReader reader = command.ExecuteReader())
						{
							// 判斷是否有行
							if (reader.HasRows)
							{
								resultuserpassword = " Data found in the User_Password table.";
							}
							else
							{
								resultuserpassword = " No data found in the User_Password table.";
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				resultuserpassword = ex.Message;
			}
		}
	}
	public void BankChange(ChangeEventArgs e)
	{
		bank = e.Value.ToString();
	}
	public void AccountChange(ChangeEventArgs e)
	{
		account = e.Value.ToString();
	}
	string cc = "";
	string cc_up = "";

	public void OnClickAdd(MouseEventArgs e)
	{
		string SQLString = "INSERT INTO dbo.User_Password ([ID],[username],[password]) VALUES  (  )";
		SqlConnection sqlconnection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
		DataSet dataSet_up = new DataSet();
		if (sqlconnection.State == System.Data.ConnectionState.Closed)
		{
			sqlconnection.Open();
			SqlCommand sqlcommand = new SqlCommand(SQLString, sqlconnection);
			int rowsAffected = sqlcommand.ExecuteNonQuery();
			if (rowsAffected > 0)
			{
				cc_up = $"成功更新{rowsAffected}條";

			}
			else
			{
				cc_up = " 更新失敗";
			}
		}

		else
		{
			cc = "修改帳號密碼不為空";
		}

	}
	public void OnClickDel(MouseEventArgs e)
	{
	}
	public void OnClickUpdate(MouseEventArgs e)
	{
	}

	public void OnClickSelect(MouseEventArgs e)
	{
		dataset = new DataSet();
		try
		{
			//where 1=1 讓動態構建SQL查詢條件，可保持易讀性，Platform資料庫，User_Passwrod資料表
			string SQLString = "Select * from Platform..User_Password where 1=1 ";
			SqlConnection sqlconnection = new SqlConnection("Data Source=192.168.10.243\\SRV_DBSAPI,1433;Initial Catalog=Platform;User ID=sa;Password=DBSsa@2022");
			using (SqlDataAdapter adapter = new SqlDataAdapter(SQLString, sqlconnection))
			{
				// 清空 DataSet
				dataset.Clear();
				//填充DataSet
				adapter.Fill(dataset, "User_Password");
			}
			if (dataset.Tables["User_Password"].Rows.Count > 2)
			{
				resultuserpassword = " Data found in the User_Password table.";
			}
			else
			{
				resultuserpassword = " No data found in the User_Password table.";
			}
		}
		catch (Exception msg)
		{
			resultuserpassword = msg.Message;
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
