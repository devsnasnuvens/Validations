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
            var user = new Domain.Entities.User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);

            if (string.IsNullOrEmpty(user.Name))
            {
                
            }

            if (string.IsNullOrEmpty(user.Email))
            {

            }
        }
    }
}