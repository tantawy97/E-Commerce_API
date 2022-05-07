using E_Commerce.Models;
using E_Commerce.Services;
using E_Commerce.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
            
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var products = await productRepository.GetAll();

            return Ok(products.OrderByDescending(w=>w.Id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync()
        {
            ProductViewModel productVM = new ProductViewModel()
            {
                Image = Request.Form.Files[0],
                Name = Request.Form["name"],
                Price = Convert.ToDouble(Request.Form["price"]),
                Quantity = Convert.ToDouble(Request.Form["quantity"]),
                Categoryid = Convert.ToInt32(Request.Form["categoryid"])

            };
           
            await productRepository.Create(productVM);

            return Ok(productVM);
        }
        //[HttpPost]
        //public async Task< IActionResult> CreateAsync()
        //{
        //    try
        //    {
        //        var file = Request.Form.Files[0];
        //        var folderName = Path.Combine("Resources", "Images");
        //        var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
        //        if (file.Length > 0)
        //        {
        //            var fileName=ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        //            var fullPatch = Path.Combine(pathToSave, fileName);
        //            var dbPath = Path.Combine(folderName, fileName);
        //            using (var stream = new FileStream(fullPatch, FileMode.Create))
        //            {
        //              await  file.CopyToAsync(stream);
        //            } ;
        //            return Ok(new {dbPath});
        //        }
        //        else
        //        {
        //            return BadRequest();
        //        }

        //    }
        //    catch(Exception ex){
        //        return StatusCode(500, $"internal server error:{ex}");
        //    }
           
        //}
    }
}
