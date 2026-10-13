using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Role { get; set; }

    public int ClientId { get; set; }

    public virtual Client UserNavigation { get; set; } = null!;
}
