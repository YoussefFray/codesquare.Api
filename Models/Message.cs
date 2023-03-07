using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Message
{
    public byte MessageId { get; set; }

    public DateTime MessageTime { get; set; }

    public string MessageText { get; set; } = null!;

    public byte SenderId { get; set; }

    public byte ReceiverId { get; set; }

    public virtual User Receiver { get; set; } = null!;

    public virtual User Sender { get; set; } = null!;
}
