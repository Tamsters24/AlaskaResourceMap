#pragma checksum "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\LeafletMap.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "add3879623c6a56205e663c24ac5ae82f3f86afd4e2ae9d7c1ebc82ce6d6d4b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLeaflet
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
#nullable restore
#line 1 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\_Imports.razor"
using BlazorLeaflet.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\_Imports.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\_Imports.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\LeafletMap.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\LeafletMap.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class LeafletMap : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 5 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\LeafletMap.razor"
          Map.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", "width: 100%; height: 100%;");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\coppe\Desktop\AlaskaDNR\AlaskaResourceData\BlazorLeaflet\BlazorLeaflet\LeafletMap.razor"
       
    [Parameter] public Map Map { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await LeafletInterops.Create(JsRuntime, Map);
            Map.RaiseOnInitialized();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
