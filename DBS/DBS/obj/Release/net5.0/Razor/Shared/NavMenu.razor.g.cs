#pragma checksum "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f839674cad0c7995a780ab451edeaf398c7cba2da2103d3b4e47afd6496f2eae"
// <auto-generated/>
#pragma warning disable 1591
namespace DBS.Shared
{
    #line hidden
    using global::System;
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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-q81ionftx5");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-q81ionftx5>DBS</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-q81ionftx5");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-q81ionftx5></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", 
#nullable restore
#line 9 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "b-q81ionftx5");
                __builder2.OpenElement(16, "ul");
                __builder2.AddAttribute(17, "class", "nav flex-column");
                __builder2.AddAttribute(18, "b-q81ionftx5");
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "nav-item px-3");
                __builder2.AddAttribute(21, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(22);
                __builder2.AddAttribute(23, "class", (object)("nav-link"));
                __builder2.AddAttribute(24, "href", (object)(""));
                __builder2.AddAttribute(25, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-q81ionftx5></span> Home\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item px-3");
                __builder2.AddAttribute(31, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(32);
                __builder2.AddAttribute(33, "class", (object)("nav-link"));
                __builder2.AddAttribute(34, "href", (object)("fetchdata"));
                __builder2.AddAttribute(35, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-q81ionftx5></span> 歷史交易\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddAttribute(40, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", (object)("nav-link"));
                __builder2.AddAttribute(43, "href", (object)("insertdata"));
                __builder2.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "<span class=\"oi oi-list-insert\" aria-hidden=\"true\" b-q81ionftx5></span> 每日報表\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.OpenElement(47, "li");
                __builder2.AddAttribute(48, "class", "nav-item px-3");
                __builder2.AddAttribute(49, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(50);
                __builder2.AddAttribute(51, "class", (object)("nav-link"));
                __builder2.AddAttribute(52, "href", (object)("selectdata"));
                __builder2.AddAttribute(53, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(54, "<span class=\"oi oi-list-select\" aria-hidden=\"true\" b-q81ionftx5></span> 查詢、匯入、修改資料\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "ul");
                __builder2.AddAttribute(57, "class", "nav flex-column isbottom");
                __builder2.AddAttribute(58, "b-q81ionftx5");
                __builder2.OpenElement(59, "li");
                __builder2.AddAttribute(60, "class", "nav-item px-3");
                __builder2.AddAttribute(61, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(62);
                __builder2.AddAttribute(63, "class", (object)("nav-link"));
                __builder2.AddAttribute(64, "href", (object)("repairdata"));
                __builder2.AddAttribute(65, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "<span class=\"oi oi-action-undo\" aria-hidden=\"true\" b-q81ionftx5></span> 補資料\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "li");
                __builder2.AddAttribute(69, "class", "nav-item px-3");
                __builder2.AddAttribute(70, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(71);
                __builder2.AddAttribute(72, "class", (object)("nav-link"));
                __builder2.AddAttribute(73, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                                                        LogOut

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(74, "href", (object)("/logoutModel?returnUrl=/"));
                __builder2.AddAttribute(75, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-q81ionftx5></span> 登出\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(77, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", 
#nullable restore
#line 47 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(80, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "b-q81ionftx5");
                __builder2.OpenElement(82, "ul");
                __builder2.AddAttribute(83, "class", "nav flex-column");
                __builder2.AddAttribute(84, "b-q81ionftx5");
                __builder2.OpenElement(85, "li");
                __builder2.AddAttribute(86, "class", "nav-item px-3");
                __builder2.AddAttribute(87, "b-q81ionftx5");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(88);
                __builder2.AddAttribute(89, "class", (object)("nav-link"));
                __builder2.AddAttribute(90, "href", (object)("Login"));
                __builder2.AddAttribute(91, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(92, "<span class=\"oi oi-account-login\" aria-hidden=\"true\" b-q81ionftx5></span> 登入\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(94);
                __builder2.AddAttribute(95, "class", (object)("nav-link"));
                __builder2.AddAttribute(96, "href", (object)("Signin"));
                __builder2.AddAttribute(97, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(98, "<span class=\"oi oi-account-signin\" aria-hidden=\"true\" b-q81ionftx5></span> 註冊\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    public async void Update() => await InvokeAsync(() => { StateHasChanged(); });
    public void LogOut(MouseEventArgs e)
    {
        Update();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
