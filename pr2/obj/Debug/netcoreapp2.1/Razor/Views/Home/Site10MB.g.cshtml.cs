#pragma checksum "D:\Polibuda\Magisterka\Semestr II\OESK\pr2\Views\Home\Site10MB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cffa084f2d3ef2ffcf4f43d6625ad9bbcc198649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Site10MB), @"mvc.1.0.view", @"/Views/Home/Site10MB.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Site10MB.cshtml", typeof(AspNetCore.Views_Home_Site10MB))]
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
#line 1 "D:\Polibuda\Magisterka\Semestr II\OESK\pr2\Views\_ViewImports.cshtml"
using pr2;

#line default
#line hidden
#line 2 "D:\Polibuda\Magisterka\Semestr II\OESK\pr2\Views\_ViewImports.cshtml"
using pr2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffa084f2d3ef2ffcf4f43d6625ad9bbcc198649", @"/Views/Home/Site10MB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21828eeb29538f485bc186d44d18c3b23e99f878", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Site10MB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 61, true);
            WriteLiteral("\r\n    <div><img src=\"images/100MB.jpg\"/></div>\r\n    <div><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 61, "\"", 85, 1);
#line 3 "D:\Polibuda\Magisterka\Semestr II\OESK\pr2\Views\Home\Site10MB.cshtml"
WriteAttributeValue("", 67, ViewBag.ImageData, 67, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(86, 8, true);
            WriteLiteral("/></div>");
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
