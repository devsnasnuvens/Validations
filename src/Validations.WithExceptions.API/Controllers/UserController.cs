using System;
using Microsoft.AspNetCore.Mvc;
using Validations.Core.Domain.Entities;
using Validations.WithExceptions.API.ViewModels;

namespace Validations.WithExceptions.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ReturnUserViewModel Create([FromBody] UserViewModel userViewModel) 
        {
            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);

            if (string.IsNullOrEmpty(user.Name))
            {
                throw new Exception("Enter the User name!");
            }

            if (string.IsNullOrEmpty(user.Email))
            {
                throw new Exception("Enter the User e-mail!");
            }

            if (string.IsNullOrEmpty(user.PhoneNumber))
            {
                throw new Exception("Enter the User phone number!");
            }

            // CODE TO INSERT USER IN DB HERE

            return new ReturnUserViewModel() 
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}