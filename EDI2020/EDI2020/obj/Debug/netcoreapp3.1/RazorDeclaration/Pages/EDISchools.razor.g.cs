#pragma checksum "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\Pages\EDISchools.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31ce62cd3a24efb3225e4b6e9eadf4b0b40da70a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EDI2020.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using EDI2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\_Imports.razor"
using EDI2020.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\Pages\EDISchools.razor"
using EDI2020.DAL.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\Pages\EDISchools.razor"
using EDI2020.DAL.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/schools")]
    public partial class EDISchools : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\dengb\Source\Repos\RADB\Offord-EDI-2020\EDI2020\EDI2020\Pages\EDISchools.razor"
       


    private List<School> schools;

    protected override Task OnInitializedAsync()
    {

        schools = edi.Schools.ToList();
        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EDI2020Context edi { get; set; }
    }
}
#pragma warning restore 1591
