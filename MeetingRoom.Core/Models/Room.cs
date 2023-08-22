using System;
using System.Collections.Generic;

namespace MeetingRoom.core.Models;

public partial class Room
{
    public long RoomId { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public long Capacity { get; set; }

    public string? Description { get; set; }

    public long? CompanyId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
