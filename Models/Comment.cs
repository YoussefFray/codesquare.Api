using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Comment
{
    public byte CommentId { get; set; }

    public string CommentText { get; set; } = null!;

    public DateTime CommentTime { get; set; }

    public byte UserId { get; set; }

    public byte PostId { get; set; }

    public virtual Post Post { get; set; } = null!;

    public virtual ICollection<Reply> Replies { get; } = new List<Reply>();

    public virtual User User { get; set; } = null!;
}
