#pragma checksum "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "294ff72fea00f8659988162ebfe65fadce04d563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294ff72fea00f8659988162ebfe65fadce04d563", @"/Areas/Admin/Views/Category/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Listesi</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Pasif Yapı</th>\r\n        <th>Aktif Yapı</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Pasif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-warning\">Aktif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-primary\">Yeni Kategori</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 34 "C:\Users\ahmet\OneDrive\Masaüstü\Codes\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index",new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591