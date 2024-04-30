using System;
using System.Collections.Generic;

namespace lastdemo.Models;

public partial class CourseModel
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseDescription { get; set; }

    public int? CourseDuration { get; set; }

    public string? CourseTiming { get; set; }

    public int? NumberofStudents { get; set; }

    public int? InstituteId { get; set; }

    public virtual ICollection<AdmissionTable> AdmissionTables { get; set; } = new List<AdmissionTable>();

    public virtual InstituteModel? Institute { get; set; }

    public virtual ICollection<StudentModel> StudentModels { get; set; } = new List<StudentModel>();

    public virtual ICollection<ProgressModel> ProgressModels { get; set; } = new List<ProgressModel>();
}
