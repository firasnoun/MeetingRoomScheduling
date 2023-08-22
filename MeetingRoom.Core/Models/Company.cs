using System;
using System.Collections.Generic;

namespace MeetingRoom.core.Models;

public partial class Company
{
    public long CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Email { get; set; } = null!;

    public byte[]? Logo { get; set; }

    public long Active { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
