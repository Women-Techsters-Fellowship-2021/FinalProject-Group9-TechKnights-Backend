#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\TeacherAdmin\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d57c08ad2d0a1efa3427960f4043eb382ad41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TeacherAdmin_Views_Teacher_Index), @"mvc.1.0.view", @"/Areas/TeacherAdmin/Views/Teacher/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d57c08ad2d0a1efa3427960f4043eb382ad41e", @"/Areas/TeacherAdmin/Views/Teacher/Index.cshtml")]
    public class Areas_TeacherAdmin_Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\TeacherAdmin\Views\Teacher\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">
        <div class=""col-sm-3"">
            <div class=""panel panel-white no-radius text-center"">
                <div class=""panel-body"">
                    <span class=""fa-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-smile-o fa-stack-1x fa-inverse""></i> </span>
                    <h2 class=""StepTitle"">Assignment</h2>
                    <p class=""text-small"">
                        To view student assignment
                    </p>
                    <p class=""links cl-effect-1"">
                        <a href=""/ParentAdmin/Parent/StudentAssignemnt"">
                            view more
                        </a>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-sm-3"">
            <div class=""panel panel-white no-radius text-center"">
                <div class=""panel-body"">
                    <span class=""f");
            WriteLiteral(@"a-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-paperclip fa-stack-1x fa-inverse""></i> </span>
                    <h2 class=""StepTitle"">My Exams</h2>
                    <p class=""text-small"">
                        Manage active and inactive parents on the system.
                    </p>
                    <p class=""cl-effect-1"">
                        <a href=""/StudentAdmin/Student/Exam"">
                            view more
                        </a>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-sm-3"">
            <div class=""panel panel-white no-radius text-center"">
                <div class=""panel-body"">
                    <span class=""fa-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-terminal fa-stack-1x fa-inverse""></i> </span>
                    <h2 class=""StepTitle"">My Financial</h2>
                    <p class=""text-small"">
            ");
            WriteLiteral(@"            Store, modify, and extract information for teachers.
                    </p>
                    <p class=""links cl-effect-1"">
                        <a href=""/StudentAdmin/Student/Finance"">
                            view more
                        </a>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-sm-3"">
            <div class=""panel panel-white no-radius text-center"">
                <div class=""panel-body"">
                    <span class=""fa-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-terminal fa-stack-1x fa-inverse""></i> </span>
                    <h2 class=""StepTitle"">My Messages</h2>
                    <p class=""text-small"">
                        Store, modify, and extract information for teachers.
                    </p>
                    <p class=""links cl-effect-1"">
                        <a href=""/StudentAdmin/Student/Finance"">
                           ");
            WriteLiteral(" view more\r\n                        </a>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end: FEATURED BOX LINKS -->");
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
