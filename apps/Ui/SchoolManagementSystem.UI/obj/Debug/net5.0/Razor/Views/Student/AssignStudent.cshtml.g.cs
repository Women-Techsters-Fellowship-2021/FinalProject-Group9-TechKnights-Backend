#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce942db1fef9a98d6c7c06c91eb121f904786de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AssignStudent), @"mvc.1.0.view", @"/Views/Student/AssignStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce942db1fef9a98d6c7c06c91eb121f904786de", @"/Views/Student/AssignStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AssignStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolManagementSystem.Shared.StudentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
        <div class=""row"">
            <div class=""col-sm-7"">
                <a href=""/Student/Index""> Index </a>/ Assign User 
            </div>
        </div>
    </section>

    <div class=""container-fluid container-fullw bg-white"">
        <p class=""text-small center text-danger"">");
#nullable restore
#line 18 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                            Write(ViewBag.ValidationMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <div class=""row"">
            <div class=""col-md-12"">
                <h5 class=""over-title margin-bottom-15"">Student <span class=""text-bold"">List</span></h5>
                <p>
                   Assign student to the system
                </p>
                <table class=""table table-striped table-bordered table-hover table-full-width"" id=""sample_1"">
                    <thead>
                        <tr>
                            <th>FullNames</th>
                            <th>
                                ID/Passport
                            </th>
                            <th class=""hidden-xs"">Role</th>
                            <th class=""hidden-xs"">Phone</th>
                            <th class=""hidden-xs"">Email</th>
                            <th class=""hidden-xs"">
                                StudentNumber
                            </th>
                            <th class=""hidden-xs"">Address</th>
                            <th class=""hi");
            WriteLiteral(@"dden-xs"">
                                CreatedBy
                            </th>
                            <th class=""hidden-xs"">
                                AssignStudent
                            </th>                          
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 48 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 51 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                           Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 51 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                            Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 52 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                           Write(item.IdOrPassport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">Student</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 54 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                             Write(item.CelPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 55 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                             Write(item.PersonalEmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 56 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                             Write(item.StudentNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 57 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                             Write(item.PhysicalAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 58 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                                             Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 60 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                             if (item.ApplicationStatus == "InProcess")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2741, "\"", 2793, 2);
            WriteAttributeValue("", 2748, "/Identity/Account/Register?id=", 2748, 30, true);
#nullable restore
#line 62 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
WriteAttributeValue("", 2778, item.StudentId, 2778, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AssignToSystem</a></td>\r\n");
#nullable restore
#line 63 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><p class=\"text-danger\">User Assigned</p></td>\r\n");
#nullable restore
#line 67 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                            }                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 69 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Student\AssignStudent.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- end: DYNAMIC TABLE -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolManagementSystem.Shared.StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
