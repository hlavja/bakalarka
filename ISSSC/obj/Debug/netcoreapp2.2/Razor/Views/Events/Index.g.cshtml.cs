#pragma checksum "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37dc7edc42484ff1bf36ccbfb11749fb567f04b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Index.cshtml", typeof(AspNetCore.Views_Events_Index))]
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
#line 1 "D:\Skola\bakalarka\ISSSC\Views\_ViewImports.cshtml"
using ISSSC;

#line default
#line hidden
#line 2 "D:\Skola\bakalarka\ISSSC\Views\_ViewImports.cshtml"
using ISSSC.Models;

#line default
#line hidden
#line 2 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
using ISSSC.Class;

#line default
#line hidden
#line 3 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37dc7edc42484ff1bf36ccbfb11749fb567f04b4", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ISSSC.Models.Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
  
    ViewBag.Title = SSCISResources.Resources.EVENTS;
    ViewBag.ActiveMenuItem = "menu-eventlist";

#line default
#line hidden
            BeginContext(205, 205, true);
            WriteLiteral("\r\n<div class=\"body-content container-fluid text-center\">\r\n    <div class=\"row content\">\r\n        <div class=\"col-sm-2 sidenav\">\r\n        </div>\r\n\r\n        <div class=\"col-sm-8 text-left\">\r\n            <h2>");
            EndContext();
            BeginContext(411, 31, false);
#line 16 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
           Write(SSCISResources.Resources.EVENTS);

