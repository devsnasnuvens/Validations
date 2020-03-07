using Microsoft.Extensions.DependencyInjection;
using Validations.Core.Application.Interfaces;
using Validations.Core.Application.Services;
using Validations.Core.Utils.Notifications;

namespace Validations.Core
{
    public static class DependencyInjection
    {

        public static void AddCore(this IServiceCollection services)
        {
            services.AddScoped<NotificationContext>();

            services.AddScoped<IUserAppService, UserAppService>();
        }
    }
}
