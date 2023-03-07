using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Repost
{
    public byte RepostId { get; set; }

    public DateTime RepostTime { get; set; }

    public string RepostText { get; set; } = null!;

    public byte Postid { get; set; }

    public byte RepostSid { get; set; }

    public virtual ICollection<Repost> InverseRepostS { get; } = new List<Repost>();

    public virtual Post Post { get; set; } = null!;

    public virtual Repost RepostS { get; set; } = null!;
}
