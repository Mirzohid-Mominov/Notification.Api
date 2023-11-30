using Notification.Domain.Common.Entities;
using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities;

public class UserSettings : IEntity
{
    public Guid Id { get; set; }    

    public NotificationType? PreferredNotificationType {  get; set; }
}
