#pragma checksum "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0634d8421908998225c25367fa77026560e48121"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h2>Delete Employee</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this?</h3>\r\n");
            __builder.OpenElement(2, "form");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", " col-md-8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "<label>Employee Id:</label>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddContent(11, 
#nullable restore
#line 17 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
                        obj.EmpId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Employee Name:</label>\r\n                ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, 
#nullable restore
#line 21 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
                        obj.EmpName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label>Age:</label>\r\n                ");
            __builder.OpenElement(22, "label");
            __builder.AddContent(23, 
#nullable restore
#line 25 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
                        obj.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label>Mail Id:</label>\r\n                ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, 
#nullable restore
#line 29 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
                        obj.EmailId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-4");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
                                                                       DeleteEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\.Net Programs\BlazorCrudOperations\Pages\Delete.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
