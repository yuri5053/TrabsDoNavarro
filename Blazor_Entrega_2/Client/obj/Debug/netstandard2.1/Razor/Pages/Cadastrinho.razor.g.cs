#pragma checksum "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d32a13cc004bd77def15d6c15de0d66580ad165a"
// <auto-generated/>
#pragma warning disable 1591
namespace CadastroBlazor.Client.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using CadastroBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using CadastroBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
using BlazorCadastro.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cadastrinho")]
    public partial class Cadastrinho : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<center>\n<h3>Cadastro</h3>\n</center>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                 cadastro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                          Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Blazorise.Table>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\n    ");
                    __builder3.OpenElement(11, "center");
                    __builder3.AddMarkupContent(12, "\n    ");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "form-group");
                    __builder3.AddMarkupContent(15, "\n    \n    ");
                    __builder3.OpenComponent<Blazorise.TableBody>(16);
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, " \n        ");
                        __builder4.OpenComponent<Blazorise.TableRow>(19);
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(21, "\n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(22);
                            __builder5.AddAttribute(23, "style", "background-color: red");
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(25, "\n                ");
                                __builder6.AddMarkupContent(26, "<label>Titulo:</label>\n                    ");
                                __builder6.OpenComponent<Blazorise.Select<int>>(27);
                                __builder6.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(29, "\n                        ");
                                    __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateSelectItem_0(__builder7, 30, 31, 
#nullable restore
#line 20 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           1

#line default
#line hidden
#nullable disable
                                    , 32, (__builder8) => {
                                        __builder8.AddContent(33, "Sr");
                                    }
                                    );
                                    __builder7.AddMarkupContent(34, "\n                        ");
                                    __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateSelectItem_1(__builder7, 35, 36, 
#nullable restore
#line 21 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           2

#line default
#line hidden
#nullable disable
                                    , 37, (__builder8) => {
                                        __builder8.AddContent(38, "Sra");
                                    }
                                    );
                                    __builder7.AddMarkupContent(39, "\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(40, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_2(__builder6, 41, 42, 
#nullable restore
#line 23 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.titulozinho 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(43, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "   \n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(45);
                            __builder5.AddAttribute(46, "style", "background-color: red");
                            __builder5.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(48, "\n                ");
                                __builder6.AddMarkupContent(49, "<label>Nome:</label>\n                    ");
                                __builder6.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                                __builder6.AddAttribute(51, "class", "form-control");
                                __builder6.AddAttribute(52, "Placeholder", "Digite o nome aqui");
                                __builder6.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                                                    cadastro.nomezinho

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.nomezinho = __value, cadastro.nomezinho))));
                                __builder6.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cadastro.nomezinho));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_3(__builder6, 57, 58, 
#nullable restore
#line 28 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.nomezinho 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(59, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(60, "\n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(61);
                            __builder5.AddAttribute(62, "style", "background-color: red");
                            __builder5.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(64, "\n                ");
                                __builder6.AddMarkupContent(65, "<label>Sobrenome:</label>\n                    ");
                                __builder6.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                                __builder6.AddAttribute(67, "class", "form-control");
                                __builder6.AddAttribute(68, "Placeholder", "Digite o sobrenome");
                                __builder6.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                                                    cadastro.sobrenomezinho

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.sobrenomezinho = __value, cadastro.sobrenomezinho))));
                                __builder6.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cadastro.sobrenomezinho));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(72, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_4(__builder6, 73, 74, 
#nullable restore
#line 33 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.sobrenomezinho 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(75, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(76, "\n        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\n        ");
                        __builder4.OpenComponent<Blazorise.TableRow>(78);
                        __builder4.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(80, "\n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(81);
                            __builder5.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(83, "\n                ");
                                __builder6.AddMarkupContent(84, "<label>Data de Nascimento:</label>\n                    ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateInputDate_5(__builder6, 85, 86, "form-control", 87, "dd/mm/aaaa", 88, 
#nullable restore
#line 39 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                                            cadastro.datinhanascimento

#line default
#line hidden
#nullable disable
                                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.datinhanascimento = __value, cadastro.datinhanascimento)), 90, () => cadastro.datinhanascimento);
                                __builder6.AddMarkupContent(91, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_6(__builder6, 92, 93, 
#nullable restore
#line 40 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.datinhanascimento 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(94, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(95, "\n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(96);
                            __builder5.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(98, "\n                ");
                                __builder6.AddMarkupContent(99, "<label>E-mail:</label>\n                    ");
                                __builder6.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                                __builder6.AddAttribute(101, "class", "form-control");
                                __builder6.AddAttribute(102, "style", "width: 215%");
                                __builder6.AddAttribute(103, "Placeholder", "______________________Digite seu E-mail______________________");
                                __builder6.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                                                                                                                   cadastro.emailzinho

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.emailzinho = __value, cadastro.emailzinho))));
                                __builder6.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cadastro.emailzinho));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(107, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_7(__builder6, 108, 109, 
#nullable restore
#line 45 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.emailzinho 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(110, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\n        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\n        ");
                        __builder4.OpenComponent<Blazorise.TableRow>(113);
                        __builder4.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(115, "\n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(116);
                            __builder5.AddAttribute(117, "style", "background-color: lightseagreen");
                            __builder5.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(119, "\n                ");
                                __builder6.AddMarkupContent(120, "<label>Senha:</label>\n                    ");
                                __builder6.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(121);
                                __builder6.AddAttribute(122, "type", "password");
                                __builder6.AddAttribute(123, "id", "senhazinha");
                                __builder6.AddAttribute(124, "name", "senhazinha");
                                __builder6.AddAttribute(125, "class", "form-control");
                                __builder6.AddAttribute(126, "Placeholder", "Digite sua senha");
                                __builder6.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                                                                                                    cadastro.senhazinha

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.senhazinha = __value, cadastro.senhazinha))));
                                __builder6.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cadastro.senhazinha));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(130, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_8(__builder6, 131, 132, 
#nullable restore
#line 52 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.senhazinha 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(133, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(134, "\n            ");
                            __builder5.OpenComponent<Blazorise.TableRowCell>(135);
                            __builder5.AddAttribute(136, "style", "background-color: lightseagreen");
                            __builder5.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(138, "\n                ");
                                __builder6.AddMarkupContent(139, "<label>Confirmar Senha:</label>\n                    ");
                                __builder6.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(140);
                                __builder6.AddAttribute(141, "type", "password");
                                __builder6.AddAttribute(142, "id", "confirmasenhazinha");
                                __builder6.AddAttribute(143, "name", "confirmasenhazinha");
                                __builder6.AddAttribute(144, "class", "form-control");
                                __builder6.AddAttribute(145, "Placeholder", "Confirme sua senha");
                                __builder6.AddAttribute(146, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                                                                                                                      cadastro.confirmasenhazinha

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(147, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.confirmasenhazinha = __value, cadastro.confirmasenhazinha))));
                                __builder6.AddAttribute(148, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cadastro.confirmasenhazinha));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(149, "\n                ");
                                __Blazor.CadastroBlazor.Client.Pages.Cadastrinho.TypeInference.CreateValidationMessage_9(__builder6, 150, 151, 
#nullable restore
#line 57 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                           () => cadastro.confirmasenhazinha 

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(152, "\n            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(153, "\n        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(154, "\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(155, "\n    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(156, "\n    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\n    ");
                __builder2.OpenElement(159, "center");
                __builder2.AddMarkupContent(160, "\n    ");
                __builder2.OpenElement(161, "div");
                __builder2.AddMarkupContent(162, "\n        ");
                __builder2.OpenComponent<Blazorise.Column>(163);
                __builder2.AddAttribute(164, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 66 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(166, "\n            ");
                    __builder3.OpenComponent<Blazorise.Alert>(167);
                    __builder3.AddAttribute(168, "style", "background-color: hotpink");
                    __builder3.AddAttribute(169, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(170, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(171, "\n                ");
                        __builder4.OpenComponent<Blazorise.Check<bool>>(172);
                        __builder4.AddAttribute(173, "style", "cursor: pointer");
                        __builder4.AddAttribute(174, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 68 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
                                                                             cadastro.confirmacaozinha

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(175, "CheckedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cadastro.confirmacaozinha = __value, cadastro.confirmacaozinha))));
                        __builder4.AddAttribute(176, "CheckedExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => cadastro.confirmacaozinha));
                        __builder4.AddAttribute(177, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(178, "\n                Aceito os Termos\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(179, "\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(180, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(181, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(182, "\n    ");
                __builder2.AddMarkupContent(183, "<button class=\"btn btn-success\" type=\"submit\">Cadastrar</button>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_2\client\Pages\Cadastrinho.razor"
      
    Cadastro cadastro = new Cadastro();

    private void Create(){
        Console.WriteLine("Confirmacao de Cadastro");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CadastroBlazor.Client.Pages.Cadastrinho
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSelectItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Blazorise.SelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateSelectItem_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Blazorise.SelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
