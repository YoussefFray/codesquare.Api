using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class Follow
{
    public byte FollowId { get; set; }

    public DateTime FollowTime { get; set; }

    public byte FollowerId { get; set; }

    public byte FollowingId { get; set; }

    public virtual User Follower { get; set; } = null!;

    public virtual User Following { get; set; } = null!;
}
