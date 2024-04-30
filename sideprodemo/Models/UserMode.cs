using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class UserMode
    {
        public UserMode()
        {
            AdmissionModels = new HashSet<AdmissionModel>();
            AdmissionTables = new HashSet<AdmissionTable>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string MobileNumber { get; set; }
        public string UserRole { get; set; }

        public virtual ICollection<AdmissionModel> AdmissionModels { get; set; }
        public virtual ICollection<AdmissionTable> AdmissionTables { get; set; }
    }
}
