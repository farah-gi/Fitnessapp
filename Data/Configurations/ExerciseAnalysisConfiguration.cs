using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;

namespace fitnessApp.Data.Configurations
{
    public class ExerciseAnalysisConfiguration : IEntityTypeConfiguration<ExerciseAnalysis>
    {
        public void Configure(EntityTypeBuilder<ExerciseAnalysis> builder)
        {
            builder.Property(ea => ea.ExerciseId)
                .IsRequired();

            builder.Property(ea => ea.UserId)
                .IsRequired();

            builder.Property(ea => ea.Date)
                .IsRequired();

            builder.Property(ea => ea.FormScore)
                .IsRequired()
                .HasPrecision(3, 1);

            builder.Property(ea => ea.EffortScore)
                .IsRequired()
                .HasPrecision(3, 1);

            builder.Property(ea => ea.Notes)
                .HasMaxLength(1000);

            builder.Property(ea => ea.Recommendations)
                .HasMaxLength(1000);

            builder.Property(ea => ea.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(ea => ea.Exercise)
                .WithMany(e => e.ExerciseAnalyses)
                .HasForeignKey(ea => ea.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ea => ea.User)
                .WithMany(u => u.ExerciseAnalyses)
                .HasForeignKey(ea => ea.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 