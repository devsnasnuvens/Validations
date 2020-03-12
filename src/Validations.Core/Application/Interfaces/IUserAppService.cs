using Validations.Core.Application.ViewModels;

namespace Validations.Core.Application.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel CreateWithException(UserViewModel userViewModel);
        UserViewModel Create(UserViewModel userViewModel);        
    }
}
