#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68dcd2c6b07bda18ff5cd38407f4f9e1fd7e34f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__MostLikedItemsPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_MostLikedItemsPage/Default.cshtml")]
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
#line 4 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68dcd2c6b07bda18ff5cd38407f4f9e1fd7e34f5", @"/Views/Shared/Components/_MostLikedItemsPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d9d7a47dd5532529991275d7b640be551b5c0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__MostLikedItemsPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemRatingsSpModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"product-sec1 px-sm-4 px-3 py-sm-5  py-3 mb-4\">\r\n\t<h3 class=\"heading-tittle text-center font-italic\">Kategorilere Göre Beğenisi En Yüksek Olan İlanlar</h3>\r\n\t<div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-md-4 product-men mt-5\">\r\n\t\t\t<div class=\"men-pro-item simpleCart_shelfItem\">\r\n\t\t\t\t<div class=\"men-thumb-item text-center\">\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 405, "\"", 434, 1);
#nullable restore
#line 9 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"
WriteAttributeValue("", 411, item.ItemShowcaseImage, 411, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 435, "\"", 455, 1);
#nullable restore
#line 9 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"
WriteAttributeValue("", 441, item.ItemName, 441, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:200px;height:200px;"">
					<div class=""men-cart-pro"">
						<div class=""inner-men-cart-pro"">
							<a href=""single.html"" class=""link-product-add-cart"">Quick View</a>
						</div>
					</div>
				</div>
				<div class=""item-info-product text-center border-top mt-4"">
					<h4 class=""pt-1"">
						<a href=""single.html"">");
#nullable restore
#line 18 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"
                                         Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t</h4>\r\n\t\t\t\t\t<div class=\"info-product-price my-2\">\r\n\t\t\t\t\t\t<span class=\"item_price\">Kategori : ");
#nullable restore
#line 21 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"
                                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"info-product-price my-2\">\r\n\t\t\t\t\t\t\t<span class=\"item_price\">Beğeni Sayısı : ");
#nullable restore
#line 25 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"
                                                                Write(item.ItemTotalRatingScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"snipcart-details top_brand_home_details item_add single-item hvr-outline-out\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68dcd2c6b07bda18ff5cd38407f4f9e1fd7e34f57629", async() => {
                WriteLiteral(@"
							<fieldset>
								<input type=""hidden"" name=""cmd"" value=""_cart"" />
								<input type=""hidden"" name=""add"" value=""1"" />
								<input type=""hidden"" name=""business"" value="" "" />
								<input type=""hidden"" name=""item_name"" value=""Sony 80 cm (32 inches)"" />
								<input type=""hidden"" name=""amount"" value=""320.00"" />
								<input type=""hidden"" name=""discount_amount"" value=""1.00"" />
								<input type=""hidden"" name=""currency_code"" value=""USD"" />
								<input type=""hidden"" name=""return"" value="" "" />
								<input type=""hidden"" name=""cancel_return"" value="" "" />
								<input type=""submit"" name=""submit"" value=""Add to cart"" class=""button btn"" />
							</fieldset>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_MostLikedItemsPage\Default.cshtml"

		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t\t\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemRatingsSpModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
