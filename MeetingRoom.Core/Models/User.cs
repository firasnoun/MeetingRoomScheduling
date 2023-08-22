using System;
using System.Collections.Generic;

namespace MeetingRoom.core.Models;

public partial class User
{
    public long UserId { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public long? CompanyId { get; set; }

    public virtual Company? Company { get; set; }
}
