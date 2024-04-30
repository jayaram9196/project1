using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class CourseModel
    {
        public CourseModel()
        {
            AdmissionModels = new HashSet<AdmissionModel>();
            AdmissionTables = new HashSet<AdmissionTable>();
            StudentModels = new HashSet<StudentModel>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int? CourseDuration { get; set; }
        public string CourseTiming { get; set; }
        public int? NumberofStudents { get; set; }
        public int? InstituteId { get; set; }

        public virtual InstituteModel Institute { get; set; }
        public virtual ICollection<AdmissionModel> AdmissionModels { get; set; }
        public virtual ICollection<AdmissionTable> AdmissionTables { get; set; }
        public virtual ICollection<StudentModel> StudentModels { get; set; }
    }
}
