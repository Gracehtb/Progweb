#pragma checksum "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948d6e1ecf4ad9244d2d1be5574ac4c722099083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artikel_Index), @"mvc.1.0.view", @"/Views/Artikel/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artikel/Index.cshtml", typeof(AspNetCore.Views_Artikel_Index))]
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
#line 1 "F:\SampleASPCoreMar2019-master\Views\_ViewImports.cshtml"
using SampleASPCore;

#line default
#line hidden
#line 2 "F:\SampleASPCoreMar2019-master\Views\_ViewImports.cshtml"
using SampleASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948d6e1ecf4ad9244d2d1be5574ac4c722099083", @"/Views/Artikel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26753fabc27feb7accb4d4ca79c9e9c5c3ddb510", @"/Views/_ViewImports.cshtml")]
    public class Views_Artikel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleASPCore.Models.Artikel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(84, 34, true);
            WriteLiteral("\r\n\r\n<h2>Daftar Artikel</h2><br/>\r\n");
            EndContext();
            BeginContext(118, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948d6e1ecf4ad9244d2d1be5574ac4c7220990835627", async() => {
                BeginContext(172, 11, true);
                WriteLiteral("Tambah Data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(187, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 11 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
 if(ViewData["pesan"]!=null){
    

#line default
#line hidden
            BeginContext(244, 27, false);
#line 12 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
Write(Html.Raw(ViewData["pesan"]));

#line default
#line hidden
            EndContext();
#line 12 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
                                
}

#line default
#line hidden
            BeginContext(276, 41, true);
            WriteLiteral("<br/><br/>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
            BeginContext(317, 588, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948d6e1ecf4ad9244d2d1be5574ac4c7220990837745", async() => {
                BeginContext(363, 535, true);
                WriteLiteral(@"
     <div class=""form-group"">
        <label>Masukan Keyword :</label>
        <input type=""radio"" name=""pilih"" value=""Berita"" class=""form-control"" />Berita &nbsp;
        <input type=""radio"" name=""pilih"" value=""Judul"" class=""form-control"" />Judul &nbsp;
        <input type=""radio"" name=""pilih"" value=""Penulis"" class=""form-control"" />Penulis &nbsp;
        <input type=""text"" name=""keyword"" class=""form-control"" placeholder=""masukan keyword"" />
     </div>
    <button type=""submit"" class=""btn btn-primary"">Search</button> 
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(905, 296, true);
            WriteLiteral(@"<br/><br/>

<table class=""table table-striped"">
    <tr>
        <th>ID Artikel</th>
        <th>ID Kategori</th>
        <th>Judul</th>
        <th>Berita</th>
        <th>Tanggal</th>
        <th>Gambar</th>
        <th>Username</th>
        <th></th>
        <th></th>
    </tr>
");
            EndContext();
#line 41 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
     foreach(var data in Model){

#line default
#line hidden
            BeginContext(1235, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1266, 14, false);
#line 43 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
           Write(data.ArtikelID);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1304, 15, false);
#line 44 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
           Write(data.KategoriID);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1343, 10, false);
#line 45 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
           Write(data.Judul);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1377, 11, false);
#line 46 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
           Write(data.Berita);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1412, 12, false);
#line 47 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
           Write(data.Tanggal);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 27, true);
            WriteLiteral("</td>\r\n            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1451, "\"", 1469, 1);
#line 48 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
WriteAttributeValue("", 1457, data.Gambar, 1457, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1470, 51, true);
            WriteLiteral(" width=\"50px\" height=\"50px\"></td>\r\n            <td>");
            EndContext();
            BeginContext(1522, 13, false);
#line 49 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
           Write(data.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1535, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1558, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948d6e1ecf4ad9244d2d1be5574ac4c72209908313032", async() => {
                BeginContext(1613, 25, true);
                WriteLiteral("\r\n                details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
                                          WriteLiteral(data.ArtikelID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1642, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1665, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948d6e1ecf4ad9244d2d1be5574ac4c72209908315393", async() => {
                BeginContext(1719, 6, true);
                WriteLiteral("delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
                                         WriteLiteral(data.ArtikelID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1729, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 54 "F:\SampleASPCoreMar2019-master\Views\Artikel\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1758, 20, true);
            WriteLiteral("</table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleASPCore.Models.Artikel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
