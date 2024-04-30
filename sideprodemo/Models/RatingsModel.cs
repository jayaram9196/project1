﻿using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class RatingsModel
    {
        public int RatingId { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public int? InstituteId { get; set; }

        public virtual InstituteModel Institute { get; set; }
    }
}
