using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;

namespace fitnessApp.Data.Configurations
{
    public class WorkoutScheduleConfiguration : IEntityTypeConfiguration<WorkoutSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkoutSchedule> builder)
        {
            builder.Property(ws => ws.WorkoutPlanId)
                .IsRequired();

            builder.Property(ws => ws.UserId)
                .IsRequired();

            builder.Property(ws => ws.ScheduledDate)
                .IsRequired();

            builder.Property(ws => ws.ScheduledTime)
                .IsRequired();

            builder.Property(ws => ws.IsCompleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(ws => ws.Notes)
                .HasMaxLength(1000);

            builder.Property(ws => ws.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(ws => ws.WorkoutPlan)
                .WithMany(wp => wp.WorkoutSchedules)
                .HasForeignKey(ws => ws.WorkoutPlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ws => ws.User)
                .WithMany(u => u.WorkoutSchedules)
                .HasForeignKey(ws => ws.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 