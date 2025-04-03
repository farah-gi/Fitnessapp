using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class WorkoutPlanExerciseConfiguration : IEntityTypeConfiguration<WorkoutPlanExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlanExercise> builder)
        {
            builder.HasKey(wpe => wpe.Id);

            builder.Property(wpe => wpe.Sets)
                .IsRequired();

            builder.Property(wpe => wpe.Repetitions)
                .IsRequired();

            builder.Property(wpe => wpe.RestTimeInSeconds)
                .IsRequired();

            builder.Property(wpe => wpe.WeightInKg)
                .HasPrecision(10, 2);

            builder.Property(wpe => wpe.DurationInMinutes)
                .HasPrecision(10, 2);

            builder.Property(wpe => wpe.Notes)
                .HasMaxLength(1000);

            builder.Property(wpe => wpe.DifficultyLevel)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(wpe => wpe.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(wpe => wpe.WorkoutPlan)
                .WithMany(wp => wp.WorkoutPlanExercises)
                .HasForeignKey(wpe => wpe.WorkoutPlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(wpe => wpe.Exercise)
                .WithMany(e => e.WorkoutPlanExercises)
                .HasForeignKey(wpe => wpe.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 