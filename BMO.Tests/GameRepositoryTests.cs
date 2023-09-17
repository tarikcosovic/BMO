using BMO.Api.Migrations;
using Microsoft.EntityFrameworkCore;
using NSubstitute.ReturnsExtensions;
using System.Linq.Expressions;

namespace BMO.Tests
{
    public class GameRepositoryTests
    {
        //TODO: THINK AGAIN ABOUT TESTING ADD AND ADDASYNC same for remove
        private readonly IGenericRepository<Game> _gameRepository;

        public GameRepositoryTests()
        {
            _gameRepository = Substitute.For<IGenericRepository<Game>>();
        }

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

        [Fact]
        public async Task GetAsync_ShouldReturnGame()
        {
            var game = new Game() { Name = "Test_Game", Description = "Test_Description" };

            _gameRepository.GetAsync(Arg.Any<int>()).Returns(game);

            var result = await _gameRepository.GetAsync(1);

            Assert.NotNull(result);
            Assert.Equal(result, game);
            Assert.IsType<Game>(game);
            Assert.Equal(result.Name, game.Name);
            Assert.Equal(result.Description, game.Description);
        }

        [Fact]
        public async Task GetAsync_ShouldReturnNull_WhenGameDoesNotExist()
        {
            _gameRepository.GetAsync(Arg.Any<int>()).ReturnsNull();

            var result = await _gameRepository.GetAsync(1);

            Assert.Null(result);
        }

        [Fact]
        public void Where_ShouldReturnGames_WhenGameMatchesCriteria()
        {
            //Arrange
            var expectedGames = new List<Game>() 
            { 
                new Game { Id = 1, Name = "Test_Game" },
                new Game { Id = 2, Name = "Test_Game" }
            };

            _gameRepository.Where(Arg.Any<Expression<Func<Game, bool>>>())
                .Returns(expectedGames);
            //Act
            var result = _gameRepository.Where(x => x.Name == "Test_Game");

            //Assert
            Assert.True(result.Any());
        }

        [Fact]
        public void Where_ShouldReturnNull_WhenNoGameMatchesCriteria()
        {
            //Arrange
            var expectedGames = new List<Game>()
            {
                new Game { Id = 1, Name = "Test_Game" },
                new Game { Id = 2, Name = "Test_Game" }
            };

            _gameRepository.Where(Arg.Any<Expression<Func<Game, bool>>>())
                .ReturnsNull();
            //Act
            var result = _gameRepository.Where(x => x.Id == 999);

            //Assert
            Assert.Null(result);
        }
    }
}