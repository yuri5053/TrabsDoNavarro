#pragma checksum "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af140b9f9f4ba3c8d03fde1d9963c80a2b93fc37"
// <auto-generated/>
#pragma warning disable 1591
namespace Tecnologia_Razor.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Tecnologia_Razor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Tecnologia_Razor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Bar>(0);
            __builder.AddAttribute(1, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.BarMode>(
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
        BarMode.VerticalInline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "CollapseMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.BarCollapseMode>(
#nullable restore
#line 3 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
                BarCollapseMode.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 4 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
              Breakpoint.Desktop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "NavigationBreakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 5 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
                        Breakpoint.Tablet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 6 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
                 ThemeContrast.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\n  ");
                __builder2.OpenComponent<Blazorise.BarBrand>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\n    ");
                    __builder3.OpenComponent<Blazorise.BarItem>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\n      ");
                        __builder4.OpenComponent<Blazorise.BarLink>(14);
                        __builder4.AddAttribute(15, "To", "");
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "\n        ");
                            __builder5.OpenComponent<Blazorise.BarIcon>(18);
                            __builder5.AddAttribute(19, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
                           IconName.Laptop

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(20, "\n        Home\n      ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n  ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n  ");
                __builder2.OpenComponent<Blazorise.BarMenu>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n    ");
                    __builder3.OpenComponent<Blazorise.BarStart>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "\n      ");
                        __builder4.OpenComponent<Blazorise.BarItem>(30);
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(32, "\n        ");
                            __builder5.OpenComponent<Blazorise.BarLink>(33);
                            __builder5.AddAttribute(34, "To", "ToDo");
                            __builder5.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(36, "\n          ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(37);
                                __builder6.AddAttribute(38, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\Yuri\Desktop\coisasdorego\Blazor-Entrega-1-master\client\Shared\NavMenu.razor"
                             IconName.Home

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(39, "\n          ToDo\n        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(40, "\n      ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n  ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
