#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e256ec9d82e11a268a532ec1b45f0f995cb2ba4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e256ec9d82e11a268a532ec1b45f0f995cb2ba4b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!-- start: DASHBOARD TITLE -->
    <section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
        <div class=""row"">
            <div class=""col-sm-7"">
                <h1 class=""mainTitle"">Dashboard</h1>
                <span class=""mainDescription"">overview &amp; stats </span>
            </div>
            <div class=""col-sm-5"">
                <!-- start: MINI STATS WITH SPARKLINE -->
                <ul class=""mini-stats pull-right"">
                    <li>
                        <div class=""sparkline-1"">
                            <span></span>
                        </div>
                        <div class=""values"">
                            <strong class=""text-dark"">");
#nullable restore
#line 21 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Home\Index.cshtml"
                                                 Write(ViewBag.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                            <p class=""text-small no-margin"">
                                Students
                            </p>
                        </div>
                    </li>
                    <li>
                        <div class=""sparkline-2"">
                            <span></span>
                        </div>
                        <div class=""values"">
                            <strong class=""text-dark"">");
#nullable restore
#line 32 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Home\Index.cshtml"
                                                 Write(ViewBag.ParentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                            <p class=""text-small no-margin"">
                                Parents
                            </p>
                        </div>
                    </li>
                    <li>
                        <div class=""sparkline-3"">
                            <span></span>
                        </div>
                        <div class=""values"">
                            <strong class=""text-dark"">");
#nullable restore
#line 43 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Home\Index.cshtml"
                                                 Write(ViewBag.TeacherCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                            <p class=""text-small no-margin"">
                                Teachers
                            </p>
                        </div>
                    </li>
                </ul>
                <!-- end: MINI STATS WITH SPARKLINE -->
            </div>
        </div>
    </section>
    <!-- end: DASHBOARD TITLE -->
    <!-- start: FEATURED BOX LINKS -->
    <div class=""container-fluid container-fullw bg-white"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div class=""panel panel-white no-radius text-center"">
                    <div class=""panel-body"">
                        <span class=""fa-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-users fa-stack-1x fa-inverse""></i> </span>
                        <h2 class=""StepTitle"">Manage Admin</h2>
                        <p class=""text-small"">
                            To add admin, you need to be signed in as the super user.
 ");
            WriteLiteral(@"                       </p>
                        <p class=""links cl-effect-1"">
                            <a href=""/Identity/Account/Register"">
                                view more
                            </a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""panel panel-white no-radius text-center"">
                    <div class=""panel-body"">
                        <span class=""fa-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-server fa-stack-1x fa-inverse""></i> </span>
                        <h2 class=""StepTitle"">Manage Students</h2>
                        <p class=""text-small"">
                            The Manage students tool provides a view of all your students.
                        </p>
                        <p class=""cl-effect-1"">
                            <a href=""/Student/Index"">
                              ");
            WriteLiteral(@"  view more
                            </a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""panel panel-white no-radius text-center"">
                    <div class=""panel-body"">
                        <span class=""fa-stack fa-2x""> <i class=""fa fa-square fa-stack-2x text-primary""></i> <i class=""fa fa-suitcase fa-stack-1x fa-inverse""></i> </span>
                        <h2 class=""StepTitle"">Manage Teachers</h2>
                        <p class=""text-small"">
                            Store, modify, and extract information for teachers.
                        </p>
                        <p class=""links cl-effect-1"">
                            <a href=""/Teacher/Index"">
                                view more
                            </a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!");
            WriteLiteral(@"-- end: FEATURED BOX LINKS -->
    <!-- start: FIRST SECTION -->
    <div class=""container-fluid container-fullw padding-bottom-10"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""row"">
                    <div class=""col-md-7 col-lg-8"">
                        <div class=""panel panel-white no-radius"" id=""visits"">
                            <div class=""panel-heading border-light"">
                                <h4 class=""panel-title""> Visits </h4>
                                <ul class=""panel-heading-tabs border-light"">
                                    <li>
                                        <div class=""pull-right"">
                                            <div class=""btn-group"">
                                                <a class=""padding-10"" data-toggle=""dropdown"">
                                                    <i class=""ti-more-alt ""></i>
                                                </a>
                              ");
            WriteLiteral(@"                  <ul class=""dropdown-menu dropdown-light"" role=""menu"">
                                                    <li>
                                                        <a href=""#"">
                                                            Action
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"">
                                                            Another action
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"">
                                                            Something else here
                                                        </a>
                                      ");
            WriteLiteral(@"              </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </li>
                                    <li>
                                        <div class=""rate"">
                                            <i class=""fa fa-caret-up text-primary""></i><span class=""value"">15</span><span class=""percentage"">%</span>
                                        </div>
                                    </li>
                                    <li class=""panel-tools"">
                                        <a data-original-title=""Refresh"" data-toggle=""tooltip"" data-placement=""top"" class=""btn btn-transparent btn-sm panel-refresh"" href=""#""><i class=""ti-reload""></i></a>
                                    </li>
                                </ul>
                            </div>
                            <div collapse=""visits"" class=""panel-wrapper"">
 ");
            WriteLiteral(@"                               <div class=""panel-body"">
                                    <div class=""height-350"">
                                        <canvas id=""chart1"" class=""full-width""></canvas>
                                        <div class=""margin-top-20"">
                                            <div class=""inline pull-left"">
                                                <div id=""chart1Legend"" class=""chart-legend""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-5 col-lg-4"">
                        <div class=""panel panel-white no-radius"">
                            <div class=""panel-heading border-light"">
                                <h4 class=""panel-title""> Acquisition </h4>
                        ");
            WriteLiteral(@"    </div>
                            <div class=""panel-body"">
                                <h3 class=""inline-block no-margin"">26</h3> visitors on-line
                                <div class=""progress progress-xs no-radius"">
                                    <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%;"">
                                        <span class=""sr-only""> 40% Complete</span>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-4"">
                                        <h4 class=""no-margin"">15</h4>
                                        <div class=""progress progress-xs no-radius no-margin"">
                                            <div class=""progress-bar progress-bar-danger"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=");
            WriteLiteral(@"""100"" style=""width: 80%;"">
                                                <span class=""sr-only""> 80% Complete</span>
                                            </div>
                                        </div>
                                        Direct
                                    </div>
                                    <div class=""col-sm-4"">
                                        <h4 class=""no-margin"">7</h4>
                                        <div class=""progress progress-xs no-radius no-margin"">
                                            <div class=""progress-bar progress-bar-info"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;"">
                                                <span class=""sr-only""> 60% Complete</span>
                                            </div>
                                        </div>
                                        Sites
                                    </div>
                 ");
            WriteLiteral(@"                   <div class=""col-sm-4"">
                                        <h4 class=""no-margin"">4</h4>
                                        <div class=""progress progress-xs no-radius no-margin"">
                                            <div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%;"">
                                                <span class=""sr-only""> 40% Complete</span>
                                            </div>
                                        </div>
                                        Search
                                    </div>
                                </div>
                                <div class=""row margin-top-30"">
                                    <div class=""col-xs-4 text-center"">
                                        <div class=""rate"">
                                            <i class=""fa fa-caret-up text-green""></i><span class=""value"">");
            WriteLiteral(@"26</span><span class=""percentage"">%</span>
                                        </div>
                                        Mac OS X
                                    </div>
                                    <div class=""col-xs-4 text-center"">
                                        <div class=""rate"">
                                            <i class=""fa fa-caret-up text-green""></i><span class=""value"">62</span><span class=""percentage"">%</span>
                                        </div>
                                        Windows
                                    </div>
                                    <div class=""col-xs-4 text-center"">
                                        <div class=""rate"">
                                            <i class=""fa fa-caret-down text-red""></i><span class=""value"">12</span><span class=""percentage"">%</span>
                                        </div>
                                        Other OS
                                    <");
            WriteLiteral(@"/div>
                                </div>
                                <div class=""margin-top-10"">
                                    <div class=""height-180"">
                                        <canvas id=""chart2"" class=""full-width""></canvas>
                                        <div class=""inline pull-left legend-xs"">
                                            <div id=""chart2Legend"" class=""chart-legend""></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- end: FIRST SECTION -->


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
