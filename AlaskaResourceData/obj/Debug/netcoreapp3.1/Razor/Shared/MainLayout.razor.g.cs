#pragma checksum "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fbdfb2251c0e37fb86a023eaa2b1785ba37ed455a0fe3be36dad837ecb5b8de0"
// <auto-generated/>
#pragma warning disable 1591
namespace AlaskaResourceData.Shared
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
    public partial class MainLayout : Microsoft.AspNetCore.Components.LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<global::AlaskaResourceData.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\n        <a href=\"https://docs.microsoft.com/en-us/aspnet/\" target=\"_blank\">About</a>\n    </div>\n\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\n        ");
#nullable restore
#line 13 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591