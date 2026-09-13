using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class DetailSchedule
{
    public int ScheduleId { get; set; }

    public int StudentId { get; set; }

    public virtual Student Schedule { get; set; } = null!;
}
