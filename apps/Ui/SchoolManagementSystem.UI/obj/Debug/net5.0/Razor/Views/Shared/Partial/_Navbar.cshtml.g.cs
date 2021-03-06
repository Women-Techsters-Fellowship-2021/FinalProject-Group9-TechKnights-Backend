#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c323fa8f6deba286868145b97f38150ee7f87a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__Navbar), @"mvc.1.0.view", @"/Views/Shared/Partial/_Navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c323fa8f6deba286868145b97f38150ee7f87a26", @"/Views/Shared/Partial/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""sidebar app-aside"" id=""sidebar"">
    <div class=""sidebar-container perfect-scrollbar"">
        <nav>     
        
            <!-- start: MAIN NAVIGATION MENU -->
            <div class=""navbar-title"">
                <span>Main Navigation</span>
            </div>
            <ul class=""main-navigation-menu"">

");
#nullable restore
#line 11 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                 if (ViewContext.HttpContext.User.IsInRole("SystemAdmin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""active open"">
                        <a href=""/Home/Index"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-home""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Dashboard </span>
                                </div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-settings""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Student</span><i class=""icon-arro");
            WriteLiteral(@"w""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""/Student/Index"">
                                    <span class=""title""> Student Home </span>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-layout-grid2""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Teacher </span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                     ");
            WriteLiteral(@"   </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""/Teacher/Index"">
                                    <span class=""title"">Teacher Home</span>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-pencil-alt""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Parents </span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                    ");
            WriteLiteral(@"            <a href=""/Parent/Index"">
                                    <span class=""title"">Parent Home</span>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-user""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Accademic Syllabus </span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""/Grade/Index"">
                                    <span class=""title""> Add Grade(s) ");
            WriteLiteral(@"</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/Subject/Index"">
                                    <span class=""title""> Add Modules</span>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li");
            BeginWriteAttribute("class", " class=\"", 4933, "\"", 4941, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""/Invoice/Index"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-clipboard""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Finance </span>
                                </div>
                            </div>
                        </a>
                    </li>
");
#nullable restore
#line 118 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                 if (ViewContext.HttpContext.User.IsInRole("Student"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-layers-alt""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Student Admin </span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">

                            <li>
                                <a href=""/StudentAdmin/Student/Index"">
                                    <span class=""title"">Student Admin</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/StudentAdmin/Student/StudentInformation"">
                           ");
            WriteLiteral(@"         <span class=""title"">MyInformation</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/StudentAdmin/Student/Assignment"">
                                    <span class=""title"">MyAssignment</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/StudentAdmin/Student/Exam"">
                                    <span class=""title"">MyExams</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/StudentAdmin/Student/Finance"">
                                    <span class=""title"">MyFinance</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/StudentAdmin/Student/StudentMessage"">
                   ");
            WriteLiteral("                 <span class=\"title\">MyMessages</span>\r\n                                </a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 167 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 169 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                 if (ViewContext.HttpContext.User.IsInRole("Teacher"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-layers-alt""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Teacher Admin </span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""/StudentAdmin/Student/StudentInformation"">
                                    <span class=""title"">Student Information</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""");
            WriteLiteral(@"title"">Assignment</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""title"">Exams</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""title"">Student Finance</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/TeacherAdmin/Teacher/TeacherMessage"">
                                    <span class=""title"">Messages</span>
                                </a>
                            </li>
                        </ul>
                    </li>
");
#nullable restore
#line 210 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 212 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                 if (ViewContext.HttpContext.User.IsInRole("Parent"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-layers-alt""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Parent Admin </span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""/ParentAdmin/Parent/ParentInformation"">
                                    <span class=""title"">Parent Information</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""title");
            WriteLiteral(@""">Assignment</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""title"">Exams</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""title"">Student Finance</span>
                                </a>
                            </li>
                            <li>
                                <a href=""/ParentAdmin/Parent/ParentMessage"">
                                    <span class=""title"">Messages</span>
                                </a>
                            </li>
                        </ul>
                    </li>
");
#nullable restore
#line 253 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 255 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                 if (ViewContext.HttpContext.User.IsInRole("SystemAdmin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li>
                        <a href=""javascript:void(0)"">
                            <div class=""item-content"">
                                <div class=""item-media"">
                                    <i class=""ti-settings""></i>
                                </div>
                                <div class=""item-inner"">
                                    <span class=""title""> Communication</span><i class=""icon-arrow""></i>
                                </div>
                            </div>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""/SendCommunication/Index"">
                                    <span class=""title""> Send Email </span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""title""> Sent Mails </span>");
            WriteLiteral("\r\n                                </a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 281 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
            <!-- end: MAIN NAVIGATION MENU -->
            <!-- start: CORE FEATURES -->
            <div class=""navbar-title"">
                <span>Core Features</span>
            </div>
            <ul class=""folders"">

                <li>
                    <a href=""#"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <span class=""fa-stack""> <i class=""fa fa-square fa-stack-2x""></i> <i class=""fa fa-terminal fa-stack-1x fa-inverse""></i> </span>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> School events </span>
                            </div>
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <div class=""item-content"">
                            <div class=""item-media"">
       ");
            WriteLiteral(@"                         <span class=""fa-stack""> <i class=""fa fa-square fa-stack-2x""></i> <i class=""fa fa-folder-open-o fa-stack-1x fa-inverse""></i> </span>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> System Documentation </span>
                            </div>
                        </div>
                    </a>
                </li>
            </ul>
            <!-- end: CORE FEATURES -->
            <!-- start: DOCUMENTATION BUTTON -->
            <div class=""wrapper"">
                <a href=""#"" class=""button-o"">
                    <i class=""ti-help""></i>
                    <span>Documentation</span>
                </a>
            </div>
            <!-- end: DOCUMENTATION BUTTON -->
        </nav>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
