#pragma checksum "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44883a61462925aeea7cec509dfa0cccd6634b94"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pizza-cards");
            __builder.AddMarkupContent(5, "\r\n");
#line 6 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
         if (specials != null)
        {
            

#line default
#line hidden
#line 8 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
             foreach (var special in specials)
            {

#line default
#line hidden
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                () => ShowConfigurePizzaDialog(special)

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#line 10 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                                                                                         special.ImageUrl

#line default
#line hidden
            ) + "\')");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "pizza-info");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "title");
            __builder.AddContent(16, 
#line 12 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                             special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddContent(18, 
#line 13 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                         special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "price");
            __builder.AddContent(22, 
#line 14 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                             special.GetFormattedBasePrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#line 17 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
#line 17 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
#line 22 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
 if (showingConfigureDialog)
{

#line default
#line hidden
            __builder.AddContent(29, "    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfigurePizzaDialog>(30);
            __builder.AddAttribute(31, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 24 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                 configuringPizza

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 24 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                                             CancelConfigurePizzaDialog

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
#line 25 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 27 "C:\Users\andre678\source\repos\Codemash2020\blazor-workshop\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
       
    List<PizzaSpecial> specials;
    Pizza configuringPizza;
    bool showingConfigureDialog;

    protected async override Task OnInitializedAsync()
    {
        specials = await HttpClient.GetJsonAsync<List<PizzaSpecial>>("specials");
    }

    void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        configuringPizza = new Pizza()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>(),
        };

        showingConfigureDialog = true;
    }

    void CancelConfigurePizzaDialog()
    {
        configuringPizza = null;
        showingConfigureDialog = false;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
