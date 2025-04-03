using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class WorkoutPlanConfiguration : IEntityTypeConfiguration<WorkoutPlan>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlan> builder)
        {
            builder.Property(wp => wp.UserId)
                .IsRequired();

            builder.Property(wp => wp.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(wp => wp.Description)
                .HasMaxLength(1000);

            builder.Property(wp => wp.StartDate)
                .IsRequired();

            builder.Property(wp => wp.DifficultyLevel)
                .IsRequired()
                .HasMaxLength(50)
                .HasConversion<string>();

            builder.Property(wp => wp.FrequencyPerWeek)
                .IsRequired();

            builder.Property(wp => wp.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(wp => wp.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(wp => wp.User)
                .WithMany(u => u.WorkoutPlans)
                .HasForeignKey(wp => wp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(wp => wp.WorkoutPlanExercises)
                .WithOne(wpe => wpe.WorkoutPlan)
                .HasForeignKey(wpe => wpe.WorkoutPlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(wp => wp.WorkoutSchedules)
                .WithOne(ws => ws.WorkoutPlan)
                .HasForeignKey(ws => ws.WorkoutPlanId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 