#pragma checksum "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f4873e8ab87b572962c5ca09a66492c81b84b58"
// <auto-generated/>
#pragma warning disable 1591
namespace IglesiaCatolicaUnidos.Componentes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using IglesiaCatolicaUnidos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using IglesiaCatolicaUnidos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor"
using IglesiaCatolicaUnidos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor"
using IglesiaCatolicaUnidos.Componentes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregar")]
    public partial class DirecionarAgregar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "p-2 w-100");
                __builder2.AddAttribute(4, "style", "background-color:" + " " + (
#nullable restore
#line 10 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor"
                                                             Color

#line default
#line hidden
#nullable disable
                ) + ";" + " border-radius:" + " 5px;");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "p-2 d-flex");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-4 mr-3 p-3");
                __builder2.AddAttribute(9, "style", "background-color: white;");
                __builder2.OpenComponent<IglesiaCatolicaUnidos.Componentes.AgregarIntegrante>(10);
                __builder2.AddAttribute(11, "Uid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 13 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor"
                                                 userId

#line default
#line hidden
#nullable disable
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
#line 22 "C:\Users\Acer\source\repos\IglesiaCatolicaUnidos\IglesiaCatolicaUnidos\Componentes\DirecionarAgregar.razor"
                   
                [CascadingParameter]
                private Task<AuthenticationState> authenticationStateTask { get; set; }

                private string Color = "#ffffff";
                private MyUsuario user = new MyUsuario();
                private Guid userId;

                private void evnt()
                {
                    Console.WriteLine("enento");
                }

                protected override async Task OnInitializedAsync()
                {
                    var authState = await authenticationStateTask;
                    user = await UserManager.GetUserAsync(authState.User);
                    userId = user.MyUsuarioID;
                }
            

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<MyUsuario> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<MyUsuario> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
