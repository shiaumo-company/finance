#pragma checksum "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ea34cde1fad2dab59a7227599711f94f6b3c8118b75ce498b3811fcbeb42d908"
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
#line 1 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using DBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\_Imports.razor"
using DBS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
using DBS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
using DBS.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/InsertAccount")]
    public partial class InsertAccount : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-mg2z16bkj2>新增帳戶  &nbsp; &nbsp;InsertAccount</h3>\r\n\r\n");
            __builder.OpenElement(1, "head");
            __builder.AddAttribute(2, "b-mg2z16bkj2");
            __builder.AddMarkupContent(3, @"<link href=""styles/site.css"" rel=""stylesheet"" b-mg2z16bkj2>
	<link rel=""stylesheet"" href=""https://lf3-cdn-tos.bytecdntp.com/cdn/expire-1-M/font-awesome/4.7.0/css/font-awesome.min.css"" b-mg2z16bkj2>
	<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/open-iconic/1.1.1/font/css/open-iconic-bootstrap.min.css"" integrity=""sha512-XNkCjx/a0lED2ktq3KaBz1v62cxVvLU9y+gZLnhyl4+btRhe+uxLw6J/9M+k2JvZFsX5v9FxVjH4D2u5JUdw=="" b-mg2z16bkj2>
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"" b-mg2z16bkj2>
	");
            __builder.OpenElement(4, "script");
            __builder.AddAttribute(5, "src", "https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js");
            __builder.AddAttribute(6, "integrity", "sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8");
            __builder.AddAttribute(7, "crossorigin", "anonymous");
            __builder.AddAttribute(8, "b-mg2z16bkj2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "table");
                __builder2.AddAttribute(13, "class", "table");
                __builder2.AddAttribute(14, "style", "text-align:right");
                __builder2.AddAttribute(15, "b-mg2z16bkj2");
                __builder2.OpenElement(16, "tbody");
                __builder2.AddAttribute(17, "b-mg2z16bkj2");
                __builder2.OpenElement(18, "tr");
                __builder2.AddAttribute(19, "onmouseover", "this.style.backgroundColor=\'rgba(184,193,236,0.6)\';this.style.color=\'#350E51\';");
                __builder2.AddAttribute(20, "onmouseout", "this.style.backgroundColor=\'#FFFFFE\';");
                __builder2.AddAttribute(21, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(22, "<td class=\"form-field\" style=\"height:100px; \" b-mg2z16bkj2>銀行<br b-mg2z16bkj2>bank</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(23, "td");
                __builder2.AddAttribute(24, "class", "form-right");
                __builder2.AddAttribute(25, "b-mg2z16bkj2");
                __builder2.OpenElement(26, "select");
                __builder2.AddAttribute(27, "style", "height: 50px;width :255px;");
                __builder2.AddAttribute(28, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                            BankChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "b-mg2z16bkj2");
                __builder2.OpenElement(30, "option");
                __builder2.AddAttribute(31, "value");
                __builder2.AddAttribute(32, "disabled");
                __builder2.AddAttribute(33, "selected");
                __builder2.AddAttribute(34, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(35, "請選擇銀行");
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
       foreach (var banks in BankData.GetBankList())
						{
							string methodName = $"GetBranchList_{banks.BankCode.ToString().Substring(0, 3)}";
							var methodInfo = typeof(BankData).GetMethod(methodName);
							if (methodInfo != null && methodInfo.IsStatic)
							{
								var bankList = (List<BranchInfo>)methodInfo.Invoke(null, null);
								int bankCount = bankList.Count; // 直接使用获取的分行列表的 Count 属性

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "option");
                __builder2.AddAttribute(37, "value", 
#nullable restore
#line 38 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                       banks.BankCode

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(38, "b-mg2z16bkj2");
#nullable restore
#line (38,41)-(38,55) 26 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
__builder2.AddContent(39, banks.BankName);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, " (");
#nullable restore
#line (38,58)-(38,67) 26 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
__builder2.AddContent(41, bankCount);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(42, ")");
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
							}
						}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(44, "select");
                __builder2.AddAttribute(45, "style", "height: 50px;width :175px;");
                __builder2.AddAttribute(46, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                            CityChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "b-mg2z16bkj2");
                __builder2.OpenElement(48, "option");
                __builder2.AddAttribute(49, "value");
                __builder2.AddAttribute(50, "disabled");
                __builder2.AddAttribute(51, "selected");
                __builder2.AddAttribute(52, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(53, "請選擇地區");
                __builder2.CloseElement();
#nullable restore
#line 45 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
       foreach (var citys in BankData.GetCityList())
						{
							string methodName = $"GetBranchList_{bankCode}";
							var methodInfo = typeof(BankData).GetMethod(methodName);
							if (methodInfo != null && methodInfo.IsStatic)
							{
								var bankList = (List<BranchInfo>)methodInfo.Invoke(null, null);
								var filterbanklist = bankList.Where(item => item.BranchCity == citys.CityCode);
								int bankCount = filterbanklist.Count();

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value", 
#nullable restore
#line 54 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                       citys.CityCode

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(56, "style", 
#nullable restore
#line 54 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                              GetItemStyle(citys)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(57, "b-mg2z16bkj2");
#nullable restore
#line (54,69)-(54,83) 26 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
__builder2.AddContent(58, citys.CityName);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, " (");
#nullable restore
#line (54,86)-(54,95) 26 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
__builder2.AddContent(60, bankCount);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, ")");
                __builder2.CloseElement();
#nullable restore
#line 55 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
							}
						}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(63, "select");
                __builder2.AddAttribute(64, "style", "height: 50px;width :300px;");
                __builder2.AddAttribute(65, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                            BranchChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "b-mg2z16bkj2");
                __builder2.OpenElement(67, "option");
                __builder2.AddAttribute(68, "value");
                __builder2.AddAttribute(69, "disabled");
                __builder2.AddAttribute(70, "selected");
                __builder2.AddAttribute(71, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(72, "請選擇分行");
                __builder2.CloseElement();
#nullable restore
#line 61 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
       if (selectedBranchList != null)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
        foreach (var banks in selectedBranchList.Where(item => item.BranchCity == @city))
							{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(73, "option");
                __builder2.AddAttribute(74, "value", 
#nullable restore
#line 65 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                       banks.BranchCode

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(75, "b-mg2z16bkj2");
#nullable restore
#line (65,43)-(65,59) 26 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
__builder2.AddContent(76, banks.BranchName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 66 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
        
						}

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(77, "option");
                __builder2.AddAttribute(78, "value", "additionalValue");
                __builder2.AddAttribute(79, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(80, "請選擇分行");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(82, "script");
                __builder2.AddAttribute(83, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(84, "\r\n\t\t\t\t\t\tfunction resetBranchDropdown() \r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\tvar branchDropdown = document.getElementById(\'branchDropdown\');\r\n\t\t\t\t\t\t\tbranchDropdown.selectedIndex = 0; // 設置為第一個選項，即\"請選擇分行\"\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\t\t\t\t");
                __builder2.OpenElement(86, "tr");
                __builder2.AddAttribute(87, "onmouseover", "this.style.backgroundColor=\'rgba(184,193,236,0.6)\';this.style.color=\'#350E51\';");
                __builder2.AddAttribute(88, "onmouseout", "this.style.backgroundColor=\'#FFFFFE\';");
                __builder2.AddAttribute(89, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(90, "<td class=\"form-field\" style=\"height:50px;\" b-mg2z16bkj2>開戶帳號<br b-mg2z16bkj2>account</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(91, "td");
                __builder2.AddAttribute(92, "class", "form-right");
                __builder2.AddAttribute(93, "b-mg2z16bkj2");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "class", "form-account");
                __builder2.AddAttribute(96, "style", "height:50px; width:150px;");
                __builder2.AddAttribute(97, "readonly");
                __builder2.AddAttribute(98, "value", (
#nullable restore
#line 83 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                                                     bankCode

#line default
#line hidden
#nullable disable
                ) + " " + (
#nullable restore
#line 83 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                                                               branchCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "id", "InitialCode");
                __builder2.AddAttribute(100, "asp-for", "InitialCode");
                __builder2.AddAttribute(101, "b-mg2z16bkj2");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\t\t\t\t\t\t<br b-mg2z16bkj2><br b-mg2z16bkj2>\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(103, "input");
                __builder2.AddAttribute(104, "class", "form-account");
                __builder2.AddAttribute(105, "style", "height:50px; width:500px;");
                __builder2.AddAttribute(106, "id", "InitialAccount");
                __builder2.AddAttribute(107, "type", "number");
                __builder2.AddAttribute(108, "asp-for", "InitialAccount");
                __builder2.AddAttribute(109, "placeholder", "開戶帳號");
                __builder2.AddAttribute(110, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                                                                                                       InitialAccount

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(111, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InitialAccount = __value, InitialAccount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(112, "b-mg2z16bkj2");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\t\t\t\t");
                __builder2.OpenElement(114, "tr");
                __builder2.AddAttribute(115, "onmouseover", "this.style.backgroundColor=\'rgba(184,193,236,0.6)\';this.style.color=\'#350E51\';");
                __builder2.AddAttribute(116, "onmouseout", "this.style.backgroundColor=\'#FFFFFE\';");
                __builder2.AddAttribute(117, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(118, "<td class=\"form-field\" style=\"height:50px; \" b-mg2z16bkj2>銀行地址<br b-mg2z16bkj2>address</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(119, "td");
                __builder2.AddAttribute(120, "class", "form-right");
                __builder2.AddAttribute(121, "b-mg2z16bkj2");
                __builder2.OpenElement(122, "input");
                __builder2.AddAttribute(123, "class", "form-address");
                __builder2.AddAttribute(124, "style", "height:50px; width:500px;");
                __builder2.AddAttribute(125, "id", "BankAddress");
                __builder2.AddAttribute(126, "type", "text");
                __builder2.AddAttribute(127, "asp-for", "BankAddress");
                __builder2.AddAttribute(128, "placeholder", "銀行地址");
                __builder2.AddAttribute(129, "readonly");
                __builder2.AddAttribute(130, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                                                                                              BankAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BankAddress = __value, BankAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(132, "b-mg2z16bkj2");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n\t\t\t\t");
                __builder2.OpenElement(134, "tr");
                __builder2.AddAttribute(135, "onmouseover", "this.style.backgroundColor=\'rgba(184,193,236,0.6)\';this.style.color=\'#350E51\';");
                __builder2.AddAttribute(136, "onmouseout", "this.style.backgroundColor=\'#FFFFFE\';");
                __builder2.AddAttribute(137, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(138, "<td class=\"form-field\" style=\"height:50px;\" b-mg2z16bkj2>銀行網頁<br b-mg2z16bkj2>web</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(139, "td");
                __builder2.AddAttribute(140, "class", "form-right");
                __builder2.AddAttribute(141, "style", "height:50px; width:175px;");
                __builder2.AddAttribute(142, "b-mg2z16bkj2");
                __builder2.OpenElement(143, "a");
                __builder2.AddAttribute(144, "href", 
#nullable restore
#line 97 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                selectedBankWeb

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(145, "target", "_blank");
                __builder2.AddAttribute(146, "b-mg2z16bkj2");
#nullable restore
#line (97,51)-(97,55) 27 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
__builder2.AddContent(147, bank);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n\t\t\t\t");
                __builder2.OpenElement(149, "tr");
                __builder2.AddAttribute(150, "onmouseover", "this.style.backgroundColor=\'rgba(184,193,236,0.6)\';this.style.color=\'#350E51\';");
                __builder2.AddAttribute(151, "onmouseout", "this.style.backgroundColor=\'#FFFFFE\';");
                __builder2.AddAttribute(152, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(153, "<td class=\"form-field\" style=\"height:50px; \" b-mg2z16bkj2>備註<br b-mg2z16bkj2>remark</td>\r\n\t\t\t\t\t");
                __builder2.OpenElement(154, "td");
                __builder2.AddAttribute(155, "class", "form-right");
                __builder2.AddAttribute(156, "b-mg2z16bkj2");
                __builder2.OpenElement(157, "input");
                __builder2.AddAttribute(158, "style", "height:50px; width:500px;");
                __builder2.AddAttribute(159, "id", "remark");
                __builder2.AddAttribute(160, "type", "text");
                __builder2.AddAttribute(161, "asp-for", "remark");
                __builder2.AddAttribute(162, "placeholder", "備註");
                __builder2.AddAttribute(163, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 103 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                                                                               remark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => remark = __value, remark));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(165, "b-mg2z16bkj2");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n\t\t\t");
                __builder2.OpenElement(167, "tfoot");
                __builder2.AddAttribute(168, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(169, "<td b-mg2z16bkj2></td>\r\n\t\t\t\t");
                __builder2.OpenElement(170, "td");
                __builder2.AddAttribute(171, "class", "form-save");
                __builder2.AddAttribute(172, "b-mg2z16bkj2");
                __builder2.OpenElement(173, "button");
                __builder2.AddAttribute(174, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
                                            OnClickSave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(175, "class", "btn_save");
                __builder2.AddAttribute(176, "b-mg2z16bkj2");
                __builder2.AddMarkupContent(177, "<i class=\"fas fa-download\" b-mg2z16bkj2></i> &nbsp; &nbsp;儲存");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\013590\source\repos\DBS\DBS_240220_2_1\DBS\DBS\Pages\InsertAccount.razor"
       
	string kkkk = "";
	bool isEdit = false;
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

		m_AccountRepairS = Array.Empty<AccountRepair>();
		AccountRepair[] updatedData = UpdateAccountRepairALL();
		m_AccountRepairS = updatedData.ToArray();
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
