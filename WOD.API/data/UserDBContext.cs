using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WOD.API.models;

namespace WOD.API.data
{
    public class UserDBContext : IdentityDbContext<ApplicationUser>
    {
        public UserDBContext() : base() {}
        public UserDBContext(DbContextOptions<UserDBContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<ApplicationUser> ApplicationUser {get; set;}
    }
}