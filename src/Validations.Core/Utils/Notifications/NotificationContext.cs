using System.Collections.Generic;
using System.Linq;

namespace Validations.Core.Utils.Notifications
{
	public class NotificationContext
	{
		private readonly List<Notification> _notifications;
		public IReadOnlyCollection<Notification> Notifications => _notifications;
		public bool HasNotifications => _notifications.Any();

		public NotificationContext()
		{
			_notifications = new List<Notification>();
		}

		public void AddNotification(string key, string message)
		{
			_notifications.Add(new Notification(key, message));
		}

		public void AddNotification(Notification notification)
		{
			_notifications.Add(notification);
		}

		public void AddNotifications(IList<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}
	}
}
