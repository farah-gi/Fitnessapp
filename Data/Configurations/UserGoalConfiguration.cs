using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class UserGoalConfiguration : IEntityTypeConfiguration<UserGoal>
    {
        public void Configure(EntityTypeBuilder<UserGoal> builder)
        {
            builder.Property(ug => ug.UserId)
                .IsRequired();

            builder.Property(ug => ug.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(ug => ug.Description)
                .HasMaxLength(1000);

            builder.Property(ug => ug.GoalType)
                .IsRequired()
                .HasMaxLength(50)
                .HasConversion<string>();

            builder.Property(ug => ug.TargetValue)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(ug => ug.StartDate)
                .IsRequired();

            builder.Property(ug => ug.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(ug => ug.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(ug => ug.User)
                .WithMany(u => u.UserGoals)
                .HasForeignKey(ug => ug.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 