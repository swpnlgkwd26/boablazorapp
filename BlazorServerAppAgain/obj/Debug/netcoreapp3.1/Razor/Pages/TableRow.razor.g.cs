#pragma checksum "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa84467cc2b3bd4a19f0b5c3f5f05757e205d31f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerAppAgain.Pages
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
    public partial class TableRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor"
          ProductID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 5 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor"
          Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 6 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor"
          Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 7 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor"
          Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<button class=\"btn btn-danger\"> Delete</button>\r\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-warning");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor"
                                                  NavigatetoUpdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, " Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\TableRow.razor"
       
    [Parameter]
    public int ProductID { get; set; }
    [Parameter]
    public string Name { get; set; }
    [Parameter]
    public decimal Price { get; set; }
    [Parameter]
    public string Category { get; set; }

    public void Delete()
    {
        Console.WriteLine("Delete Called");
    }
    public void Update()
    {
        Console.WriteLine("Update Called");
    }
    public void NavigatetoUpdate()
    {
        NavigationManager.NavigateTo("/update/"+ProductID);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
