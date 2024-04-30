using System;
using System.Collections.Generic;

namespace lastdemo.Models;

public partial class UserMode
{
    public int UserId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Username { get; set; }

    public string? MobileNumber { get; set; }

    public string? UserRole { get; set; }

    public virtual ICollection<AdmissionTable> AdmissionTables { get; set; } = new List<AdmissionTable>();

    public virtual ICollection<ProgressModel> ProgressModels { get; set; } = new List<ProgressModel>();
}
