#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_HighlightsPage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b4c358ae6e2de2278213c8bd745c4d6c448ad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__HighlightsPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_HighlightsPage/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b4c358ae6e2de2278213c8bd745c4d6c448ad1", @"/Views/Shared/Components/_HighlightsPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d9d7a47dd5532529991275d7b640be551b5c0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__HighlightsPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Item>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_HighlightsPage\Default.cshtml"
  
	//int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
	<!-- Indicators-->
	<ol class=""carousel-indicators"">
		<li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
		<li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
		<li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
		<li data-target=""#carouselExampleIndicators"" data-slide-to=""3""></li>
	</ol>
	<div class=""carousel-inner"">
		<div class=""carousel-item item1 active""");
            BeginWriteAttribute("style", " style=\"", 566, "\"", 642, 6);
            WriteAttributeValue("", 574, "background:", 574, 11, true);
            WriteAttributeValue(" ", 585, "url(", 586, 5, true);
#nullable restore
#line 14 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_HighlightsPage\Default.cshtml"
WriteAttributeValue("", 590, ViewBag.slide1.ItemShowcaseImage, 590, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 623, ")", 623, 1, true);
            WriteAttributeValue(" ", 624, "no-repeat", 625, 10, true);
            WriteAttributeValue(" ", 634, "center;", 635, 8, true);
            EndWriteAttribute();
            WriteLiteral(@">
			<div class=""container"">
				<div class=""w3l-space-banner"">
					<div class=""carousel-caption p-lg-5 p-sm-4 p-3"">
						<p>
							İster <span>Kirala</span> İster <span>Satın Al</span>

						</p>
						<h3 class=""font-weight-bold pt-2 pb-lg-5 pb-4"">
							En İyi
							<span>");
#nullable restore
#line 24 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_HighlightsPage\Default.cshtml"
                             Write(ViewBag.slide1.ItemName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n\t\t\t\t\t\t\tBurada!\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t<a class=\"button2\" href=\"product.html\">Şimdi İncele </a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"carousel-item item2\"");
            BeginWriteAttribute("style", " style=\"", 1161, "\"", 1237, 6);
            WriteAttributeValue("", 1169, "background:", 1169, 11, true);
            WriteAttributeValue(" ", 1180, "url(", 1181, 5, true);
#nullable restore
#line 33 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_HighlightsPage\Default.cshtml"
WriteAttributeValue("", 1185, ViewBag.slide2.ItemShowcaseImage, 1185, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1218, ")", 1218, 1, true);
            WriteAttributeValue(" ", 1219, "no-repeat", 1220, 10, true);
            WriteAttributeValue(" ", 1229, "center;", 1230, 8, true);
            EndWriteAttribute();
            WriteLiteral(@">
			<div class=""container"">
				<div class=""w3l-space-banner"">
					<div class=""carousel-caption p-lg-5 p-sm-4 p-3"">
						<p>
							İster <span>Kirala</span> İster <span>Satın Al</span>
							
						</p>
						<h3 class=""font-weight-bold pt-2 pb-lg-5 pb-4"">
							En İyi
							<span>");
#nullable restore
#line 43 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\Shared\Components\_HighlightsPage\Default.cshtml"
                             Write(ViewBag.slide1.ItemName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
							Burada!
						</h3>
						<a class=""button2"" href=""product.html"">Şimdi İncele </a>
					</div>
				</div>
			</div>
		</div>
		<div class=""carousel-item item3"">
			<div class=""container"">
				<div class=""w3l-space-banner"">
					<div class=""carousel-caption p-lg-5 p-sm-4 p-3"">
						<p>
							İster <span>Kirala</span> İster <span>Satın Al</span>

						</p>
						<h3 class=""font-weight-bold pt-2 pb-lg-5 pb-4"">
							New
							<span>Standard</span>
						</h3>
						<a class=""button2"" href=""product.html"">Shop Now </a>
					</div>
				</div>
			</div>
		</div>
		<div class=""carousel-item item4"">
			<div class=""container"">
				<div class=""w3l-space-banner"">
					<div class=""carousel-caption p-lg-5 p-sm-4 p-3"">
						<p>
							Get Now
							<span>40%</span> Discount
						</p>
						<h3 class=""font-weight-bold pt-2 pb-lg-5 pb-4"">
							Today
							<span>Discount</span>
						</h3>
						<a class=""button2"" href=""product.html"">Shop Now </a>
					</div>
			");
            WriteLiteral("\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t\r\n");
            WriteLiteral(@"	
		
	</div>
	<a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
		<span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
		<span class=""sr-only"">Previous</span>
	</a>
	<a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
		<span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
		<span class=""sr-only"">Next</span>
	</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591