#line default
#line hidden
            EndContext();
            BeginContext(442, 42, true);
            WriteLiteral("</h2>\r\n\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(485, 64, false);
#line 19 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
           Write(Html.ActionLink(SSCISResources.Resources.CREATE_EVENT, "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(549, 144, true);
            WriteLiteral("\r\n            </p>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th class=\"col-md-2\">\r\n                        ");
            EndContext();
            BeginContext(694, 34, false);
#line 24 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.TIME_FROM);

#line default
#line hidden
            EndContext();
            BeginContext(728, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-2\">\r\n                        ");
            EndContext();
            BeginContext(825, 32, false);
#line 27 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.TIME_TO);

#line default
#line hidden
            EndContext();
            BeginContext(857, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-1\">\r\n                        ");
            EndContext();
            BeginContext(954, 33, false);
#line 30 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.ACCEPTED);

#line default
#line hidden
            EndContext();
            BeginContext(987, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-1\">\r\n                        ");
            EndContext();
            BeginContext(1084, 34, false);
#line 33 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.CANCELLED);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-4\">\r\n                        ");
            EndContext();
            BeginContext(1215, 45, false);
#line 36 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.CANCELLATION_COMMENT);

#line default
#line hidden
            EndContext();
            BeginContext(1260, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1340, 32, false);
#line 39 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.SUBJECT);

#line default
#line hidden
            EndContext();
            BeginContext(1372, 80, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th >\r\n                        ");
            EndContext();
            BeginContext(1453, 30, false);
#line 42 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.TUTOR);

#line default
#line hidden
            EndContext();
            BeginContext(1483, 102, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-2\"></th>\r\n                </tr>\r\n\r\n");
            EndContext();
#line 47 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                 foreach (var item in Model)
                {
                    if (item.IdTutorNavigation != null)
                    {

#line default
#line hidden
            BeginContext(1730, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1827, 43, false);
#line 53 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TimeFrom));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1974, 41, false);
#line 56 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TimeTo));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2119, 41, false);
#line 59 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(SSCISHtml.DisplayForBool(item.IsAccepted));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2264, 42, false);
#line 62 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(SSCISHtml.DisplayForBool(item.IsCancelled));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2410, 53, false);
#line 65 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CancelationComment));

#line default
#line hidden
            EndContext();
            BeginContext(2463, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2567, 59, false);
#line 68 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdSubjectNavigation.Code));

#line default
#line hidden
            EndContext();
            BeginContext(2626, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2730, 58, false);
#line 71 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdTutorNavigation.Login));

#line default
#line hidden
            EndContext();
            BeginContext(2788, 105, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                \r\n");
            EndContext();
#line 75 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                  if (ViewContext.HttpContext.Session.GetString("role") != null && ViewContext.HttpContext.Session.GetString("role").Equals(ISSSC.Class.AuthorizationRoles.Administrator))
                                    {
                                            

#line default
#line hidden
#line 77 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                             if (item.IsAccepted == null || !item.IsAccepted.Value)
                                            {
                                                

#line default
#line hidden
            BeginContext(3333, 80, false);
#line 79 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                           Write(Html.ActionLink(SSCISResources.Resources.ACCEPT, "Accept", new { id = item.Id }));

#line default
#line hidden
            EndContext();
#line 79 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                                                                                                                 
                                               
                                            }  
                                             else if (item.IsCancelled == null || !item.IsCancelled.Value)
                                            {
                                                

#line default
#line hidden
            BeginContext(3717, 80, false);
#line 84 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                           Write(Html.ActionLink(SSCISResources.Resources.CANCEL, "Cancel", new { id = item.Id }));

#line default
#line hidden
            EndContext();
#line 84 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                                                                                                                 
                                            }

#line default
#line hidden
#line 85 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                               
                                        
                                    }
                                

#line default
#line hidden
            BeginContext(3964, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3997, 81, false);
#line 89 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.ActionLink(SSCISResources.Resources.DETAIL, "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(4078, 102, true);
            WriteLiteral("\r\n                                \r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 93 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4222, 201, true);
            WriteLiteral("\r\n            </table>\r\n\r\n   \r\n            <h2>Žádosti o extra lekce</h2>\r\n\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th class=\"col-md-2\">\r\n                        ");
            EndContext();
            BeginContext(4424, 34, false);
#line 104 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.TIME_FROM);

#line default
#line hidden
            EndContext();
            BeginContext(4458, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-2\">\r\n                        ");
            EndContext();
            BeginContext(4555, 32, false);
#line 107 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.TIME_TO);

#line default
#line hidden
            EndContext();
            BeginContext(4587, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-1\">\r\n                        ");
            EndContext();
            BeginContext(4684, 33, false);
#line 110 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.ACCEPTED);

#line default
#line hidden
            EndContext();
            BeginContext(4717, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-1\">\r\n                        ");
            EndContext();
            BeginContext(4814, 34, false);
#line 113 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.CANCELLED);

#line default
#line hidden
            EndContext();
            BeginContext(4848, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-4\">\r\n                        ");
            EndContext();
            BeginContext(4945, 45, false);
#line 116 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.CANCELLATION_COMMENT);

#line default
#line hidden
            EndContext();
            BeginContext(4990, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(5070, 32, false);
#line 119 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.SUBJECT);

#line default
#line hidden
            EndContext();
            BeginContext(5102, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(5182, 34, false);
#line 122 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                   Write(SSCISResources.Resources.APPLICANT);

#line default
#line hidden
            EndContext();
            BeginContext(5216, 102, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-md-2\"></th>\r\n                </tr>\r\n\r\n");
            EndContext();
#line 127 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                 foreach (var item in Model)
                {
                    if (item.IsExtraLesson == true && item.IdTutorNavigation == null)
                    {

#line default
#line hidden
            BeginContext(5493, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5590, 43, false);
#line 133 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TimeFrom));

#line default
#line hidden
            EndContext();
            BeginContext(5633, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5737, 41, false);
#line 136 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TimeTo));

#line default
#line hidden
            EndContext();
            BeginContext(5778, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5882, 41, false);
#line 139 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(SSCISHtml.DisplayForBool(item.IsAccepted));

#line default
#line hidden
            EndContext();
            BeginContext(5923, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(6027, 42, false);
#line 142 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(SSCISHtml.DisplayForBool(item.IsCancelled));

#line default
#line hidden
            EndContext();
            BeginContext(6069, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(6173, 53, false);
#line 145 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CancelationComment));

#line default
#line hidden
            EndContext();
            BeginContext(6226, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(6330, 59, false);
#line 148 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdSubjectNavigation.Code));

#line default
#line hidden
            EndContext();
            BeginContext(6389, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(6493, 62, false);
#line 151 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdApplicantNavigation.Login));

#line default
#line hidden
            EndContext();
            BeginContext(6555, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 154 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                 if (ViewContext.HttpContext.Session.GetInt32("userId") != item.IdApplicant)
                                {

#line default
#line hidden
            BeginContext(6771, 35, true);
            WriteLiteral("                                <p>");
            EndContext();
            BeginContext(6807, 93, false);
#line 156 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                              Write(Html.ActionLink(SSCISResources.Resources.ACCEPT_LESSON, "AcceptLesson", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(6900, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 157 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6941, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 160 "D:\Skola\bakalarka\ISSSC\Views\Events\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(7049, 120, true);
            WriteLiteral("\r\n            </table>\r\n\r\n        </div>\r\n        <div class=\"col-sm-2 sidenav\">\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ISSSC.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
