#pragma checksum "C:\Users\Usuario\Documents\Unitech_Seletivo\Unitech_Seletivo\Unitech\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b17a9689313121b1dd4338290de8c1eece48c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\Documents\Unitech_Seletivo\Unitech_Seletivo\Unitech\Views\_ViewImports.cshtml"
using Unitech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Documents\Unitech_Seletivo\Unitech_Seletivo\Unitech\Views\_ViewImports.cshtml"
using Unitech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b17a9689313121b1dd4338290de8c1eece48c4e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1062b317acb0af01b94fcad0db04aff2f8b2eea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Usuario\Documents\Unitech_Seletivo\Unitech_Seletivo\Unitech\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Unitech.Infra.OngRepository ongPartial = new Unitech.Infra.OngRepository();
    //Unitech.Infra.PessoaRepository pessoaPartial = new Unitech.Infra.PessoaRepository();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin: 5px; align-items: center\"><p>");
#nullable restore
#line 9 "C:\Users\Usuario\Documents\Unitech_Seletivo\Unitech_Seletivo\Unitech\Views\Home\Index.cshtml"
                                            Write(Html.Partial("ongPartial.cshtml", ongPartial.ListarOng()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n<!-- <div float: left; width: 50%;><p>Html.Partial(\"pessoaPartial.cshtml\", pessoaPartial.ListarPessoa())</p></divfloat:> -->\r\n");
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
