#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a927972ac914a35c009553c2acd96febc99e86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_GetItemsInTheShowcaseWithImage), @"mvc.1.0.view", @"/Views/Item/GetItemsInTheShowcaseWithImage.cshtml")]
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
#nullable restore
#line 5 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.ItemDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.CommentDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a927972ac914a35c009553c2acd96febc99e86", @"/Views/Item/GetItemsInTheShowcaseWithImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f9d0c9056c8e79ac82662b6b185e88cde54e11", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Item_GetItemsInTheShowcaseWithImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Item>>
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
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
  
    ViewData["Title"] = "GetItemsInTheShowcaseWithImage";
    Layout = "~/Views/Shared/_ECommerceLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- //tittle heading -->
<div class=""row"">
	<!-- product left -->
	<!--bu kapatılanlarda değişen içerik-->
	<div class=""agileinfo-ads-display col-lg-9"">
		<div class=""wrapper"">
			<!-- first section -->
			<div class=""product-sec1 px-sm-4 px-3 py-sm-5  py-3 mb-4"">
				<h3 class=""heading-tittle text-center font-italic"">Aktif İlanlar</h3>
				<div class=""row"">
");
#nullable restore
#line 17 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-md-4 product-men mt-5\">\r\n\t\t\t\t\t\t\t<div class=\"men-pro-item simpleCart_shelfItem\">\r\n\t\t\t\t\t\t\t\t<div class=\"men-thumb-item text-center\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 716, "\"", 745, 1);
#nullable restore
#line 21 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
WriteAttributeValue("", 722, item.ItemShowcaseImage, 722, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 746, "\"", 766, 1);
#nullable restore
#line 21 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
WriteAttributeValue("", 752, item.ItemName, 752, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:200px;height:200px;"">
									<div class=""men-cart-pro"">
										<div class=""inner-men-cart-pro"">
											<a href=""single.html"" class=""link-product-add-cart"">Hemen İncele!</a>
										</div>
									</div>
								</div>
								<div class=""item-info-product text-center border-top mt-4"">
									<h4 class=""pt-1"">
										<a href=""single.html"">");
#nullable restore
#line 30 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
                                                         Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t\t\t\t\t<div class=\"info-product-price my-2\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"item_price\">");
#nullable restore
#line 33 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
                                                            Write(item.ItemDetail.ItemNewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t<del>");
#nullable restore
#line 34 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
                                        Write(item.ItemDetail.ItemOldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"snipcart-details top_brand_home_details item_add single-item hvr-outline-out\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9a927972ac914a35c009553c2acd96febc99e868452", async() => {
                WriteLiteral(@"
											<fieldset>
												<input type=""hidden"" name=""cmd"" value=""_cart"" />
												<input type=""hidden"" name=""add"" value=""1"" />
												<input type=""hidden"" name=""business"" value="" "" />
												<input type=""hidden"" name=""item_name"" value=""Samsung Galaxy J7"" />
												<input type=""hidden"" name=""amount"" value=""200.00"" />
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"

					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<!-- //first section -->\r\n\t\t\t<!-- second section -->\r\n\t\t\t");
#nullable restore
#line 63 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
       Write(await Component.InvokeAsync("_MostLikedItemsPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
			<!-- //second section -->
			<!-- third section -->
			<div class=""product-sec1 product-sec2 px-sm-5 px-3"">
				<div class=""row"">
					<h3 class=""col-md-4 effect-bg"">Fırsat Ürünleri</h3>
					<p class=""w3l-nut-middle"">Ekstra %10 indirim daha alın!</p>
					<div class=""col-md-8 bg-right-nut"">
						<img src=""images/image1.png""");
            BeginWriteAttribute("alt", " alt=\"", 2832, "\"", 2838, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<!-- //third section -->\r\n\t\t\t<!-- fourth section -->\r\n\t\t\t");
#nullable restore
#line 77 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
       Write(await Component.InvokeAsync("_MostDiscountedItemsPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<!-- //fourth section -->\r\n\t\t</div>\r\n\t</div>\r\n\t<!-- //product left -->\r\n\t<!-- product right -->\r\n\t");
#nullable restore
#line 83 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemsInTheShowcaseWithImage.cshtml"
Write(await Component.InvokeAsync("_ShowcaseSearchWithFilterPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
