using System;
using System.Collections.Generic;

namespace lastdemo.Models;

public partial class InstituteModel
{
    public int InstituteId { get; set; }

    public string? InstituteName { get; set; }

    public string? InstituteDescription { get; set; }

    public string? InstituteAddress { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<AdmissionTable> AdmissionTables { get; set; } = new List<AdmissionTable>();

    public virtual ICollection<CourseModel> CourseModels { get; set; } = new List<CourseModel>();

    public virtual ICollection<RatingsModel> RatingsModels { get; set; } = new List<RatingsModel>();
}
