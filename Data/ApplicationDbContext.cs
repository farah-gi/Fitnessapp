using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models;
using fitnessApp.Data.Configurations;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<WorkoutPlanExercise> WorkoutPlanExercises { get; set; }
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseProgress> ExerciseProgresses { get; set; }
        public DbSet<ExerciseAnalysis> ExerciseAnalyses { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealItem> MealItems { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }
        public DbSet<UserInjury> UserInjuries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply configurations
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new WorkoutPlanConfiguration());
            builder.ApplyConfiguration(new WorkoutPlanExerciseConfiguration());
            builder.ApplyConfiguration(new WorkoutScheduleConfiguration());
            builder.ApplyConfiguration(new ExerciseConfiguration());
            builder.ApplyConfiguration(new ExerciseProgressConfiguration());
            builder.ApplyConfiguration(new ExerciseAnalysisConfiguration());
            builder.ApplyConfiguration(new MealPlanConfiguration());
            builder.ApplyConfiguration(new MealConfiguration());
            builder.ApplyConfiguration(new MealItemConfiguration());
            builder.ApplyConfiguration(new FoodItemConfiguration());
            builder.ApplyConfiguration(new UserGoalConfiguration());
            builder.ApplyConfiguration(new UserInjuryConfiguration());

            // Configure enum conversions
            builder.Entity<User>()
                .Property(u => u.Gender)
                .HasConversion<string>();

            builder.Entity<WorkoutPlan>()
                .Property(wp => wp.DifficultyLevel)
                .HasConversion<string>();

            builder.Entity<Meal>()
                .Property(m => m.MealTime)
                .HasConversion<string>();

            builder.Entity<UserGoal>()
                .Property(ug => ug.GoalType)
                .HasConversion<string>();

            builder.Entity<UserInjury>()
                .Property(ui => ui.InjuryType)
                .HasConversion<string>();

            // Configure relationships
            builder.Entity<User>()
                .HasMany(u => u.WorkoutPlans)
                .WithOne(wp => wp.User)
                .HasForeignKey(wp => wp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.WorkoutSchedules)
                .WithOne(ws => ws.User)
                .HasForeignKey(ws => ws.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.MealPlans)
                .WithOne(mp => mp.User)
                .HasForeignKey(mp => mp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.ExerciseProgresses)
                .WithOne(ep => ep.User)
                .HasForeignKey(ep => ep.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.ExerciseAnalyses)
                .WithOne(ea => ea.User)
                .HasForeignKey(ea => ea.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.UserGoals)
                .WithOne(ug => ug.User)
                .HasForeignKey(ug => ug.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.UserInjuries)
                .WithOne(ui => ui.User)
                .HasForeignKey(ui => ui.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 