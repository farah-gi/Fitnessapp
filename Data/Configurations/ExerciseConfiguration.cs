using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;

namespace fitnessApp.Data.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasMaxLength(1000);

            builder.Property(e => e.MuscleGroup)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Equipment)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DifficultyLevel)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Instructions)
                .HasMaxLength(1000);

            builder.Property(e => e.ImageUrl)
                .HasMaxLength(255);

            builder.Property(e => e.VideoUrl)
                .HasMaxLength(255);

            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(e => e.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasMany(e => e.WorkoutPlanExercises)
                .WithOne(wpe => wpe.Exercise)
                .HasForeignKey(wpe => wpe.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.ExerciseProgresses)
                .WithOne(ep => ep.Exercise)
                .HasForeignKey(ep => ep.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.ExerciseAnalyses)
                .WithOne(ea => ea.Exercise)
                .HasForeignKey(ea => ea.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 