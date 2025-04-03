using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;

namespace fitnessApp.Data.Configurations
{
    public class MealPlanConfiguration : IEntityTypeConfiguration<MealPlan>
    {
        public void Configure(EntityTypeBuilder<MealPlan> builder)
        {
            builder.Property(mp => mp.UserId)
                .IsRequired();

            builder.Property(mp => mp.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(mp => mp.Description)
                .HasMaxLength(1000);

            builder.Property(mp => mp.StartDate)
                .IsRequired();

            builder.Property(mp => mp.DailyCalorieTarget)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mp => mp.DailyProteinTarget)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mp => mp.DailyCarbsTarget)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mp => mp.DailyFatTarget)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mp => mp.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(mp => mp.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(mp => mp.User)
                .WithMany(u => u.MealPlans)
                .HasForeignKey(mp => mp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(mp => mp.Meals)
                .WithOne(m => m.MealPlan)
                .HasForeignKey(m => m.MealPlanId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 