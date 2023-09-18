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

            builder.Property(prop => prop.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(prop => prop.LastModifiedDate)
                .HasDefaultValue(DateTime.UtcNow);

            // Registering our devices - mocking a manufacturing api
            builder.HasData(
                new Device(new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"), "Standard", "2.7.4", false),
                new Device(new Guid("53116ce8-5619-11ee-8c99-0242ac120002"), "Standard", "2.7.4", false),
                new Device(new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"), "Standard", "2.7.4", false),
                new Device(new Guid("b5e2f724-ec83-4949-a489-8df81aba91ee"), "Standard", "2.7.4", false),
                new Device(new Guid("312f481a-7d97-4905-8aaa-f7a73bd91e6c"), "Standard", "2.7.4", false),
                new Device(new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"), "Standard", "2.7.4", false),
                new Device(new Guid("f11c94c8-08f1-463f-8b04-6f0d080ae94c"), "Standard", "2.7.4", false),
                new Device(new Guid("766c729a-e197-4344-b24a-9a3f3a4da25a"), "Standard", "3.0.4", false),
                new Device(new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"), "Standard", "3.0.4", false),
                new Device(new Guid("5c2f5351-d30a-40fb-9a87-ada20b610c2d"), "Standard", "3.0.4", false),
                new Device(new Guid("28e47bae-64e2-4fbf-9c3a-249dd8bff154"), "Premium", "3.0.4", true),
                new Device(new Guid("12fabb0a-a8da-4884-b062-31950a6ed997"), "Deluxe", "3.0.4", true)
            );

        }
    }
}
