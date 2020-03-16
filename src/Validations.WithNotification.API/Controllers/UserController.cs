using Microsoft.AspNetCore.Mvc;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.ViewModels;

namespace Validations.WithNotification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var userCreated = _userAppService.CreateWithNotification(userViewModel);
            return userCreated;
        }
    }
}