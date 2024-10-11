using ManagementSystem.Bussines;
using ManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "LoadProduct")]
        public IEnumerable<Product> LoadProduct()
        {
            return ProductBussines.LoadProduct().ToArray();
        }

        [HttpPost(Name = "CreateProduct")]
        public void CreateProduct([FromBody] Product product)
        {
            ProductBussines.CreateProduct(product);
        }

        [HttpPut(Name = "UpdateProduct")]
        public void UpdateProduct([FromBody] Product product)
        {
            ProductBussines.UpdateProduct(product);
        }

        [HttpDelete( Name = "DeleteProduct")]
        public void DeleteProduct([FromBody] Product product)
        {
            ProductBussines.DeleteProduct(product);
        }
    }
}
