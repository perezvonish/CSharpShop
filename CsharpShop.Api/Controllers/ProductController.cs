using CsharpShop.Domain.Entities;
using CsharpShop.Infrastucture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CsharpShop.Api.Controllers
{
    [Route("v1/products")]
    [ApiController]
    public class ProductController : BaseController
    {
        public ProductController(ApplicationDbContext options) : base(options) { }

        //[HttpGet("{id: int}")]
        //public JsonResult GetProduct(Product product)
        //{
        //    return new JsonResult(product);
        //}

        //[HttpGet("/list/{id: int}")]
        //public JsonResult GetProducts(Product product)
        //{
        //    return new JsonResult(product);
        //}

        [HttpPost("create")]
        public JsonResult CreateProduct(Product product)
        {
            return new JsonResult(product);
        }

        [HttpDelete("delete")]
        public JsonResult DeleteProduct(Product product) { 
            return new JsonResult(product);
        }

        [HttpPatch("moderate")]
        public JsonResult ModerateProduct(Product product)
        {
            return new JsonResult(product);
        }

        [HttpPatch("hide")]
        public JsonResult HideProduct(Product product) {  
            return new JsonResult(product); 
        }
    }
}
