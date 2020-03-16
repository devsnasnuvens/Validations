using Microsoft.AspNetCore.Mvc;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.ViewModels;
using Validations.Core.Utils.Results;

namespace Validations.WithNotificationAndResult.API.Controllers
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
        public Result<UserViewModel> Create([FromBody] CreateUserViewModel userViewModel)
        {
            var userCreated = _userAppService.CreateWithNotificationAndResult(userViewModel);
            return userCreated;
        }
    }
}