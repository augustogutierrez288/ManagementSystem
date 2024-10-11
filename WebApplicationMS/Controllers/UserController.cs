using ManagementSystem.Bussines;
using ManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "LoadUser")]
        public IEnumerable<User> LoadUser()
        {
            return UserBussines.LoadUser().ToArray();
        }

        [HttpPost(Name = "CreateUser")]
        public void CreateUser([FromBody] User user)
        {
            UserBussines.CreateUser(user);
        }

        [HttpPut(Name = "UpdateUser")]
        public void UpdateUser([FromBody] User user)
        {
            UserBussines.UpdateUser(user);
        }

        [HttpDelete(Name = "DeleteUser")]
        public void DeleteUser([FromBody] User user)
        {
            UserBussines.DeleteUser(user);
        }
    }
}
