// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AlaskaResourceData.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using AlaskaResourceData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using AlaskaResourceData.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using AlaskaResourceData.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\_Imports.razor"
using AlaskaResourceData.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/customcontrols")]
    public partial class CustomControls : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor"
 
    private Map _map;
    private LatLng _markerLatLng = new LatLng { Lat = 47.5574007f, Lng = 16.3918687f };

    protected override void OnInitialized()
    {
        var marker = new Marker(_markerLatLng)
        {
            Draggable = true,
            Title = "Marker 1",
            Popup = new Popup { Content = string.Format("I am at {0:0.00}° lat, {1:0.00}° lng", _markerLatLng.Lat, _markerLatLng.Lng) },
            Tooltip = new Tooltip { Content = "Click and drag to move me" }
        };

        _map = new Map(jsRuntime)
        {
            Center = _markerLatLng,
            Zoom = 4.8f,
            ZoomControl = false
        };

        _map.OnInitialized += () =>
        {
            _map.AddLayer(new TileLayer
            {
                UrlTemplate = "https://a.tile.openstreetmap.org/{z}/{x}/{y}.png",
                Attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors",
            });

            _map.AddLayer(marker);
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591