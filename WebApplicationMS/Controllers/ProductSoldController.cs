using ManagementSystem.Bussines;
using ManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSoldController : ControllerBase
    {
        [HttpGet (Name = "LoadProductSold")]
        public IEnumerable<ProductSold> LoadProductSold()
        {
            return ProductSoldBussines.LoadProductSold().ToArray();
        }

        [HttpPost(Name = "CreateProductSold")]
        public void CreateProductSold([FromBody] ProductSold productSold)
        {
            ProductSoldBussines.CreateProductSold(productSold);
        }

        [HttpPut(Name = "UpdateProductSold")]
        public void UpdateProductSold([FromBody] ProductSold productSold)
        {
            ProductSoldBussines.UpdateProductSold(productSold);
        }

        [HttpDelete(Name = "DeleteProductSold")]
        public void DeleteProductSold([FromBody] ProductSold productSold)
        {
            ProductSoldBussines.DeleteProductSold(productSold);
        }
    }
}
