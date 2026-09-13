using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateofBirth { get; set; }

    public string? NoHp { get; set; }

    public virtual DetailSchedule? DetailSchedule { get; set; }
}
