using ManagementSystem.Bussines;
using ManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldController : ControllerBase
    {
        [HttpGet(Name = "LoadSold")]
        public IEnumerable<Sold> LoadSold()
        {
            return SoldBussines.LoadSold().ToArray();
        }

        [HttpPost(Name = "CreateSold")]
        public void CreateSold([FromBody] Sold sold)
        {
            SoldBussines.CreateSold(sold);
        }

        [HttpPut(Name = "UpdateSold")]
        public void UpdateSold([FromBody] Sold sold)
        {
            SoldBussines.UpdateSold(sold);
        }

        [HttpDelete(Name = "DeleteSold")]
        public void DeleteSold([FromBody] Sold sold)
        {
            SoldBussines.DeleteSold(sold);
        }
    }
}
