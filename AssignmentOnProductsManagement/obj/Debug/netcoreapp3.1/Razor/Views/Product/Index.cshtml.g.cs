#pragma checksum "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01b4fa4e6a5227379e01541331516d2b8faebbda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\_ViewImports.cshtml"
using AssignmentOnProductsManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\_ViewImports.cshtml"
using AssignmentOnProductsManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b4fa4e6a5227379e01541331516d2b8faebbda", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e92c6b1f8308de4c70c8fd8816ea9383c1f6c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AssignmentOnProductsManagement.Models.Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<a href=""Product/Create"" >Create</a>
<div class=""container"">
    <table class=""table table-bordered"">
        <tr>
            <th>ID</th>
            <th>Product Name</th>
            <th>Product Price</th>
            <th>Stock</th>
        </tr>
");
#nullable restore
#line 16 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml"
               Write(item.Pid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml"
               Write(item.Pname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\HP\source\repos\AssignmentOnProductsManagement\AssignmentOnProductsManagement\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AssignmentOnProductsManagement.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
