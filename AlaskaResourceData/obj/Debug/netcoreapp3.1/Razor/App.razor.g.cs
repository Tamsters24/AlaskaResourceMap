#pragma checksum "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\App.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82fe5e98b4ed3667b50667760bc0d48bd4f0fad6411b03d4515a009f87abc3c3"
// <auto-generated/>
#pragma warning disable 1591
namespace AlaskaResourceData
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
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "DefaultLayout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 3 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(10);
                __builder2.AddAttribute(11, "Layout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 6 "C:\Users\coppe\Desktop\AlaskaDNR\BlazorLeaflet-master\BlazorLeaflet-master\BlazorLeaflet\AlaskaResourceData\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\n            ");
                    __builder3.AddMarkupContent(14, "<p>Sorry, there\'s nothing at this address.</p>\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
