using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Reply
{
    public byte ReplyId { get; set; }

    public DateTime ReplyTime { get; set; }

    public string ReplyText { get; set; } = null!;

    public byte UserId { get; set; }

    public byte CommentId { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
