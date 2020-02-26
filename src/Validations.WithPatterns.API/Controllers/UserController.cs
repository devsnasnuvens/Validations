using Microsoft.AspNetCore.Mvc;
using Validations.WithPatterns.API.ViewModels;

namespace Validations.WithPatterns.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public void Create([FromBody] UserViewModel userViewModel) 
        {
            var user = new Domain.Entities.User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);
            
        }
    }
}