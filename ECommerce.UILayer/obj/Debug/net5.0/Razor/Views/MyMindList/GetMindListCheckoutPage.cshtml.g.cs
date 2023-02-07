#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f4b3bc6af82b13fb10f3cbc221b307f79a72d3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyMindList_GetMindListCheckoutPage), @"mvc.1.0.view", @"/Views/MyMindList/GetMindListCheckoutPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f4b3bc6af82b13fb10f3cbc221b307f79a72d3e", @"/Views/MyMindList/GetMindListCheckoutPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b71c6bdc6240e3aa17c9e8851f19d6f788913a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MyMindList_GetMindListCheckoutPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MindListDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
  
    ViewData["Title"] = "GetMindListCheckoutPage";
    Layout = "~/Views/Shared/_UserLayout.cshtml";
	List<SubCategoryDTO> subCategoryList = new List<SubCategoryDTO>();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"">
	
	<!-- //page -->
	<!-- checkout page -->
	<div class=""privacy py-sm-5 py-4"">
		<div class=""container py-xl-4 py-lg-2"">
			<!-- tittle heading -->
			<h3 class=""tittle-w3l text-center mb-lg-5 mb-sm-4 mb-3"">
			<span>Aklımdakiler Listesi</span>
			</h3>
			<!-- //tittle heading -->
			<div class=""checkout-right"">
				<h4 class=""mb-sm-4 mb-3"">Senin Aklımdakiler Listendeki İlan Sayısı:
				<span>");
#nullable restore
#line 20 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                 Write(ViewBag.itemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ilan</span>
				</h4>
				<div class=""table-responsive"">
					<table class=""timetable_sub"">
						<thead>
							<tr>
								<th>İlan No</th>
								<th>Ürün</th>
						
								<th>Ürün Adı</th>

								<th>Ürün Fiyatı</th>
								<th>Kirala/Satın Al</th>
						
								<th>Kaldır</th>
							</tr>
						</thead>
						<tbody>
");
#nullable restore
#line 38 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                             foreach(var item in Model)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<tr class=\"rem1\">\r\n\t\t\t\t\t\t\t\t\t<td class=\"invert\">");
#nullable restore
#line 41 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                                                  Write(item.Item.ItemDetail.ItemNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t<td class=\"invert-image\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1324, "\"", 1358, 1);
#nullable restore
#line 45 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
WriteAttributeValue("", 1330, item.Item.ItemShowcaseImage, 1330, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1359, "\"", 1384, 1);
#nullable restore
#line 45 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
WriteAttributeValue("", 1365, item.Item.ItemName, 1365, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\">\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 48 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                                  
									SubCategoryDTO subCategory = new SubCategoryDTO();
									subCategory.SubCategoryID = item.Item.SubCategoryID;
									if (!subCategoryList.Any(x => x.SubCategoryID == subCategory.SubCategoryID)){
										subCategoryList.Add(subCategory);
									}

									
								

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td class=\"invert\">");
#nullable restore
#line 57 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                                                  Write(item.Item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"invert\">");
#nullable restore
#line 58 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                                              Write(item.Item.ItemDetail.ItemNewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n");
#nullable restore
#line 59 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
                                 if(item.Item.ItemDetail.ItemAdType == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td class=\"invert\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"rem\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1996, "\"", 2003, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\"><i class=\"bi bi-chat-square-dots-fill\" style=\"color:white;\"></i>Kirala</a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 65 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"

								}
								else{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td class=\"invert\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"rem\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2236, "\"", 2243, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\"><i class=\"bi bi-bag-fill\"></i> Satın Al</a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 73 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"

								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t\t<td class=\"invert\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"rem\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2453, "\"", 2460, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"bi bi-backspace-fill\" style=\"color:white;\"></i></a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 85 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
							

							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 97 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\MyMindList\GetMindListCheckoutPage.cshtml"
Write(await Component.InvokeAsync("_GetAdsBySameCategoriesItems",new{subCategoryDTO=subCategoryList}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MindListDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
