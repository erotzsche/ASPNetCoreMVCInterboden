#pragma checksum "F:\ASPNetMVCAppInterboden\ASPNetMVCAppInterboden\Views\Wohnungen\_NeuesteWohnung.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e505956a2d260b47d62fa868588c27cbd919e784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wohnungen__NeuesteWohnung), @"mvc.1.0.view", @"/Views/Wohnungen/_NeuesteWohnung.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wohnungen/_NeuesteWohnung.cshtml", typeof(AspNetCore.Views_Wohnungen__NeuesteWohnung))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e505956a2d260b47d62fa868588c27cbd919e784", @"/Views/Wohnungen/_NeuesteWohnung.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Wohnungen__NeuesteWohnung : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNetMVCAppInterboden.Model.Wohnung>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(165, 26, true);
            WriteLiteral("\r\n<div class=\"col-sm-6\">\r\n");
            EndContext();
#line 6 "F:\ASPNetMVCAppInterboden\ASPNetMVCAppInterboden\Views\Wohnungen\_NeuesteWohnung.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(223, 165, true);
            WriteLiteral("        <div class=\"card \">\r\n            <div class=\"card-header\">Neueste Wohnung</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(389, 18, false);
#line 11 "F:\ASPNetMVCAppInterboden\ASPNetMVCAppInterboden\Views\Wohnungen\_NeuesteWohnung.cshtml"
                                  Write(Model.Beschreibung);

#line default
#line hidden
            EndContext();
            BeginContext(407, 43, true);
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 14 "F:\ASPNetMVCAppInterboden\ASPNetMVCAppInterboden\Views\Wohnungen\_NeuesteWohnung.cshtml"
    }

#line default
#line hidden
            BeginContext(457, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNetMVCAppInterboden.Model.Wohnung> Html { get; private set; }
    }
}
#pragma warning restore 1591
