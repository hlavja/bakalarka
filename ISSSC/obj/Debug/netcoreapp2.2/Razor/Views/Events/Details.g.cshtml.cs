#pragma checksum "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b305c970aa74ae73544d6e8acf8635746803aeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Details), @"mvc.1.0.view", @"/Views/Events/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Details.cshtml", typeof(AspNetCore.Views_Events_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b305c970aa74ae73544d6e8acf8635746803aeb", @"/Views/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISSSC.Models.Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
  
    ViewBag.Title = SSCISResources.Resources.EVENT_DETAIL;
    ViewBag.ActiveMenuItem = "menu-eventlist";

#line default
#line hidden
            BeginContext(144, 256, true);
            WriteLiteral(@"<div class=""body-content container-fluid text-center"">
    <div class=""row content"">
        <div class=""col-sm-2 sidenav"">
        </div>
        <div class=""col-sm-8 text-left"">
            <h2>Detaily</h2>

            <div>
                <h4>");
            EndContext();
            BeginContext(401, 30, false);
#line 15 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
               Write(SSCISResources.Resources.EVENT);

#line default
#line hidden
            EndContext();
            BeginContext(431, 125, true);
            WriteLiteral("</h4>\r\n                <hr />\r\n                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(557, 34, false);
#line 19 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.TIME_FROM);

#line default
#line hidden
            EndContext();
            BeginContext(591, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(673, 40, false);
#line 23 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TimeFrom));

#line default
#line hidden
            EndContext();
            BeginContext(713, 81, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(795, 32, false);
#line 27 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.TIME_TO);

#line default
#line hidden
            EndContext();
            BeginContext(827, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(909, 38, false);
#line 31 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TimeTo));

#line default
#line hidden
            EndContext();
            BeginContext(947, 81, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1029, 33, false);
#line 35 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.ACCEPTED);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1144, 54, false);
#line 39 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(ISSSC.Class.SSCISHtml.DisplayForBool(Model.IsAccepted));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 81, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1280, 34, false);
#line 43 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.CANCELLED);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1396, 55, false);
#line 47 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(ISSSC.Class.SSCISHtml.DisplayForBool(Model.IsCancelled));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 81, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1533, 45, false);
#line 51 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.CANCELLATION_COMMENT);

#line default
#line hidden
            EndContext();
            BeginContext(1578, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1660, 50, false);
#line 55 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CancelationComment));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 81, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1792, 32, false);
#line 59 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.SUBJECT);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1906, 56, false);
#line 63 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdSubjectNavigation.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 81, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2044, 30, false);
#line 67 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(SSCISResources.Resources.TUTOR);

#line default
#line hidden
            EndContext();
            BeginContext(2074, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2156, 55, false);
#line 71 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdTutorNavigation.Login));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 91, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                </dl>\r\n            </div>\r\n            <p>\r\n");
            EndContext();
#line 77 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                 if (Model.IsAccepted == true)
                {
                    

#line default
#line hidden
            BeginContext(2390, 120, false);
#line 79 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
               Write(Html.ActionLink(SSCISResources.Resources.GENERATE_FEEDBACK_LINK, "EventQR", "Feedbacks", new { id = Model.Id }, new { }));

#line default
#line hidden
            EndContext();
#line 79 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
                                                                                                                                             
    
                }

#line default
#line hidden
            BeginContext(2537, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2554, 55, false);
#line 82 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Events\Details.cshtml"
           Write(Html.ActionLink(SSCISResources.Resources.BACK, "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 112, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"col-sm-2 sidenav\">\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISSSC.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
