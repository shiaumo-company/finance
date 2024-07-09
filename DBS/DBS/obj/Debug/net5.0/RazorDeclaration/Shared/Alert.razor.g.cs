// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\Alert.razor"
using DBS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\Alert.razor"
using DBS.Models;

#line default
#line hidden
#nullable disable
    public partial class Alert : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\013590\source\repos\DBS\DBS\DBS\Shared\Alert.razor"
        [Parameter]
    public string Id { get; set; } = "default-alert";

    [Parameter]
    public bool Fade { get; set; } = true;

    private List<Models.Alert> alerts = new List<Models.Alert>();

    protected override void OnInitialized()
    {
        // subscribe to new alerts and location change events
        AlertService.OnAlert += OnAlert;
        NavigationManager.LocationChanged += OnLocationChange;
    }

    public void Dispose()
    {
        // unsubscribe from alerts and location change events
        AlertService.OnAlert -= OnAlert;
        NavigationManager.LocationChanged -= OnLocationChange;
    }

    private async void OnAlert(Models.Alert alert)
    {
        // ignore alerts sent to other alert components
        if (alert.Id != Id)
            return;

        // clear alerts when an empty alert is received
        if (alert.Message == null)
        {
            // remove alerts without the 'KeepAfterRouteChange' flag set to true
            alerts.RemoveAll(x => !x.KeepAfterRouteChange);

            // set the 'KeepAfterRouteChange' flag to false for the
            // remaining alerts so they are removed on the next clear
            alerts.ForEach(x => x.KeepAfterRouteChange = false);
        }
        else
        {
            // add alert to array
            alerts.Add(alert);
            StateHasChanged();

            // auto close alert if required
            if (alert.AutoClose)
            {
                await Task.Delay(3000);
                RemoveAlert(alert);
            }
        }

        StateHasChanged();
    }

    private void OnLocationChange(object sender, LocationChangedEventArgs e)
    {
        AlertService.Clear(Id);
    }

    private async void RemoveAlert(Models.Alert alert)
    {
        // check if already removed to prevent error on auto close
        if (!alerts.Contains(alert)) return;

        if (Fade)
        {
            // fade out alert
            alert.Fade = true;

            // remove alert after faded out
            await Task.Delay(250);
            alerts.Remove(alert);
        }
        else
        {
            // remove alert
            alerts.Remove(alert);
        }

        StateHasChanged();
    }

    private string CssClass(Models.Alert alert)
    {
        if (alert == null) return null;

        var classes = new List<string> { "alert", "alert-dismissable", "mt-4", "container" };

        var alertTypeClass = new Dictionary<AlertType, string>();
        alertTypeClass[AlertType.Success] = "alert-success";
        alertTypeClass[AlertType.Error] = "alert-danger";
        alertTypeClass[AlertType.Info] = "alert-info";
        alertTypeClass[AlertType.Warning] = "alert-warning";

        classes.Add(alertTypeClass[alert.Type]);

        if (alert.Fade)
            classes.Add("fade");

        return string.Join(' ', classes);
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591
