using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Gender)
                .IsRequired()
                .HasMaxLength(20)
                .HasConversion<string>();

            builder.Property(u => u.DateOfBirth)
                .IsRequired();

            builder.Property(u => u.Height)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(u => u.Weight)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(u => u.BodyFatPercentage)
                .HasPrecision(5, 2);

            builder.Property(u => u.MuscleMass)
                .HasPrecision(5, 2);

            builder.Property(u => u.MedicalConditions)
                .HasMaxLength(1000);

            builder.Property(u => u.Allergies)
                .HasMaxLength(1000);

            builder.Property(u => u.Medications)
                .HasMaxLength(1000);

            builder.Property(u => u.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(u => u.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(u => u.ProfilePictureUrl)
                .HasMaxLength(255);

            builder.Property(u => u.DietaryRestrictions)
                .HasMaxLength(500);

            builder.HasMany(u => u.WorkoutPlans)
                .WithOne(wp => wp.User)
                .HasForeignKey(wp => wp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.WorkoutSchedules)
                .WithOne(ws => ws.User)
                .HasForeignKey(ws => ws.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.ExerciseProgresses)
                .WithOne(ep => ep.User)
                .HasForeignKey(ep => ep.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.ExerciseAnalyses)
                .WithOne(ea => ea.User)
                .HasForeignKey(ea => ea.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.MealPlans)
                .WithOne(mp => mp.User)
                .HasForeignKey(mp => mp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.UserGoals)
                .WithOne(ug => ug.User)
                .HasForeignKey(ug => ug.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.UserInjuries)
                .WithOne(ui => ui.User)
                .HasForeignKey(ui => ui.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 