#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3229b22e550b87480827317642330d97a32fc8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CategoriesNavbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CategoriesNavbar/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.UILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.UILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.ItemDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.CommentDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.MindListDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.SubCategoryDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.ItemDetailDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DataAccessLayer.CQRS.Results.ItemAdsResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.ItemOwnerDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.CompanySellerDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3229b22e550b87480827317642330d97a32fc8e6", @"/Views/Shared/Components/_CategoriesNavbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e632b250ec3efda3e08f0bfe50475d93bb75fc69", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__CategoriesNavbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubCategory>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
  
	int count = 0;
	List<String> list = new List<String>();

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<li class=\"nav-item dropdown mr-lg-2 mb-lg-0 mb-2\">\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
         if (list.Contains(item.Category.CategoryName.ToString()) == false)
		{
			list.Add(item.Category.CategoryName)
			;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<a class=\"nav-link dropdown-toggle\" href=\"#\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" style=\"font-weight:bold\">\r\n\t\t\t\t\r\n\t\t\t\t");
#nullable restore
#line 14 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</a>\r\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\r\n\t\t<div class=\"dropdown-menu\">\r\n\t\t\t<div class=\"agile_inner_drop_nav_info p-4\">\r\n\t\t\t\t<h5 class=\"mb-3\">Mobiles, Computers</h5>\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-sm-6 multi-gd-img\">\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<ul class=\"multi-column-dropdown\">\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
                             foreach(var subCategory in Model){
								
								if(subCategory.CategoryID==item.CategoryID){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<!--gezindiği kategori id\'si o alt kategorinin id\'si ile aynı ise yazdır-->\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"product.html\">");
#nullable restore
#line 31 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
                                                          Write(subCategory.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"
									

								}
							

							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t</div>\r\n\t\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</li>\r\n");
#nullable restore
#line 48 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_CategoriesNavbar\Default.cshtml"

}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
