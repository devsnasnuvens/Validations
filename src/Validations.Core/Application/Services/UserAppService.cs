using System;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.ViewModels;
using Validations.Core.Domain.Entities;
using Validations.Core.Utils.Notifications;
using Validations.Core.Utils.Results;

namespace Validations.Core.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly NotificationContext _notificationContext;

        public UserAppService(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        public UserViewModel CreateWithException(CreateUserViewModel userViewModel)
        {
            if (string.IsNullOrEmpty(userViewModel.Name))
            {
                throw new Exception("Enter the User name!");
            }

            if (string.IsNullOrEmpty(userViewModel.Email))
            {
                throw new Exception("Enter the User e-mail!");
            }

            if (string.IsNullOrEmpty(userViewModel.PhoneNumber))
            {
                throw new Exception("Enter the User phone number!");
            }
            
            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);

            // CODE TO INSERT USER IN DB HERE

            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
        }

        public UserViewModel CreateWithNotification(CreateUserViewModel userViewModel)
        {
            if (string.IsNullOrWhiteSpace(userViewModel.Name))
            {
                _notificationContext.AddNotification("User", "Enter the User name!");
            }

            if (string.IsNullOrWhiteSpace(userViewModel.Email))
            {
                _notificationContext.AddNotification("User", "Enter the User e-mail!");
            }

            if (string.IsNullOrWhiteSpace(userViewModel.PhoneNumber))
            {
                _notificationContext.AddNotification("User", "Enter the User phone number!");
            }

            if (_notificationContext.HasNotifications)
                return default;

            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);

            // CODE TO INSERT USER IN DB HERE

            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
        }

        public Result<UserViewModel> CreateWithNotificationAndResult(CreateUserViewModel userViewModel)
        {
            if (string.IsNullOrWhiteSpace(userViewModel.Name))
            {
                _notificationContext.AddNotification("User", "Enter the User name!");
            }

            if (string.IsNullOrWhiteSpace(userViewModel.Email))
            {
                _notificationContext.AddNotification("User", "Enter the User e-mail!");
            }

            if (string.IsNullOrWhiteSpace(userViewModel.PhoneNumber))
            {
                _notificationContext.AddNotification("User", "Enter the User phone number!");
            }

            if (_notificationContext.HasNotifications)
                return default;

            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);

            // CODE TO INSERT USER IN DB HERE

            return new Result<UserViewModel>()
            {
                Succeeded = true,
                Data = new UserViewModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                }
            };
        }
    }
}
