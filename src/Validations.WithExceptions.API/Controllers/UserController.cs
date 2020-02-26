using Microsoft.AspNetCore.Mvc;
using Validations.WithExceptions.API.ViewModels;

namespace Validations.WithExceptions.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public void Create([FromBody] UserViewModel userViewModel) 
        {
            
        }
    }
}