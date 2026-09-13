using System;
using System.Collections.Generic;

namespace SMKNusantaraApp.Models;

public partial class User
{
    public int Userid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}
