#pragma checksum "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8b959c50b8151c2adeca033534b4cfc326cf58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TutorApplications_Index), @"mvc.1.0.view", @"/Views/TutorApplications/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TutorApplications/Index.cshtml", typeof(AspNetCore.Views_TutorApplications_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8b959c50b8151c2adeca033534b4cfc326cf58", @"/Views/TutorApplications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_TutorApplications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ISSSC.Models.TutorApplication>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
  
    ViewBag.Title = SSCISResources.Resources.TUTOR_APPLICATIONS;
    ViewBag.ActiveMenuItem = "menu-tutors";

#line default
#line hidden
            BeginContext(171, 151, true);
            WriteLiteral("\r\n\r\n    <div class=\"row content\">\r\n        <div class=\"col-sm-2 sidenav\">\r\n        </div>\r\n\r\n        <div class=\"col-sm-8 text-left\">\r\n            <h1>");
            EndContext();
            BeginContext(323, 43, false);
#line 14 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
           Write(SSCISResources.Resources.TUTOR_APPLICATIONS);

#line default
#line hidden
            EndContext();
            BeginContext(366, 345, true);
            WriteLiteral(@"</h1>

            <p>
            </p>
            <table class=""table"">
                <tr>
                    <th>
                        Datum přihlášky
                    </th>
                    <th>
                        Login uživatele
                    </th>
                    <th></th>
                </tr>

");
            EndContext();
#line 29 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(776, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(861, 50, false);
#line 33 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ApplicationDate));

#line default
#line hidden
            EndContext();
            BeginContext(911, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1003, 57, false);
#line 36 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdUserNavigation.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1152, 81, false);
#line 39 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
                       Write(Html.ActionLink(SSCISResources.Resources.DETAIL, "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 42 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\TutorApplications\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1312, 108, true);
            WriteLiteral("\r\n            </table>\r\n        </div>\r\n        <div class=\"col-sm-2 sidenav\">\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ISSSC.Models.TutorApplication>> Html { get; private set; }
    }
}
#pragma warning restore 1591
