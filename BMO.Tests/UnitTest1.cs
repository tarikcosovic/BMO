using BMO.Api.Models;
using BMO.Api.Repositories;
using NSubstitute;

namespace BMO.Tests
{
    public class GameRepositoryTests
    {
        private readonly IGenericRepository<Game> _gameRepository = Substitute.For<IGenericRepository<Game>>();

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllGames()
        {
            //Arrange
            var expectedGames = new List<Game>
            {
                new Game { Id = 1, Name = "Game 1" },
                new Game { Id = 2, Name = "Game 2" },
            };

            _gameRepository.GetAllAsync().Returns(expectedGames);

            // Act
            var result = await _gameRepository.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedGames.Count, result.Count());
        }
    }
}