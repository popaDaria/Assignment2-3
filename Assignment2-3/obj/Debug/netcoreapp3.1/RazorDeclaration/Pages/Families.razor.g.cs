#pragma checksum "D:\rider\Assignment2-3\Assignment2-3\Pages\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "995cb7db1702329e3643fee38782d69ffd648fda"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment2_3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Assignment2_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\rider\Assignment2-3\Assignment2-3\_Imports.razor"
using Assignment2_3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\rider\Assignment2-3\Assignment2-3\Pages\Families.razor"
using Assignment2_3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\rider\Assignment2-3\Assignment2-3\Pages\Families.razor"
using Assignment2_3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\rider\Assignment2-3\Assignment2-3\Pages\Families.razor"
       
    private IList<Family> allFamilies;
    

    protected override async Task OnInitializedAsync()
    {
        allFamilies = await FamilyService.GetFamiliesAsync();
    }

    private void infoButton_Click(MouseEventArgs e)
    {
        NavigationManager.NavigateTo("/FamilyInfo");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
