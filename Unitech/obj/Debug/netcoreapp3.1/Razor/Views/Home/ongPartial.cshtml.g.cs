#pragma checksum "C:\Users\elmir\source\repos\Unitech\Unitech\Views\Home\ongPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c797ed810b41cf066dd9990838a9b6be105a682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ongPartial), @"mvc.1.0.view", @"/Views/Home/ongPartial.cshtml")]
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
#line 1 "C:\Users\elmir\source\repos\Unitech\Unitech\Views\_ViewImports.cshtml"
using Unitech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elmir\source\repos\Unitech\Unitech\Views\_ViewImports.cshtml"
using Unitech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c797ed810b41cf066dd9990838a9b6be105a682", @"/Views/Home/ongPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1062b317acb0af01b94fcad0db04aff2f8b2eea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ongPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Unitech.Models.Ong>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\elmir\source\repos\Unitech\Unitech\Views\Home\ongPartial.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\elmir\source\repos\Unitech\Unitech\Views\Home\ongPartial.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "C:\Users\elmir\source\repos\Unitech\Unitech\Views\Home\ongPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\elmir\source\repos\Unitech\Unitech\Views\Home\ongPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Unitech.Models.Ong>> Html { get; private set; }
    }
}
#pragma warning restore 1591