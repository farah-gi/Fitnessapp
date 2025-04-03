using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using fitnessApp.Models;
using fitnessApp.Models.Enums;

namespace fitnessApp.Data.Configurations
{
    public class UserInjuryConfiguration : IEntityTypeConfiguration<UserInjury>
    {
        public void Configure(EntityTypeBuilder<UserInjury> builder)
        {
            builder.Property(ui => ui.UserId)
                .IsRequired();

            builder.Property(ui => ui.InjuryType)
                .IsRequired()
                .HasMaxLength(50)
                .HasConversion<string>();

            builder.Property(ui => ui.Description)
                .HasMaxLength(1000);

            builder.Property(ui => ui.StartDate)
                .IsRequired();

            builder.Property(ui => ui.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(ui => ui.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Relationships
            builder.HasOne(ui => ui.User)
                .WithMany(u => u.UserInjuries)
                .HasForeignKey(ui => ui.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 