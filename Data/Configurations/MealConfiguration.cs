using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(m => m.MealPlanId)
                .IsRequired();

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.Description)
                .HasMaxLength(1000);

            builder.Property(m => m.MealTime)
                .IsRequired()
                .HasMaxLength(50)
                .HasConversion<string>();

            builder.Property(m => m.TotalCalories)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(m => m.TotalProtein)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(m => m.TotalCarbs)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(m => m.TotalFat)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(m => m.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(m => m.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(m => m.MealPlan)
                .WithMany(mp => mp.Meals)
                .HasForeignKey(m => m.MealPlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.MealItems)
                .WithOne(mi => mi.Meal)
                .HasForeignKey(mi => mi.MealId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 