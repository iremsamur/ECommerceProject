#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a084e7379a972c81686d1c2e3a8bf15559f8e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndividualSeller_GetAllMyOpenItemAds), @"mvc.1.0.view", @"/Views/IndividualSeller/GetAllMyOpenItemAds.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a084e7379a972c81686d1c2e3a8bf15559f8e1b", @"/Views/IndividualSeller/GetAllMyOpenItemAds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b71c6bdc6240e3aa17c9e8851f19d6f788913a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_IndividualSeller_GetAllMyOpenItemAds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllMyOpenItemAdsDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
  
    ViewData["Title"] = "GetAllMyOpenItemAds";
    Layout = "~/Views/Shared/_SellerAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card \">\r\n    <div class=\"card-header\">\r\n        <h4 class=\"card-title\"> Simple Table</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table tablesorter \"");
            BeginWriteAttribute("id", " id=\"", 381, "\"", 386, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead class="" text-primary"">
                    <tr>
                        <th>
                            Ürün Numarası
                        </th>
                        <th>
                            Ürün Adı
                        </th>
                     
                        <th>
                            Ürün Resmi
                        </th>
                       
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 30 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 33 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 36 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1275, "\"", 1304, 1);
#nullable restore
#line 39 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 1281, item.ItemShowcaseImage, 1281, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1305, "\"", 1325, 1);
#nullable restore
#line 39 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 1311, item.ItemName, 1311, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px;height:300px;\">\r\n                            </td>\r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n                 \r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllMyOpenItemAdsDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
