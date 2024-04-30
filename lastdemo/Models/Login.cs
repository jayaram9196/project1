using System;
using System.Collections.Generic;

namespace lastdemo.Models;

public partial class Login
{
    public int? LoginId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
