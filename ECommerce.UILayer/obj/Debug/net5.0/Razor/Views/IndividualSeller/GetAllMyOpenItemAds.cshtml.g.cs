#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2edcd14c852212f3edc7352f3fcccdccabe273"
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
#nullable restore
#line 11 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.CompanySellerDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\_ViewImports.cshtml"
using ECommerce.DTOLayer.IndividualSellerDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2edcd14c852212f3edc7352f3fcccdccabe273", @"/Views/IndividualSeller/GetAllMyOpenItemAds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1846ddabb0caec99568fe5edf293bf088f1e3efe", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\r\n<div class=\"card \">\r\n    <div class=\"card-header\">\r\n        <h4 class=\"card-title\">Açtığım İlanlar</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table tablesorter \"");
            BeginWriteAttribute("id", " id=\"", 383, "\"", 388, 0);
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
                        <th>
                            Ürün Yeni Fiyatı
                        </th>
                        <th>
                            Ürün Eski Fiyatı
                        </th>
                        <th>
                            Ürün İndirim Oranı (%)
                        </th>
                        <th>
                            İlan Türü
                        </th>
                        <th>
                            İlan Yayın Tarihi
                        </th>
                        <th>
                            Ürün Durumu
               ");
            WriteLiteral(@"         </th>
                        <th>
                            Açıklama
                        </th>
                        <th>İlan Durumu (Aktif/Pasif)</th>
                        <th>İlan Güncelle</th>
                        <th>İlan Detay Güncelle</th>
                        <th>İlanı Kaldır</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 54 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2197, "\"", 2226, 1);
#nullable restore
#line 63 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 2203, item.ItemShowcaseImage, 2203, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2227, "\"", 2247, 1);
#nullable restore
#line 63 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 2233, item.ItemName, 2233, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px;height:150px;\">\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemNewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemOldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemAdType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemAnnouncementDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.ItemStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 73 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                             if(item.Status==true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"background-color:limegreen;color:white;\">Aktif</td>\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"background-color:red;color:white;\">Pasif</td>\r\n");
#nullable restore
#line 78 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3094, "\"", 3144, 2);
            WriteAttributeValue("", 3101, "/IndividualSeller/UpdateItemAd/", 3101, 31, true);
#nullable restore
#line 79 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 3132, item.ItemId, 3132, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">İlan Düzenle</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3235, "\"", 3296, 2);
            WriteAttributeValue("", 3242, "/IndividualSeller/UpdateItemDetails/", 3242, 36, true);
#nullable restore
#line 80 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 3278, item.ItemDetailId, 3278, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">İlan Detay Düzenle</a></td>\r\n");
#nullable restore
#line 81 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                             if(item.Status==true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3447, "\"", 3497, 2);
            WriteAttributeValue("", 3454, "/IndividualSeller/RemoveItemAd/", 3454, 31, true);
#nullable restore
#line 82 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 3485, item.ItemId, 3485, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">İlanı Kapat</a></td>\r\n");
#nullable restore
#line 83 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3656, "\"", 3704, 2);
            WriteAttributeValue("", 3663, "/IndividualSeller/OpenItemAd/", 3663, 29, true);
#nullable restore
#line 85 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
WriteAttributeValue("", 3692, item.ItemId, 3692, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">İlanı Aç</a></td>\r\n");
#nullable restore
#line 86 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\GetAllMyOpenItemAds.cshtml"

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
