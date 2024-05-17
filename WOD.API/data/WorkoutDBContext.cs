using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WOD.API.models;

namespace WOD.API.data
{
    public class WorkoutDBContext : DbContext
    {

        public WorkoutDBContext() : base() {}
        public WorkoutDBContext(DbContextOptions<WorkoutDBContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutsOfTheDay> WODs {get; set;}
    }
}