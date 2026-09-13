using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class HeaderSchedule
{
    public int ScheduleId { get; set; }

    public int? SubjectId { get; set; }

    public int? TeacherId { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Subject? Subject { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
