#pragma checksum "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d073f697bcf6ff5bce873db130da6845c6c0c03"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor"
using BlazorApp1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public partial class Project : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Project</h3>\r\n");
            __builder.AddMarkupContent(1, "<div><button> + New Project </button></div>\r\n");
            __builder.OpenComponent<Blazorise.Table>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(8);
                        __builder4.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(10, "Id");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(11, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(12);
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(14, "Project name");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(16);
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(18, "Action");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<Blazorise.TableBody>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 19 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor"
         foreach (var project in ListProject)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(22);
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowCell>(24);
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, 
#nullable restore
#line 22 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor"
                               project.Id

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(28);
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(30, 
#nullable restore
#line 23 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor"
                               project.ProjectName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(32);
                        __builder4.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(34, "<button> Edit </button>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 26 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "F:\Nam 4\KhoaLuanTotNghiep\BlazorApp1\BlazorApp1\Pages\Project.razor"
       
    private List<BlazorApp1.Models.Project> ListProject;

    protected override async Task OnInitializedAsync()
    {
        ListProject = ProjectService.GetAllProject().ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService ProjectService { get; set; }
    }
}
#pragma warning restore 1591
