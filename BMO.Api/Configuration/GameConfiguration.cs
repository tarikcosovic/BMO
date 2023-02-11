using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;

namespace BMO.Api.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(prop => prop.Description)
                .HasMaxLength(3000);

            builder.Property(prop => prop.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow);
                //.ValueGeneratedOnAdd(); - explore this

            builder.Property(prop => prop.LastModifiedDate)
                .HasDefaultValue(DateTime.UtcNow);
            //.ValueGeneratedOnAddOrUpdate() - explore this

            builder.HasData(
                new Game() { Id = 1, Name = "Space Invaders", Description = "An omage to one of the earliest video games released, the goal is to pan across a screen and shoot descending swarms of aliens, preventing them from reaching the bottom of the screen." },
                new Game() { Id = 2, Name = "Snake", Description = "The player controls a long, thin creature, resembling a snake, which roams(grid-based) around on a bordered plane, picking up food, trying to avoid hitting its own tail or the edges of the playing area. Each time the snake eats a piece of food, its tail grows longer, making the game increasingly difficult." },
                new Game() { Id = 3, Name = "Space Worms", Description = "World first BMO exclusive original game, specifically created for this game console. Space Worms is a grid-based puzzle, where each players move will take them to the edge of the grid. Collect the treasure to advance to the next level and achieve an all time highscore on the leaderboards!" }
            );

        }
    }
}
