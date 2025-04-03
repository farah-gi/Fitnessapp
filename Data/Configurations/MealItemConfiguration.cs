using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class MealItemConfiguration : IEntityTypeConfiguration<MealItem>
    {
        public void Configure(EntityTypeBuilder<MealItem> builder)
        {
            builder.Property(mi => mi.MealId)
                .IsRequired();

            builder.Property(mi => mi.FoodItemId)
                .IsRequired();

            builder.Property(mi => mi.Quantity)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mi => mi.Calories)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mi => mi.Protein)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mi => mi.Carbs)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mi => mi.Fat)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(mi => mi.Notes)
                .HasMaxLength(1000);

            builder.Property(mi => mi.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(mi => mi.Meal)
                .WithMany(m => m.MealItems)
                .HasForeignKey(mi => mi.MealId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(mi => mi.FoodItem)
                .WithMany(fi => fi.MealItems)
                .HasForeignKey(mi => mi.FoodItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 