using Validations.Core.Application.ViewModels;

namespace Validations.Core.Application.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel Create(UserViewModel userViewModel);
    }
}
