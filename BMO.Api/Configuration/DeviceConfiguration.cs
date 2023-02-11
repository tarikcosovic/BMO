using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BMO.Api.Configuration
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.SerialNumber)
                .IsRequired();

            builder.Property(prop => prop.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(prop => prop.LastModifiedDate)
                .HasDefaultValue(DateTime.UtcNow);

            // Registering our device - mocking a production api
            builder.HasData(new Device(1, "5c2f5351-d30a-40fb-9a87-ada20b610c2d", "Standard", "2.7.4", false));
        }
    }
}
