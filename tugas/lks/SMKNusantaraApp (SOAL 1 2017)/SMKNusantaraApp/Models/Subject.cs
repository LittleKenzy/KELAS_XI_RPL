using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Assignment { get; set; }

    public int? MidExam { get; set; }

    public int? FinalExam { get; set; }

    public virtual ICollection<HeaderSchedule> HeaderSchedules { get; set; } = new List<HeaderSchedule>();
}
