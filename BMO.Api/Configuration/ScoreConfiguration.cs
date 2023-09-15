using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BMO.Api.Configuration
{
    public class ScoreConfiguration : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.HasKey(key => key.ScoreId);

            builder.HasOne(pt => pt.Player)
                .WithMany(p => p.Scores)
                .HasForeignKey(fk => fk.PlayerId)
                .IsRequired();

            builder.HasOne(pt => pt.Game)
                .WithMany(p => p.Scores)
                .HasForeignKey(fk => fk.GameId)
                .IsRequired();

            builder.Property(prop => prop.Value)
                .IsRequired();

            builder.Property(prop => prop.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
