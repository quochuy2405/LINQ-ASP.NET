#pragma checksum "C:\Users\BUIQUOCHUY\Desktop\THUC HANH C#\ThucHanhTuan5\Views\Home\Cau4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e96fd730f2dcc916cd3c52892c35da419bdde6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cau4), @"mvc.1.0.view", @"/Views/Home/Cau4.cshtml")]
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
#line 1 "C:\Users\BUIQUOCHUY\Desktop\THUC HANH C#\ThucHanhTuan5\Views\_ViewImports.cshtml"
using ThucHanhTuan5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BUIQUOCHUY\Desktop\THUC HANH C#\ThucHanhTuan5\Views\_ViewImports.cshtml"
using ThucHanhTuan5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e96fd730f2dcc916cd3c52892c35da419bdde6", @"/Views/Home/Cau4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e738210e24b03c5e92605f75dff5f3ff3f4e2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cau4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h2>Liệt kê các Product (ProductName) do CompanyName “Tokyo Traders” cung cấp</h2>\r\n    <table");
            BeginWriteAttribute("border", " border=\"", 249, "\"", 258, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n\r\n        <th>ProductName</th>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Users\BUIQUOCHUY\Desktop\THUC HANH C#\ThucHanhTuan5\Views\Home\Cau4.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\BUIQUOCHUY\Desktop\THUC HANH C#\ThucHanhTuan5\Views\Home\Cau4.cshtml"
               Write(item.GetType().GetProperty("ProductName").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "C:\Users\BUIQUOCHUY\Desktop\THUC HANH C#\ThucHanhTuan5\Views\Home\Cau4.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
