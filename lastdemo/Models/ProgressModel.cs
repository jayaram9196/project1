using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lastdemo.Models
{
    public class ProgressModel
    {
        [Key]
        public int ProgressId{get;set;}
        public int?progress{get;set;}

        public int? CourseId{get;set;}

        public int? UserId{get;set;}

        public virtual CourseModel? CourseModel { get; set; }

        public virtual UserMode? UserMode { get; set; }
    }
}