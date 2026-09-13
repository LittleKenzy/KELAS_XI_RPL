using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<HeaderSchedule> HeaderSchedules { get; set; } = new List<HeaderSchedule>();
}
