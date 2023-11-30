using Notification.Domain.Common.Entities;
using Notification.Domain.Enums;

namespace Notification.Domain.Entities;

public abstract class NotificationHistory : IEntity
{
    public Guid Id { get; set; }

    public Guid TemplateId { get; set; }

    public Guid SerderUserId { get; set; }

    public Guid ReceiverUserId { get; set; }    

    public NotificationType Type { get; set; }

    public string Content { get; set; } = default!;

    public bool IsSuccecful { get; set; }

    public string? ErrorMessage { get; set; }

    public NotificationTemplate Template { get; set; }
}
