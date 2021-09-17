#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c73bc25b0e633db996ee7438ef5bdb934947c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Index), @"mvc.1.0.view", @"/Views/Subject/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\_ViewImports.cshtml"
using SchoolManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\_ViewImports.cshtml"
using SchoolManagementSystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c73bc25b0e633db996ee7438ef5bdb934947c7", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SchoolManagementSystem.Shared.ModuleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/Student/Index""> Index </a>/ Modules
        </div>
    </div>
</section>

<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">     
        <div class=""col-md-12"">
            <div class=""panel-body"">
                <button class=""btn btn-primary btn-o pull-left"" data-toggle=""modal"" data-target="".bs-example-modal-lg"">
                    Create Modules
                </button>
            </div>
            <p class=""text-large center text-blue"">Please make sure you capture teacher details first.</p>
            <table class=""table table-striped table-bordered table-hover table-full-width"" id=""sample_1"">
                <thead>
                    <tr>
                        <th>#ModuleId</th>
                        <th>Module </th>
                        <th>Grade</th>
                        <th>PassMark</th>
    ");
            WriteLiteral(@"                    <th>Teacher Fullnames</th>
                        <th class=""hidden-xs"">
                            Description
                        </th>
                        <th class=""hidden-xs"">
                            CreatedBy
                        </th>
                        <th>
                        </th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                           Write(item.ModuleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                           Write(item.Module);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                           Write(item.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                           Write(item.PassPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                           Write(item.Fullnames);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 53 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 54 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                                             Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = item.ModuleId, @class = "delete-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>

<!-- Start Create -->
<div class=""modal fade bs-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"" id=""myModalLabel"">Create Module</h4>
            </div>
            <div class=""modal-body"">
                <div class=""container-fluid container-fullw bg-white"">
                    <div class=""row"">

");
#nullable restore
#line 80 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                         using (Html.BeginForm("Create", "Subject", new { @class = "smart-wizard", role = "form" }))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <fieldset>
                                        <legend>
                                            Creat Module
                                        </legend>
                                        <div class=""form-group"">
                                            <div class=""row"">
                                                <div class=""col-md-3"">
                                                    <div class=""form-group"">
                                                        <label>
                                                            Module
                                                        </label>
                                                        <input type=""text"" placeholder=""Enter grades"" class=""form-control"" name=""Module"" required />
                                                    </div>
                         ");
            WriteLiteral(@"                       </div>
                                                <div class=""col-md-3"">
                                                    <div class=""form-group"">
                                                        <label>
                                                            Pass Points
                                                        </label>
                                                        <input type=""number"" placeholder=""Enter points"" class=""form-control"" name=""PassPoint"" required />

                                                    </div>
                                                </div>
                                                <div class=""col-md-3"">
                                                    <div class=""form-group"">
                                                        <label class=""control-label "">
                                                            Grade
                                                        </lab");
            WriteLiteral("el>\r\n                                                        ");
#nullable restore
#line 113 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                                                   Write(Html.DropDownList("GradeId", new SelectList(ViewBag.Grade, "GradeId", "Grade"), "Select student grade", new { @class = "form-control", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                             
                                                    </div>
                                                </div>
                                                <div class=""col-md-3"">
                                                    <div class=""form-group"">
                                                        <label class=""control-label "">
                                                            Teacher
                                                        </label>
                                                        ");
#nullable restore
#line 121 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                                                   Write(Html.DropDownList("TeacherId", new SelectList(ViewBag.Teacher, "TeacherId", "Fullnames"), "Select subject teacher", new { @class = "form-control", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                  
                                                    </div>
                                                </div>
                                                <div class=""col-md-12"">
                                                    <div class=""form-group"">
                                                        <label class=""control-label"">
                                                            Module Description
                                                        </label>
                                                        <textarea placeholder=""Module Description"" id=""form-field-22"" name=""Description"" class=""form-control""></textarea>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </fieldset>
                                </di");
            WriteLiteral(@"v>
                            </div>
                            <div class=""form-group"">
                                <button id=""submit"" class=""btn btn-primary next-step btn-wide pull-right"">
                                    Save changes <i class=""fa fa-arrow-circle-right""></i>
                                </button>
                            </div>
");
#nullable restore
#line 142 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Subject\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary btn-o"" data-dismiss=""modal"">
                    Close
                </button>
            </div>
        </div>
    </div>
</div>
<!-- End Create -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SchoolManagementSystem.Shared.ModuleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
