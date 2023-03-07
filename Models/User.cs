using System;
using System.Collections.Generic;

namespace codesquare.Models;

public partial class User
{
    public byte UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    public string? ImgCover { get; set; }

    public string? Bio { get; set; }

    public string? Location { get; set; }

    public string? Token { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Follow> FollowFollowers { get; } = new List<Follow>();

    public virtual ICollection<Follow> FollowFollowings { get; } = new List<Follow>();

    public virtual ICollection<Like> Likes { get; } = new List<Like>();

    public virtual ICollection<Message> MessageReceivers { get; } = new List<Message>();

    public virtual ICollection<Message> MessageSenders { get; } = new List<Message>();

    public virtual ICollection<Notification> NotificationNotifyForNavigations { get; } = new List<Notification>();

    public virtual ICollection<Notification> NotificationNotifyFromNavigations { get; } = new List<Notification>();

    public virtual ICollection<Post> Posts { get; } = new List<Post>();

    public virtual ICollection<Reply> Replies { get; } = new List<Reply>();
}
