using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class FoodItemConfiguration : IEntityTypeConfiguration<FoodItem>
    {
        public void Configure(EntityTypeBuilder<FoodItem> builder)
        {
            builder.Property(fi => fi.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(fi => fi.Description)
                .HasMaxLength(1000);

            builder.Property(fi => fi.CaloriesPerServing)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(fi => fi.ProteinPerServing)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(fi => fi.CarbsPerServing)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(fi => fi.FatPerServing)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(fi => fi.ServingUnit)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(fi => fi.ServingSize)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(fi => fi.Notes)
                .HasMaxLength(1000);

            builder.Property(fi => fi.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(fi => fi.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasMany(fi => fi.MealItems)
                .WithOne(mi => mi.FoodItem)
                .HasForeignKey(mi => mi.FoodItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 