using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BMO.Api.Configuration
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Device)
                .WithMany(prop => prop.Players)
                .HasForeignKey(key => key.DeviceId);

            builder.Property(prop => prop.Username)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(prop => prop.CreatedDate)
            .HasDefaultValue(DateTime.UtcNow);

            builder.Property(prop => prop.LastModifiedDate)
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
