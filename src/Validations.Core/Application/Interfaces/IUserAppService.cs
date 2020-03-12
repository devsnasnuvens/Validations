using Validations.Core.Application.ViewModels;
using Validations.Core.Utils.Results;

namespace Validations.Core.Application.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel CreateWithException(UserViewModel userViewModel);
        Result<UserViewModel> Create(UserViewModel userViewModel);        
    }
}
