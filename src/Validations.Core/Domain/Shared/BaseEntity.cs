using FluentValidation;
using FluentValidation.Results;
using System;

namespace Validations.Core.Domain.Shared
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }
        public bool Valid { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return Valid = ValidationResult.IsValid;
        }
    }
}
