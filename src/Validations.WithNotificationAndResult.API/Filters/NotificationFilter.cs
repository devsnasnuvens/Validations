using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Validations.Core.Utils.Notifications;
using Validations.Core.Utils.Results;

namespace Validations.WithNotificationAndResult.API.Filters
{
    public class NotificationFilter : IAsyncResultFilter
	{
		private readonly NotificationContext _notificationContext;

		public NotificationFilter(NotificationContext notificationContext)
		{
			_notificationContext = notificationContext;
		}

		public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
		{
			if (_notificationContext.HasNotifications)
			{
				context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
				context.HttpContext.Response.ContentType = "application/json";

				var result = new Result<object>()
				{
					Succeeded = false,
					Errors = _notificationContext.Notifications.Select(x => x.Message).ToList()
				};

				await context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(result));

				return;
			}

			await next();
		}
	}
}
