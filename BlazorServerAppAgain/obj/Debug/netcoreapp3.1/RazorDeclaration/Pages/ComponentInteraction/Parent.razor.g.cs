// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/parent")]
    public partial class Parent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\FreeLancerAssignments\BankOfAmericaBatch3\boablazorapp\BlazorServerAppAgain\Pages\ComponentInteraction\Parent.razor"
       
    public string UserName { get; set; }

    public string DataReceivedFromChild { get; set; }

    public void GetDataFromChild(string value)
    {
        DataReceivedFromChild = value;
    }

    public ModalChild dialog;
    public void CallChildFunction()
    {
        dialog.ModalChildFunction();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
