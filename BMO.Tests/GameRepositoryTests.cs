using System.Linq.Expressions;
using BMO.Api.Repositories.Interfaces;

namespace BMO.Tests
{
    public class GameRepositoryTests
    {
        private readonly IGenericRepository<Game> _gameRepository;

        public GameRepositoryTests()
        {
            _gameRepository = Substitute.For<IGenericRepository<Game>>();
        }

        [Fact]
        public void Add_ShouldAddGameToDbContext()
        {
            //Arrange
            var mockGame = new Game();

            //Act
            _gameRepository.Add(mockGame);

            //Assert
            _gameRepository.Received(1).Add(mockGame);
        }

        [Fact]
        public async Task AddAsync_ShouldAsyncAddGameToDbContext()
        {
            //Arrange
            var mockGame = new Game();

            //Act
            await _gameRepository.AddAsync(mockGame);

            //Assert
            await _gameRepository.Received(1).AddAsync(mockGame);
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
        public async Task Where_ShouldReturnGames_WhenGameMatchesCriteria()
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
            var result = await _gameRepository.Where(x => x.Name == "Test_Game");

            //Assert
            Assert.True(result.Any());
        }

        [Fact]
        public async Task Where_ShouldReturnNull_WhenNoGameMatchesCriteria()
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
            var result = await _gameRepository.Where(x => x.Id == 999);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void Remove_ShouldRemoveGameFromDbContext()
        {
            //Arrange
            var mockGame = new Game();

            //Act
            _gameRepository.Remove(mockGame);

            //Assert
            _gameRepository.Received(1).Remove(mockGame);
        }
    }
}