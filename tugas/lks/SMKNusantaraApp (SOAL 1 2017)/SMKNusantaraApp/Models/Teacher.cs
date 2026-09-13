using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<HeaderSchedule> HeaderSchedules { get; set; } = new List<HeaderSchedule>();
}
