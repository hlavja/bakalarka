#pragma checksum "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33b9dada801a4ec1f264823eff08a4620464aab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33b9dada801a4ec1f264823eff08a4620464aab", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbef95dca45eb325a7cf0be8b91e8c5908baa71d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\School\Bakalarka\Bakalářka final\Projekt ISSSC\ISSSC\ISSSC\Views\Home\Contact.cshtml"
  
    ViewBag.ActiveMenuItem = "menu-contact";

#line default
#line hidden
            BeginContext(53, 1411, true);
            WriteLiteral(@"<div class=""body-content container-fluid text-center"">
    <div class=""row content"">
        <div class=""col-sm-2 sidenav"">
        </div>

        <div class=""col-sm-8 text-left"">
            <h1>Kontakt</h1>
            <hr />
            <p>
                <strong>Máte dotazy? Kontaktujte nás:</strong>
                <br />
                <br />
                KMA: Světlana Tomiczková, <a href=""mailto:svetlana@kma.zcu.cz"">svetlana@kma.zcu.cz</a>
                <br />
                <br />
                KIV: Libor Váša, <a href=""mailto:lvasa@kiv.zcu.cz"">lvasa@kiv.zcu.cz</a>
            </p>
            <div class=""well"">
                <div id=""map"" style=""width:100%;height:400px;""></div>
            </div>
            <hr>
        </div>


        <script>
            function myMap() {
                var mapCanvas = document.getElementById(""map"");
                var mapOptions = {
                    center: new google.maps.LatLng(49.726903, 13.352262), zoom: 17
   ");
            WriteLiteral(@"             };
                var map = new google.maps.Map(mapCanvas, mapOptions);
            }
        </script>
        
        <!--<script src=""https://maps.googleapis.com/maps/api/js?key="" +ViewBag.MapToken + ""&callback=myMap""></script>-->
        <script src=ViewBag.MapToken></script>

        <div class=""col-sm-2 sidenav"">
        </div>

    </div>
</div>


");
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
