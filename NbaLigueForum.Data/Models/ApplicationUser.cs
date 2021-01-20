using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLigueForum.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Ratting { get; set; }
        public string ProfileImgUrl { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsActive { get; set; }
    }
}
