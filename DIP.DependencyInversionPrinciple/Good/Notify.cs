using DIP.DependencyInversionPrinciple.CommonTypes;
using System;
using System.Linq;
using System.Reflection;

namespace DIP.DependencyInversionPrinciple.Good
{
    public static class Notify
    {
        public static void NotifyMessage(string message, EnumMessageType type)
        {
            Notification notification = null;

            if (TryGetNotificationStrategy(type, ref notification))
            {
                notification.SendNotification(message);
            }
        }

        private static bool TryGetNotificationStrategy(EnumMessageType messageType, ref Notification notification)
        {
            IMessageType notifType = null;

            var resolvedType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(t => typeof(IMessageType).IsAssignableFrom(t))
                .FirstOrDefault(tp => tp.AssemblyQualifiedName.Contains(messageType.ToString()));

            if(resolvedType != null)
            {
                notifType = Activator.CreateInstance(resolvedType) as IMessageType;

                notification = new Notification(notifType);
            }

            return notification != null;
        }
    }
}
