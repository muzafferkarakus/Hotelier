﻿using Microsoft.AspNetCore.Identity;

namespace Hotelier.EntityLayer.Concrate
{
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? ImageUrl { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public string? WorkDepartment { get; set; }
        public int WorkLocationId { get; set; }

        public WorkLocation WorkLocation { get; set; }
    }
}
