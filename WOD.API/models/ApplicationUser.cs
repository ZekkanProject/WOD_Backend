using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WOD.API.models
{
    public class ApplicationUser : IdentityUser
    {
        public int? MemberId { get; set; }
    }
}