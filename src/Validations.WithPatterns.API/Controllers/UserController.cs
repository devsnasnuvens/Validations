using Microsoft.AspNetCore.Mvc;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.ViewModels;
using Validations.Core.Utils.Notifications;

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
        public void Create([FromBody] UserViewModel userViewModel)
        {
            _userAppService.Create(userViewModel);


        }
    }
}