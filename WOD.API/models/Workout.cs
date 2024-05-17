using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOD.API.models
{
    public class Workout
    {
        public int Id { get; set; }
        public required string WorkoutName { get; set; } = string.Empty;
        public required string EquipmentUsed { get; set; } = string.Empty;
        public required string Sets { get; set; } = string.Empty;
        public required string Reps { get; set; } = string.Empty;
        public int CaloriesBurned { get; set; }
        public virtual int? WODID { get; set; }
        public virtual WorkoutsOfTheDay? WorkoutsOfTheDay { get; set; }
    }
}