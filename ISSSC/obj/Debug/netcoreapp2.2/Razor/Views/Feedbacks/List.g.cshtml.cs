#pragma checksum "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "208d5a49aded668f3655ca80a01f04d1f4e97840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_List), @"mvc.1.0.view", @"/Views/Feedbacks/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/List.cshtml", typeof(AspNetCore.Views_Feedbacks_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"208d5a49aded668f3655ca80a01f04d1f4e97840", @"/Views/Feedbacks/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISSSC.Models.Meta.Statistics>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
  
    ViewBag.Title = "Feedback";
    ViewBag.ActiveMenuItem = "menu-statistics";

#line default
#line hidden
            BeginContext(128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
  
    ViewBag.Title = "Feedback";

#line default
#line hidden
            BeginContext(170, 390, true);
            WriteLiteral(@"<div class=""body-content container-fluid text-center"">
    <div class=""row content"">
        <div class=""col-sm-2 sidenav"">
        </div>
        <div class=""col-sm-8 text-left"">
            <h2>Statistiky</h2>
            <table class=""table"">
                <tr>
                    <th>
                        
                    <th>
                        Počet hodin: ");
            EndContext();
            BeginContext(561, 39, false);
#line 22 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                                Write(Html.DisplayFor(model => model.Lessons));

#line default
#line hidden
            EndContext();
            BeginContext(600, 85, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        MATH: ");
            EndContext();
            BeginContext(686, 43, false);
#line 25 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                         Write(Html.DisplayFor(model => model.MathLessons));

#line default
#line hidden
            EndContext();
            BeginContext(729, 84, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        INF: ");
            EndContext();
            BeginContext(814, 42, false);
#line 28 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                        Write(Html.DisplayFor(model => model.InfLessons));

#line default
#line hidden
            EndContext();
            BeginContext(856, 102, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-5\">\r\n                        MECH: ");
            EndContext();
            BeginContext(959, 43, false);
#line 31 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                         Write(Html.DisplayFor(model => model.MechLessons));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Odučené hodiny: ");
            EndContext();
            BeginContext(1098, 44, false);
#line 34 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                                   Write(Html.DisplayFor(model => model.LessonsHours));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 85, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        MATH: ");
            EndContext();
            BeginContext(1228, 48, false);
#line 37 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                         Write(Html.DisplayFor(model => model.MathLessonsHours));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 84, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        INF: ");
            EndContext();
            BeginContext(1361, 47, false);
#line 40 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                        Write(Html.DisplayFor(model => model.InfLessonsHours));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 85, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        MECH: ");
            EndContext();
            BeginContext(1494, 48, false);
#line 43 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                         Write(Html.DisplayFor(model => model.MechLessonsHours));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 616, true);
            WriteLiteral(@"
                    </th>
                    </th>
                </tr>
            </table>

            <table class=""table"">
                <tr>
                    <th>
                        Hodina
                    </th>
                    <th>
                        Čas od
                    </th>
                    <th>
                        Čas do
                    </th>
                    <th>
                        Počet feedbacků
                    </th>
                    <th>
                        Tutor
                    </th>
                </tr>
");
            EndContext();
#line 67 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                 if(Model.Event != null) { 
                

#line default
#line hidden
#line 68 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                 foreach (var item in Model.Event)
                {

#line default
#line hidden
            BeginContext(2274, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2359, 59, false);
#line 72 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdSubjectNavigation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2510, 43, false);
#line 75 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeFrom));

#line default
#line hidden
            EndContext();
            BeginContext(2553, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2645, 41, false);
#line 78 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeTo));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2778, 79, false);
#line 81 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                       Write(Html.ActionLink(item.FeedbacksCount.ToString(), "Detail", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2857, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2949, 58, false);
#line 84 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdTutorNavigation.Login));

#line default
#line hidden
            EndContext();
            BeginContext(3007, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 87 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                }

#line default
#line hidden
#line 87 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Feedbacks\List.cshtml"
                 
                }

#line default
#line hidden
            BeginContext(3105, 116, true);
            WriteLiteral("\r\n            </table>\r\n        </div>\r\n        <div class=\"col-sm-2 sidenav\">\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISSSC.Models.Meta.Statistics> Html { get; private set; }
    }
}
#pragma warning restore 1591
