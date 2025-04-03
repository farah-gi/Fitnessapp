using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;

namespace fitnessApp.Data.Configurations
{
    public class ExerciseProgressConfiguration : IEntityTypeConfiguration<ExerciseProgress>
    {
        public void Configure(EntityTypeBuilder<ExerciseProgress> builder)
        {
            builder.Property(ep => ep.ExerciseId)
                .IsRequired();

            builder.Property(ep => ep.UserId)
                .IsRequired();

            builder.Property(ep => ep.Sets)
                .IsRequired();

            builder.Property(ep => ep.Repetitions)
                .IsRequired();

            builder.Property(ep => ep.Weight)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(ep => ep.Duration)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(ep => ep.Notes)
                .HasMaxLength(1000);

            builder.Property(ep => ep.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(ep => ep.Exercise)
                .WithMany(e => e.ExerciseProgresses)
                .HasForeignKey(ep => ep.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ep => ep.User)
                .WithMany(u => u.ExerciseProgresses)
                .HasForeignKey(ep => ep.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 