#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_ShowcaseSearchWithFilterPage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b8b3d39e0141d5454277e53b4a063a7ae2d4563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ShowcaseSearchWithFilterPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ShowcaseSearchWithFilterPage/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8b3d39e0141d5454277e53b4a063a7ae2d4563", @"/Views/Shared/Components/_ShowcaseSearchWithFilterPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c23fee9e1a438563d3429d932f1361601c49e35", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__ShowcaseSearchWithFilterPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<div class=\"col-lg-3 mt-lg-0 mt-4 p-lg-0\">\r\n\t<div class=\"side-bar p-sm-4 p-3\">\r\n\t\t<div class=\"search-hotel border-bottom py-2\">\r\n\t\t\t<h3 class=\"agileits-sear-head mb-3\">Search Here..</h3>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b8b3d39e0141d5454277e53b4a063a7ae2d45635286", async() => {
                WriteLiteral("\r\n\t\t\t\t<input type=\"search\" placeholder=\"Product name...\" name=\"search\"");
                BeginWriteAttribute("required", " required=\"", 292, "\"", 303, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t<input type=\"submit\" value=\" \">\r\n\t\t\t");
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
            WriteLiteral(@"
		</div>
		<!-- price -->
		<div class=""range border-bottom py-2"">
			<h3 class=""agileits-sear-head mb-3"">Price</h3>
			<div class=""w3l-range"">
				<ul>
					<li>
						<a href=""#"">Under $1,000</a>
					</li>
					<li class=""my-1"">
						<a href=""#"">$1,000 - $5,000</a>
					</li>
					<li>
						<a href=""#"">$5,000 - $10,000</a>
					</li>
					<li class=""my-1"">
						<a href=""#"">$10,000 - $20,000</a>
					</li>
					<li>
						<a href=""#"">$20,000 $30,000</a>
					</li>
					<li class=""mt-1"">
						<a href=""#"">Over $30,000</a>
					</li>
				</ul>
			</div>
		</div>
		<!-- //price -->
		<!-- discounts -->
		<div class=""left-side border-bottom py-2"">
			<h3 class=""agileits-sear-head mb-3"">Discount</h3>
			<ul>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">5% or More</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">10% or More</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checke");
            WriteLiteral(@"d"">
					<span class=""span"">20% or More</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">30% or More</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">50% or More</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">60% or More</span>
				</li>
			</ul>
		</div>
		<!-- //discounts -->
		<!-- reviews -->
		<div class=""customer-rev border-bottom left-side py-2"">
			<h3 class=""agileits-sear-head mb-3"">Customer Review</h3>
			<ul>
				<li>
					<a href=""#"">
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<span>5.0</span>
					</a>
				</li>
				<li>
					<a href=""#"">
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<span>4.0</sp");
            WriteLiteral(@"an>
					</a>
				</li>
				<li>
					<a href=""#"">
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star-half""></i>
						<span>3.5</span>
					</a>
				</li>
				<li>
					<a href=""#"">
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<span>3.0</span>
					</a>
				</li>
				<li>
					<a href=""#"">
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star""></i>
						<i class=""fas fa-star-half""></i>
						<span>2.5</span>
					</a>
				</li>
			</ul>
		</div>
		<!-- //reviews -->
		<!-- electronics -->
		<div class=""left-side border-bottom py-2"">
			<h3 class=""agileits-sear-head mb-3"">Electronics</h3>
			<ul>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Accessories</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Cameras & Photography</span>
				</li>
		");
            WriteLiteral(@"		<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Car & Vehicle Electronics</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Computers & Accessories</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">GPS & Accessories</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Headphones</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Home Audio</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Home Theater, TV & Video</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Mobiles & Accessories</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Portable Media Players</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""");
            WriteLiteral(@"span"">Tablets</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Telephones & Accessories</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Wearable Technology</span>
				</li>
			</ul>
		</div>
		<!-- //electronics -->
		<!-- delivery -->
		<div class=""left-side border-bottom py-2"">
			<h3 class=""agileits-sear-head mb-3"">Cash On Delivery</h3>
			<ul>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Eligible for Cash On Delivery</span>
				</li>
			</ul>
		</div>
		<!-- //delivery -->
		<!-- arrivals -->
		<div class=""left-side border-bottom py-2"">
			<h3 class=""agileits-sear-head mb-3"">New Arrivals</h3>
			<ul>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Last 30 days</span>
				</li>
				<li>
					<input type=""checkbox"" class=""checked"">
					<span class=""span"">Last 90 days</span>
				</li>
			</ul>
		</div>
		<!-- //arriv");
            WriteLiteral(@"als -->
		<!-- best seller -->
		<div class=""f-grid py-2"">
			<h3 class=""agileits-sear-head mb-3"">Best Seller</h3>
			<div class=""box-scroll"">
				<div class=""scroll"">
					<div class=""row"">
						<div class=""col-lg-3 col-sm-2 col-3 left-mar"">
							<img src=""images/k1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5757, "\"", 5763, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-9 col-sm-10 col-9 w3_mvd\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5861, "\"", 5868, 0);
            EndWriteAttribute();
            WriteLiteral(">Samsung Galaxy On7 Prime (Gold, 4GB RAM + 64GB Memory)</a>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5939, "\"", 5946, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"price-mar mt-2\">$12,990.00</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"row my-4\">\r\n\t\t\t\t\t\t<div class=\"col-lg-3 col-sm-2 col-3 left-mar\">\r\n\t\t\t\t\t\t\t<img src=\"images/k2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6128, "\"", 6134, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-9 col-sm-10 col-9 w3_mvd\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 6232, "\"", 6239, 0);
            EndWriteAttribute();
            WriteLiteral(">Haier 195 L 4 Star Direct-Cool Single Door Refrigerator</a>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 6311, "\"", 6318, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"price-mar mt-2\">$12,499.00</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-lg-3 col-sm-2 col-3 left-mar\">\r\n\t\t\t\t\t\t\t<img src=\"images/k3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6495, "\"", 6501, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-9 col-sm-10 col-9 w3_mvd\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 6599, "\"", 6606, 0);
            EndWriteAttribute();
            WriteLiteral(">Ambrane 13000 mAh Power Bank (P-1310 Premium)</a>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 6668, "\"", 6675, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"price-mar mt-2\">$1,199.00 </a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- //best seller -->\r\n\t</div>\r\n\t<!-- //product right -->\r\n</div>\r\n");
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
