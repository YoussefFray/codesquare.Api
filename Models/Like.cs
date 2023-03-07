using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Like
{
    public byte LikeId { get; set; }

    public DateTime LikeTime { get; set; }

    public byte UserId { get; set; }

    public byte PostId { get; set; }

    public virtual Post Post { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
