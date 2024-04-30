using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class StudentModel
    {
        public StudentModel()
        {
            AdmissionModels = new HashSet<AdmissionModel>();
            AdmissionTables = new HashSet<AdmissionTable>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? StudentDob { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int? CourseId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Email { get; set; }
        public string AlternateMobile { get; set; }

        public virtual CourseModel Course { get; set; }
        public virtual ICollection<AdmissionModel> AdmissionModels { get; set; }
        public virtual ICollection<AdmissionTable> AdmissionTables { get; set; }
    }
}
