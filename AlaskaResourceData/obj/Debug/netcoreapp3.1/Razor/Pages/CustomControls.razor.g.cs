#pragma checksum "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1dae9195689f6e44e7fbb95e1dd14c5bd1df53ea315a4f683f74c06a2aa2efbd"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Blazor Leaflet</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>\n    This page demos the ability to use custom Zoom In/Out buttons instead of\n    Leaflet\'s built-in controls.\n    <br>\n    You can also hold <kbd>shift</kbd> to zoom faster.\n</p>\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "btn-group mb-2");
            __builder.AddAttribute(4, "role", "group");
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "class", "btn btn-secondary");
            __builder.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor"
                                                              (e => _map?.ZoomIn(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Zoom in");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-secondary");
            __builder.AddAttribute(15, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor"
                                                              (e => _map?.ZoomOut(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Zoom out");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "height: 500px; width: 500px;");
            __builder.AddMarkupContent(21, "\n    ");
            __builder.OpenComponent<global::BlazorLeaflet.LeafletMap>(22);
            __builder.AddAttribute(23, "Map", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::BlazorLeaflet.Map>(
#nullable restore
#line 22 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Pages\CustomControls.razor"
                     _map

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\n");
            __builder.CloseElement();
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
