#pragma checksum "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072026ee950ab7a97e7b10d3664fca0e6c8ab34f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_Create), @"mvc.1.0.view", @"/Views/Feedbacks/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/Create.cshtml", typeof(AspNetCore.Views_Feedbacks_Create))]
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
#line 1 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\_ViewImports.cshtml"
using ISSSC;

#line default
#line hidden
#line 2 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\_ViewImports.cshtml"
using ISSSC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072026ee950ab7a97e7b10d3664fca0e6c8ab34f", @"/Views/Feedbacks/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISSSC.Models.Feedback>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
  
    ViewBag.Title = "Feedback";

#line default
#line hidden
            BeginContext(72, 208, true);
            WriteLiteral("\r\n<h2>Feedback</h2>\r\n\r\n<div class=\"body-content container-fluid text-center\">\r\n    <div class=\"row content\">\r\n        <div class=\"col-sm-2 sidenav\">\r\n        </div>\r\n        <div class=\"col-sm-8 text-left\">\r\n");
            EndContext();
#line 14 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
            BeginContext(351, 23, false);
#line 16 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(378, 134, true);
            WriteLiteral("                <div class=\"form-horizontal\">\r\n                    <h4>Feedback</h4>\r\n                    <hr />\r\n                    ");
            EndContext();
            BeginContext(513, 64, false);
#line 21 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(577, 72, true);
            WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(650, 33, false);
#line 23 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
                   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(683, 102, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(786, 93, false);
#line 27 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
                   Write(Html.LabelFor(model => model.Text, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(879, 79, true);
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
            EndContext();
            BeginContext(959, 93, false);
#line 29 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
                       Write(Html.EditorFor(model => model.Text, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1083, 82, false);
#line 30 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Text, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 352, true);
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Odeslat"" class=""btn btn-default"" />
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 40 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
            }

#line default
#line hidden
            BeginContext(1532, 37, true);
            WriteLiteral("\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1570, 55, false);
#line 43 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\Create.cshtml"
           Write(Html.ActionLink(SSCISResources.Resources.BACK, "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 120, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-2 sidenav\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISSSC.Models.Feedback> Html { get; private set; }
    }
}
#pragma warning restore 1591
