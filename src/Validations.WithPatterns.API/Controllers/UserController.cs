using Microsoft.AspNetCore.Mvc;
using Validations.Core.Domain.Entities;
using Validations.Core.Utils.Notifications;
using Validations.WithPatterns.API.ViewModels;

namespace Validations.WithPatterns.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly NotificationContext _notificationContext;

        public UserController(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        [HttpPost]
        public void Create([FromBody] UserViewModel userViewModel) 
        {
            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);
            
            if (!user.Valid)
            {
                _notificationContext.AddNotifications(user.ValidationResult);
            }
        }
    }
}