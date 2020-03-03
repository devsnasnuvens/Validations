using Microsoft.AspNetCore.Mvc;
using Validations.Core.Domain.Entities;
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
            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);
            
        }
    }
}