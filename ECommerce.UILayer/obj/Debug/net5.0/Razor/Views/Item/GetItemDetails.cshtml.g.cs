#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c37c5006854737e134e7e8c406c850117f82f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_GetItemDetails), @"mvc.1.0.view", @"/Views/Item/GetItemDetails.cshtml")]
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
#nullable restore
#line 7 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.MindListDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.SubCategoryDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c37c5006854737e134e7e8c406c850117f82f10", @"/Views/Item/GetItemDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0be6af474dde7b81746053eb280837d6e2e5e24", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Item_GetItemDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/electro_store-web_Free28-08-2018_1414020280/images/si1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-imagezoom", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/electro_store-web_Free28-08-2018_1414020280/images/si2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/electro_store-web_Free28-08-2018_1414020280/images/si3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Item\GetItemDetails.cshtml"
  
    ViewData["Title"] = "GetItemDetails";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""banner-bootom-w3-agileits py-5"">
	<div class=""container py-xl-4 py-lg-2"">
		<!-- tittle heading -->
		<h3 class=""tittle-w3l text-center mb-lg-5 mb-sm-4 mb-3"">
			<span>S</span>ingle
			<span>P</span>age
		</h3>
		<!-- //tittle heading -->
		<div class=""row"">
			<div class=""col-lg-5 col-md-8 single-right-left "">
				<div class=""grid images_3_of_2"">
					<div class=""flexslider"">
						<ul class=""slides"">
							<li data-thumb=""~/electro_store-web_Free28-08-2018_1414020280/images/si1.jpg"">
								<div class=""thumb-image"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c37c5006854737e134e7e8c406c850117f82f108416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li data-thumb=\"~/electro_store-web_Free28-08-2018_1414020280/images/si2.jpg\">\r\n\t\t\t\t\t\t\t\t<div class=\"thumb-image\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c37c5006854737e134e7e8c406c850117f82f109908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li data-thumb=\"~/electro_store-web_Free28-08-2018_1414020280/images/si3.jpg\">\r\n\t\t\t\t\t\t\t\t<div class=\"thumb-image\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c37c5006854737e134e7e8c406c850117f82f1011400", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</div>
							</li>
						</ul>
						<div class=""clearfix""></div>
					</div>
				</div>
			</div>

			<div class=""col-lg-7 single-right-left simpleCart_shelfItem"">
				<h3 class=""mb-3"">Samsung Galaxy J7 Prime (Gold, 16 GB) (3 GB RAM)</h3>
				<p class=""mb-3"">
					<span class=""item_price"">$200.00</span>
					<del class=""mx-2 font-weight-light"">$280.00</del>
					<label>Free delivery</label>
				</p>
				<div class=""single-infoagile"">
					<ul>
						<li class=""mb-3"">
							Cash on Delivery Eligible.
						</li>
						<li class=""mb-3"">
							Shipping Speed to Delivery.
						</li>
						<li class=""mb-3"">
							EMIs from $655/month.
						</li>
						<li class=""mb-3"">
							Bank OfferExtra 5% off* with Axis Bank Buzz Credit CardT&C
						</li>
					</ul>
				</div>
				<div class=""product-single-w3l"">
					<p class=""my-3"">
						<i class=""far fa-hand-point-right mr-2""></i>
						<label>1 Year</label>Manufacturer Warranty
					</p>
					<ul>
						<li class=""m");
            WriteLiteral(@"b-1"">
							3 GB RAM | 16 GB ROM | Expandable Upto 256 GB
						</li>
						<li class=""mb-1"">
							5.5 inch Full HD Display
						</li>
						<li class=""mb-1"">
							13MP Rear Camera | 8MP Front Camera
						</li>
						<li class=""mb-1"">
							3300 mAh Battery
						</li>
						<li class=""mb-1"">
							Exynos 7870 Octa Core 1.6GHz Processor
						</li>
					</ul>
					<p class=""my-sm-4 my-3"">
						<i class=""fas fa-retweet mr-3""></i>Net banking & Credit/ Debit/ ATM card
					</p>
				</div>
				<div class=""occasion-cart"">
					<div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c37c5006854737e134e7e8c406c850117f82f1014437", async() => {
                WriteLiteral(@"
							<fieldset>
								<input type=""hidden"" name=""cmd"" value=""_cart"" />
								<input type=""hidden"" name=""add"" value=""1"" />
								<input type=""hidden"" name=""business"" value="" "" />
								<input type=""hidden"" name=""item_name"" value=""Samsung Galaxy J7 Prime"" />
								<input type=""hidden"" name=""amount"" value=""200.00"" />
								<input type=""hidden"" name=""discount_amount"" value=""1.00"" />
								<input type=""hidden"" name=""currency_code"" value=""USD"" />
								<input type=""hidden"" name=""return"" value="" "" />
								<input type=""hidden"" name=""cancel_return"" value="" "" />
								<input type=""submit"" name=""submit"" value=""Add to cart"" class=""button"" />
							</fieldset>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<div class=""bootstrap-tab animated wow slideInUp animated"" data-wow-delay="".5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: slideInUp;"">
	<div class=""bs-example bs-example-tabs"" role=""tabpanel"" data-example-id=""togglable-tabs"">
		<ul id=""myTab"" class=""nav nav-tabs"" role=""tablist"">
			<li role=""presentation"" class=""active""><a href=""#home"" id=""home-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""home"" aria-expanded=""true"">Description</a></li>
			<li role=""presentation""><a href=""#profile"" role=""tab"" id=""profile-tab"" data-toggle=""tab"" aria-controls=""profile"">Reviews(1)</a></li>
			<li role=""presentation"" class=""dropdown"">
				<a href=""#"" id=""myTabDrop1"" class=""dropdown-toggle"" data-toggle=""dropdown"" aria-controls=""myTabDrop1-contents"">Information <span class=""caret""></span></a>
				<ul class=""dropdown-menu"" role=""menu"" aria-labelledby=""myTabDrop1"" id=""myTabDrop1-contents"">
					<li><a href=""#dropdown1"" tabindex=""-1"" r");
            WriteLiteral(@"ole=""tab"" id=""dropdown1-tab"" data-toggle=""tab"" aria-controls=""dropdown1"">cleanse</a></li>
					<li><a href=""#dropdown2"" tabindex=""-1"" role=""tab"" id=""dropdown2-tab"" data-toggle=""tab"" aria-controls=""dropdown2"">fanny</a></li>
				</ul>
			</li>
		</ul>
		<div id=""myTabContent"" class=""tab-content"">
			<div role=""tabpanel"" class=""tab-pane fade in active bootstrap-tab-text"" id=""home"" aria-labelledby=""home-tab"">
				<h5>Product Brief Description</h5>
				<p>
					Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.
					<span>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occae");
            WriteLiteral(@"cat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</span>
				</p>
			</div>
			<div role=""tabpanel"" class=""tab-pane fade bootstrap-tab-text"" id=""profile"" aria-labelledby=""profile-tab"">
				<div class=""bootstrap-tab-text-grids"">
					<div class=""bootstrap-tab-text-grid"">
						<div class=""bootstrap-tab-text-grid-left"">
							<img src=""images/men3.jpg"" alt="" "" class=""img-responsive"">
						</div>
						<div class=""bootstrap-tab-text-grid-right"">
							<ul>
								<li><a href=""#"">Admin</a></li>
								<li><a href=""#""><span class=""glyphicon glyphicon-share"" aria-hidden=""true""></span>Reply</a></li>
							</ul>
							<p>
								Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis
								suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem
								vel eum iure reprehenderit.
							</p>
						</div>
						<div class=""clearfix""> </div>
					</div>

					<div class=""add-review"">
						<h4>add a review</h4>
	");
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c37c5006854737e134e7e8c406c850117f82f1020025", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input type=\"text\" value=\"Name\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Name\';}\"");
                BeginWriteAttribute("required", " required=\"", 6977, "\"", 6988, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t<input type=\"email\" value=\"Email\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Email\';}\"");
                BeginWriteAttribute("required", " required=\"", 7114, "\"", 7125, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t<textarea type=\"text\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Message...\';}\"");
                BeginWriteAttribute("required", " required=\"", 7246, "\"", 7257, 0);
                EndWriteAttribute();
                WriteLiteral(">Message...</textarea>\r\n\t\t\t\t\t\t\t<input type=\"submit\" value=\"SEND\">\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					</div>
				</div>
			</div>
			<div role=""tabpanel"" class=""tab-pane fade bootstrap-tab-text"" id=""dropdown1"" aria-labelledby=""dropdown1-tab"">
				<p>Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork. Williamsburg banh mi whatever gluten-free, carles pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester cred you probably haven't heard of them, vinyl craft beer blog stumptown. Pitchfork sustainable tofu synth chambray yr.</p>
			</div>
			<div role=""tabpanel"" class=""tab-pane fade bootstrap-tab-text"" id=""dropdown2"" aria-labelledby=""dropdown2-tab"">
				<p>Trust fund seitan letterpress, keytar raw denim keffiyeh etsy art party before they sold out master cleanse gluten-free squid scenester freegan cosby ");
            WriteLiteral(@"sweater. Fanny pack portland seitan DIY, art party locavore wolf cliche high life echo park Austin. Cred vinyl keffiyeh DIY salvia PBR, banh mi before they sold out farm-to-table VHS viral locavore cosby sweater. Lomo wolf viral, mustache readymade thundercats keffiyeh craft beer marfa ethical. Wolf salvia freegan, sartorial keffiyeh echo park vegan.</p>
			</div>
		</div>
	</div>
				
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
