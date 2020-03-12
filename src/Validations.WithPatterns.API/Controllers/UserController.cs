using Microsoft.AspNetCore.Mvc;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.ViewModels;
using Validations.Core.Utils.Results;

namespace Validations.WithPatterns.API.Controllers
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
        public Result<UserViewModel> Create([FromBody] UserViewModel userViewModel)
        {
            var userCreated = _userAppService.Create(userViewModel);
            return userCreated;
        }
    }
}