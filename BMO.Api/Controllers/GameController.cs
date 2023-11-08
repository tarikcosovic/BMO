using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;
using BMO.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMO.Api.Controllers
{
    [ApiController]
    [Authorize("Administrator")]
    [Route("api/games")]
    public class GameController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GameController> _logger;
        private readonly IMapper _mapper;
        public GameController(IUnitOfWork unitOfWork, ILogger<GameController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateGameAsync(CreateGameRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            Game response = new();

            try
            {
                _mapper.Map(request, response);

                await _unitOfWork.Games.AddAsync(response);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: Create - Game");
            }

            return new JsonResult(response);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetGamesAsync()
        {
            IEnumerable<Game> response = Enumerable.Empty<Game>();

            try
            {
                response = await _unitOfWork.Games.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetAll - Game");
            }

            return new JsonResult(response);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameAsync(int id)
        {
            Game? response = null;

            try
            {
                response = await _unitOfWork.Games.GetAsync(id);

                if(response == null)
                {
                    return new NotFoundResult();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetById - Game");
            }

            return new JsonResult(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteGameAsync(int id)
        {
            Game? response = null;

            try
            {
                response = await _unitOfWork.Games.GetAsync(id);

                if (response is not null)
                {
                    _unitOfWork.Games.Remove(response);

                    await _unitOfWork.SaveChangesAsync();
                }
                else return new NotFoundResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while making an api call: Delete Game with id: {id}");
            }

            return new JsonResult(response);
        }
    }
}
