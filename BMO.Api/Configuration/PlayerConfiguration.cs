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

            builder.HasData(
                new Player(1, new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"), "sonic86"),
                new Player(2, new Guid("53116ce8-5619-11ee-8c99-0242ac120002"), "john_doe"),
                new Player(3, new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"), "replicantroy"),
                new Player(4, new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"), "michael_scarn"),
                new Player(5, new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"), "zhu")
            );
        }
    }
}
