// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class DateTimeComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\DateTimeComponent.razor"
       
    // Declare Varaible
    

    public Dictionary<string, object> NameAttributes { get; set; } = new Dictionary<string, object>
    {
        { "maxlength" , "10" },
        {"placeholder", "Enter Name" },
        {"required" , "required" },
        {"size" , "40" }
    };




    List<Product> products = new List<Product>
    {
        new Product
        {
            ProductID =1,Name="IPhone"
        },
         new Product
        {
            ProductID =2,Name="Samsung"
        }
    };

    public string  ProductName { get; set; }

    public void AddFunction()
    {
        Console.WriteLine("Add Function Called");
    }
    public void SearchFunction(string productName)
    {
        Console.WriteLine(productName);
    }



    string redColor = "red-background";
    string yellowColor = "yellow-background";


    public string SelectedCategory { get; set; }

    string[] categories = { "Cricket", "Chess", "Soccer" };


    // Declare an Property
    public bool IsChecked { get; set; }

    // Source
    ProductViewModel productViewModel = new ProductViewModel
    {
        ProductID = 1,
        Category = "Chess",
        Description = "Chess",
        MfgDate = DateTime.Now,
        Name = "Chess Board",
        Price = 100
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
