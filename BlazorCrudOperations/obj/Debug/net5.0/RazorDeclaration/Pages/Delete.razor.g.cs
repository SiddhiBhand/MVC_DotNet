// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrudOperations.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using BlazorCrudOperations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.Net Programs\BlazorCrudOperations\_Imports.razor"
using BlazorCrudOperations.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
using BlazorCrudOperations.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
using BlazorCrudOperations.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
       
    [Parameter]
    public string Id { get; set; }

    EmployeeViewModel obj = new EmployeeViewModel();

    protected override async Task OnInitializedAsync()
    {
        var getResult = await Task.Run(() => repo.GetEmployees());

        obj = getResult.Where(e => e.EmpId == Convert.ToInt32(Id)).Select(e => new EmployeeViewModel
        {
            EmpId = e.EmpId,
            EmpName = e.EmpName,
            Age = e.Age,
            EmailId = e.EmailId
        }).FirstOrDefault();
    }

    protected async void DeleteEmployee()
    {
        await Task.Run(() => repo.DeleteEmployee(obj.EmpId));

        NavigationManager.NavigateTo("Employees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("Employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TestDBRepository repo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
