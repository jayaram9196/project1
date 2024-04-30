using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class InstituteModel
    {
        public InstituteModel()
        {
            AdmissionModels = new HashSet<AdmissionModel>();
            AdmissionTables = new HashSet<AdmissionTable>();
            CourseModels = new HashSet<CourseModel>();
            RatingsModels = new HashSet<RatingsModel>();
        }

        public int InstituteId { get; set; }
        public string InstituteName { get; set; }
        public string InstituteDescription { get; set; }
        public string InstituteAddress { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<AdmissionModel> AdmissionModels { get; set; }
        public virtual ICollection<AdmissionTable> AdmissionTables { get; set; }
        public virtual ICollection<CourseModel> CourseModels { get; set; }
        public virtual ICollection<RatingsModel> RatingsModels { get; set; }
    }
}
