﻿using System;
using System.Collections.Generic;

#nullable disable

namespace sideproDemo.Models
{
    public partial class AdminModel
    {
        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string MobileNumber { get; set; }
        public string UserRole { get; set; }
    }
}
