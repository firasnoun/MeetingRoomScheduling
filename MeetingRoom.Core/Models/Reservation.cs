using System;
using System.Collections.Generic;

namespace MeetingRoom.core.Models;

public partial class Reservation
{
    public long ReservationId { get; set; }

    public byte[] DateOfMeeting { get; set; } = null!;

    public string StartTime { get; set; } = null!;

    public string EndTime { get; set; } = null!;

    public long? RoomId { get; set; }

    public long NumberOfAttendees { get; set; }

    public long MeetingStatus { get; set; }

    public virtual Room? Room { get; set; }
}
