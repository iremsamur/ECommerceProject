#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d69b87585db01fd6908fdf87a802f4156301a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndividualSeller_UpdateItemDetails), @"mvc.1.0.view", @"/Views/IndividualSeller/UpdateItemDetails.cshtml")]
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
#line 1 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
using ECommerce.EntityLayer.Concrete.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d69b87585db01fd6908fdf87a802f4156301a7", @"/Views/IndividualSeller/UpdateItemDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b71c6bdc6240e3aa17c9e8851f19d6f788913a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_IndividualSeller_UpdateItemDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpdateItemDetailDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:red;color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/IndividualSeller/UpdateItemDetails/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createItemForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
  
    ViewData["Title"] = "UpdateItemDetails";
    Layout = "~/Views/Shared/_SellerAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button onclick=\"myFunction()\" class=\"btn btn-gradient-primary mr-2\">Formu Göster/Gizle</button>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51d69b87585db01fd6908fdf87a802f4156301a79163", async() => {
                WriteLiteral("\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n\r\n\r\n                <h4 class=\"card-title\">İlan Detayı Güncelleme</h4>\r\n                <br />\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51d69b87585db01fd6908fdf87a802f4156301a79675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemDetailID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" <!--Kullanıcıya ID'yi göstermez. Ama arka planda ID'yi alır-->



                <div class=""forms-sample"">
                    <div class=""form-group"">
                        <label for=""exampleInputName1"">İlan Numarası </label>




                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51d69b87585db01fd6908fdf87a802f4156301a711700", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 30 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemNo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
                                                                                                                              WriteLiteral(ViewBag.itemNumber);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <br />\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Eski Fiyatı </label>\r\n\r\n\r\n\r\n                        ");
#nullable restore
#line 39 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
                   Write(Html.TextBoxFor(x => x.ItemOldPrice, new { @class = "form-control",@style="background-color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                    </div>\r\n                    <br />\r\n\r\n\r\n                    <br />\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">İndirim Oranı</label>\r\n\r\n\r\n\r\n                        ");
#nullable restore
#line 51 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
                   Write(Html.TextBoxFor(x => x.ItemDiscount, new { @class = "form-control",@style="background-color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                    </div>

                    <br />
                    <div class=""form-group"">
                        <label for=""exampleInputName1"">İlan Türü</label>
                        <br />

                        <input type=""radio"" name=""ItemAdType""");
                BeginWriteAttribute("value", " value=\"", 2247, "\"", 2274, 1);
#nullable restore
#line 60 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
WriteAttributeValue("", 2255, ItemAdType.Kiralık, 2255, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color:white;font-weight:bold;\" /> <label>Kiralık</label>\r\n                        <br />\r\n                        <input type=\"radio\" name=\"ItemAdType\"");
                BeginWriteAttribute("value", " value=\"", 2434, "\"", 2461, 1);
#nullable restore
#line 62 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
WriteAttributeValue("", 2442, ItemAdType.Satılık, 2442, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""color:white;font-weight:bold;"" /> <label>Satılık</label>



                    </div>
                    <br />

                    <div class=""form-group"">
                        <label for=""exampleInputEmail3"">Marka</label>
                        ");
#nullable restore
#line 71 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
                   Write(Html.DropDownListFor(x => x.BrandID,(List<SelectListItem>)ViewBag.brands, new { @class = "form-control",@style="background-color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    </div>
                    <br />
                    <div class=""form-group"">
                        <label for=""exampleInputName1"">Garantisi</label>
                        <br />
                        <input type=""radio"" name=""gGuarantee"" value=""Evet"" style=""color:white;font-weight:bold;"" /> <label>Evet</label>
                        <br />
                        <input type=""radio"" name=""gGuarantee"" value=""Hayır"" style=""color:white;font-weight:bold;"" /> <label>Hayır</label>
                        <br />



                    </div>

                    <br>
                    <div class=""form-group"">
                        <label for=""exampleInputName1"">Durumu</label>
                        <br />
                        <input type=""radio"" name=""ItemStatus"" value=""1.El"" style=""color:white;font-weight:bold;"" /> <label>1.El</label>
                        <br />
                        <input type=""radio"" name=""ItemStatus"" value=""2.El"" style=""color:wh");
                WriteLiteral(@"ite;font-weight:bold;"" /> <label>2.El</label>
                        <br />



                    </div>
                    <br>
                    <div class=""form-group"">
                        <label for=""exampleInputName1"">Açıklama</label>
                        ");
#nullable restore
#line 103 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control",@style="background-color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <br>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Detay Bilgi</label>\r\n                        ");
#nullable restore
#line 111 "C:\Users\User\Desktop\UpSchoolBootcamp\ECommerce.UILayer\ECommerce.UILayer\Views\IndividualSeller\UpdateItemDetails.cshtml"
                   Write(Html.TextAreaFor(x => x.ItemDetailDescription, new { @class = "form-control",@style="background-color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"

                    </div>



                    <button type=""submit"" class=""btn btn-gradient-primary mr-2"" id=""savebtn"">Kaydet</button>
                    <button class=""btn btn-light"">İptal</button>
                </div>
            </div>
        </div>
    </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<a href=""/IndividualSeller/AddItemDetailToItem"" class=""btn btn-primary"">Ürüne Detay Ekle</a>

<script>
    function myFunction() {
        var x = document.getElementById(""createItemForm"");
        if (x.style.display === ""none"") {
            x.style.display = ""block"";
        } else {
            x.style.display = ""none"";
        }
    }
</script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateItemDetailDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
