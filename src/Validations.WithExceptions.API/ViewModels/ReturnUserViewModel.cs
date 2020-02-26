using System;

namespace Validations.WithExceptions.API.ViewModels
{
    public class ReturnUserViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}