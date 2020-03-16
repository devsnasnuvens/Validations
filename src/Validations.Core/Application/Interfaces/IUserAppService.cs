using Validations.Core.Application.ViewModels;
using Validations.Core.Utils.Results;

namespace Validations.Core.Application.Interfaces
{
    public interface IUserAppService
    {
        UserViewModel CreateWithException(CreateUserViewModel userViewModel);
        UserViewModel CreateWithNotification(CreateUserViewModel userViewModel);
        Result<UserViewModel> CreateWithNotificationAndResult(CreateUserViewModel userViewModel);
    }
}
