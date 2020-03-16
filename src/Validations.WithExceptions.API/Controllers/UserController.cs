using Microsoft.AspNetCore.Mvc;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.ViewModels;

namespace Validations.WithExceptions.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost]
        public UserViewModel Create([FromBody] CreateUserViewModel userViewModel)
        {
            return _userAppService.CreateWithException(userViewModel);
        }
    }
}