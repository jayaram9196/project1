using System;
using System.Collections.Generic;

namespace lastdemo.Models;

public partial class StudentModel
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public DateTime? StudentDob { get; set; }

    public string? Address { get; set; }

    public string? Mobile { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public int? CourseId { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? Email { get; set; }

    public string? AlternateMobile { get; set; }

    public virtual ICollection<AdmissionTable> AdmissionTables { get; set; } = new List<AdmissionTable>();

    public virtual CourseModel? Course { get; set; }
}
