#pragma checksum "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Home\Unauthorized.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544633dbc8162cb5621821c63edad7a0c41996e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Unauthorized), @"mvc.1.0.view", @"/Views/Home/Unauthorized.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Unauthorized.cshtml", typeof(AspNetCore.Views_Home_Unauthorized))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544633dbc8162cb5621821c63edad7a0c41996e9", @"/Views/Home/Unauthorized.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Unauthorized : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Home\Unauthorized.cshtml"
  
    ViewBag.Title = "Nedostatečné oprávnění";

#line default
#line hidden
            BeginContext(56, 366, true);
            WriteLiteral(@"
    <div class=""row content"">
        <div class=""col-sm-2 sidenav"">
        </div>

        <div class=""col-sm-8 text-left"">
            <h2>Nedostatečné oprávnění</h2>
            <p>Pro přístup na požadovanou funkčnost nemáte dostatečná oprávnění.</p>

                <div class=""col-sm-2 sidenav"">
                </div>

        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
