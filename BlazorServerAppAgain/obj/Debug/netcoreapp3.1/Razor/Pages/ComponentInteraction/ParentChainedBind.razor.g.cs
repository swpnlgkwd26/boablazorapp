#pragma checksum "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\ComponentInteraction\ParentChainedBind.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f90e3a7c1d33e6fd4fd9517da9f0cb45a632466"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerAppAgain.Pages.ComponentInteraction
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using BlazorServerAppAgain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using BlazorServerAppAgain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using BlazorServerAppAgain.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\_Imports.razor"
using BlazorServerAppAgain.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/parentchainedbind")]
    public partial class ParentChainedBind : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ParentChainedBind</h3>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\ComponentInteraction\ParentChainedBind.razor"
                          Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<BlazorServerAppAgain.Pages.ComponentInteraction.ChildChainedBind>(6);
            __builder.AddAttribute(7, "MainTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\ComponentInteraction\ParentChainedBind.razor"
                                   Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "MainTitleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Title = __value, Title))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\ComponentInteraction\ParentChainedBind.razor"
       

    public string Title { get; set; } = "Two Way Data Binding";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591