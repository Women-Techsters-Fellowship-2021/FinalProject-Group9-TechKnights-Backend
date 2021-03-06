#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f42b2822ebc13c8c274c3793498cbea7b546e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SendCommunication_SendToParent), @"mvc.1.0.view", @"/Views/SendCommunication/SendToParent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f42b2822ebc13c8c274c3793498cbea7b546e52", @"/Views/SendCommunication/SendToParent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_SendCommunication_SendToParent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.Shared.ParentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/SendCommunication/Index""> Index </a>/ Parent Communication
        </div>
    </div>
</section>


<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">
");
#nullable restore
#line 21 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
         using (Html.BeginForm("SendToParent", "SendCommunication", new { @class = "smart-wizard", role = "form" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
       Write(Html.HiddenFor(model => model.ParentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <p class=\"text-small center text-danger\">");
#nullable restore
#line 25 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                                    Write(ViewBag.ValidateErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""col-md-6"">
                    <fieldset>
                        <legend>
                            Personal Information
                        </legend>
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            Firstname*
                                        </label>
                                        ");
#nullable restore
#line 38 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.Firstname, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            Middlename*
                                        </label>
                                        ");
#nullable restore
#line 47 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.Midname, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label "">
                                            Surname *
                                        </label>
                                        ");
#nullable restore
#line 56 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.Surname, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            CelPhoneNumber
                                        </label>
                                        ");
#nullable restore
#line 64 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.CelPhoneNumber, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            CommunicationMethod
                                        </label>
                                        ");
#nullable restore
#line 72 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.CommunicationMethod, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">
                                            ID/Passport
                                        </label>
                                        ");
#nullable restore
#line 80 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.IdOrPassport, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label>
                                            Prefered Language
                                        </label>
                                        ");
#nullable restore
#line 88 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.PreferedLanguage, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <br/>
                                     </div>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>

                <div class=""col-md-6"">
                    <fieldset>
                        <legend>
                            Send Emails
                        </legend>
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>
                                            To
                                        </label>
                ");
            WriteLiteral("                        ");
#nullable restore
#line 113 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.PersonalEmailAddress, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label class=""block"">
                                            Dear
                                        </label>
                                        ");
#nullable restore
#line 121 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.Surname, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label>
                                            Subject*
                                        </label>
                                        ");
#nullable restore
#line 129 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextBoxFor(m => m.EmailAudit.EmailSubject, new { @class = "form-control", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label>
                                            Body
                                        </label>
                                        ");
#nullable restore
#line 137 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
                                   Write(Html.TextAreaFor(m => m.EmailAudit.Body, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
            <div class=""form-group"">
                <button id=""submit"" class=""btn btn-primary next-step btn-wide pull-right"">
                    Send Email <i class=""fa fa-arrow-circle-right""></i>
                </button>
            </div>
");
#nullable restore
#line 150 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\SendToParent.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.Shared.ParentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
