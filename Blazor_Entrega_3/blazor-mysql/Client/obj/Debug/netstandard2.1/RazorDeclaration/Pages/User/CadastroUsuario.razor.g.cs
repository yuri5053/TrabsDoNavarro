#pragma checksum "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\Pages\User\CadastroUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a97c45069942f72d5b8aabdc37e1842253c999"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_mysql.Client.Pages.User
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\Pages\User\CadastroUsuario.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/User/CadastroUsuario")]
    public partial class CadastroUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Yuri\Desktop\coisasdorego\Blazor_Entrega_3\blazor-mysql\Client\Pages\User\CadastroUsuario.razor"
       

    private User user = new User();
    private EditContext editContext { get; set; }

    private async Task HandleValidSubmit()
    {
        //Enviar dados para o Controller no Backend
        var teste = await Http.PostAsJsonAsync("/User/Create", user);
        NavigationManager.NavigateTo("user/ListUsuario");

    }

    private void HandleReset()
    {
        user = new User();
        editContext = new EditContext(user);
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591