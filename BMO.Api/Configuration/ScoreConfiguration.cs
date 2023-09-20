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
                .OnDelete(DeleteBehavior.ClientCascade)
                .IsRequired();

            builder.HasOne(pt => pt.Game)
                .WithMany(p => p.Scores)
                .HasForeignKey(fk => fk.GameId)
                .OnDelete(DeleteBehavior.ClientCascade)
                .IsRequired();

            builder.Property(prop => prop.Value)
                .IsRequired();

            builder.Property(prop => prop.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.HasData(
                new Score(1, 1, 1, 3),
                new Score(2, 2, 1, 7),
                new Score(3, 3, 1, 11),

                new Score(4, 1, 2, 5),
                new Score(5, 2, 2, 14),
                new Score(6, 3, 2, 17),

                new Score(7, 1, 3, 1),
                new Score(8, 2, 3, 8),
                new Score(9, 3, 3, 5),

                new Score(10, 1, 4, 20),
                new Score(11, 2, 4, 7),
                new Score(12, 3, 4, 4),

                new Score(13, 1, 5, 11),
                new Score(14, 2, 5, 24),
                new Score(15, 3, 5, 13)
            );
        }
    }
}
