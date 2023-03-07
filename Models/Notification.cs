using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Notification
{
    public byte NotificationId { get; set; }

    public string NotificationType { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string Status { get; set; } = null!;

    public byte NotifyFor { get; set; }

    public byte NotifyFrom { get; set; }

    public virtual User NotifyForNavigation { get; set; } = null!;

    public virtual User NotifyFromNavigation { get; set; } = null!;
}
