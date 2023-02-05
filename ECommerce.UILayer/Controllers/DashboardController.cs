using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUserService _userService;

        public DashboardController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult MyDashboard()
        {
          
            return View();
        }
        [HttpGet]
        public async Task<List<GetAllMyOpenItemAdsDTO>> GetAllMyOpenItemAds()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
         
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44362/api/ItemOwner/GetMyOpenItemAdsByUser/" + loggedUserValues.Id);//id değerine göre veriyi alıyor

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonItem = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAllMyOpenItemAdsDTO>>(jsonItem);
                return values;
            }
            else
            {
                return new List<GetAllMyOpenItemAdsDTO>();
            }
            
        }


        public async Task<IActionResult> GetItemAdsExcelFileReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Ürün Listesi");
                workSheet.Cell(1, 1).Value = "Ürün Numarası";
                workSheet.Cell(1, 2).Value = "Ürün Adı";
                workSheet.Cell(1, 3).Value = "Ürün Eski Fiyatı";
                workSheet.Cell(1, 4).Value = "İndirim Oranı";
                workSheet.Cell(1, 5).Value = "Ürün Yeni Fiyatı";
                workSheet.Cell(1, 6).Value = "Garanti Durumu";
                workSheet.Cell(1, 7).Value = "Kimden";
                workSheet.Cell(1, 8).Value = "Ürün Durumu";
                workSheet.Cell(1, 9).Value = "Ürün Açıklaması";
                workSheet.Cell(1, 10).Value = "Ürün Detayı";
                workSheet.Cell(1, 11).Value = "İlan Aktiflik Durumu";
                int rowCount = 2;
                var values = await GetAllMyOpenItemAds();
                foreach (var item in values)
                {
                    workSheet.Cell(rowCount, 1).Value = item.ItemNo;
                    workSheet.Cell(rowCount, 2).Value = item.ItemName;
                    workSheet.Cell(rowCount, 3).Value = item.ItemOldPrice;
                    workSheet.Cell(rowCount, 4).Value = item.ItemDiscount;
                    workSheet.Cell(rowCount, 5).Value = item.ItemNewPrice;
                    workSheet.Cell(rowCount, 6).Value = item.gGuarantee;
                    workSheet.Cell(rowCount, 7).Value = item.FromWho;
                    
                    workSheet.Cell(rowCount, 8).Value = item.ItemStatus;
                    workSheet.Cell(rowCount, 9).Value = item.Description;
                    workSheet.Cell(rowCount, 10).Value = item.ItemDetailDescription;
                    if (item.Status == true)
                    {
                        workSheet.Cell(rowCount, 11).Value = "Aktif";
                    }
                    else
                    {
                        workSheet.Cell(rowCount, 11).Value = "Pasif";
                    }
                    
                    rowCount++;

                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ürün_listesi.xlsx");
                }
            }
        }

            public async Task<IActionResult> GetItemAdsPdfReport()
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot/PdfReports/" + "ItemAds.pdf");
                var stream = new FileStream(path, FileMode.Create);
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, stream);
                document.Open();
                Paragraph paragraph = new Paragraph("Ürünler Detay Bilgileri \n");
                var values = await GetAllMyOpenItemAds();
                List<Paragraph> paragraphs = new List<Paragraph>();
           
                foreach (var item in values)
                {
                    Paragraph mainParagraph = new Paragraph(item.ItemNo+"-"+item.ItemName+"\n"+item.ItemDetailDescription+"\n");
                    paragraphs.Add(mainParagraph);
                    

                }
           
                document.Add(paragraph);
                foreach(var item in paragraphs)
                {

                    document.Add(item);
                }
      
                document.Close();
                return File("/PdfReports/ItemAds.pdf", "application/pdf", "ItemAds.pdf");

            }


        
    }
}
