using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Post
{
    public byte PostId { get; set; }

    public DateTime PostOn { get; set; }

    public string PostText { get; set; } = null!;

    public byte UserId { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Like> Likes { get; } = new List<Like>();

    public virtual ICollection<Repost> Reposts { get; } = new List<Repost>();

    public virtual User User { get; set; } = null!;
}
