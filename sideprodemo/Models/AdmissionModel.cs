using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class AdmissionModel
    {
        public int AdmissionId { get; set; }
        public int? StudentId { get; set; }
        public int? Courseid { get; set; }
        public int? InstituteId { get; set; }
        public int? Userid { get; set; }
        public int? Courseduration { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual CourseModel Course { get; set; }
        public virtual InstituteModel Institute { get; set; }
        public virtual StudentModel Student { get; set; }
        public virtual UserMode User { get; set; }
    }
}
