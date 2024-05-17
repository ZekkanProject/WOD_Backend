using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOD.API.models
{
    public class WorkoutsOfTheDay
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public TimeOnly Duration { get; set; }
        public ICollection<Workout> Workouts { get; set; } = [];
    }
}