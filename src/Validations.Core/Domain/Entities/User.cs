using System;
using Validations.Core.Domain.Shared;
using Validations.Core.Domain.Validators;

namespace Validations.Core.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;

            Validate(this, new UserValidator());
        }

        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }
    }
}
