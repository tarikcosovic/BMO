using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;
using BMO.Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMO.Api.Controllers
{
    [ApiController]
    [Route("api/scores")]
    public class ScoreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ScoreController> _logger;
        private readonly IMapper _mapper;
        public ScoreController(IUnitOfWork unitOfWork, ILogger<ScoreController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("create")]
        [Authorize("User")]
        public async Task<IActionResult> CreateScoreAsync(CreateScoreRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            Score response = new();

            try
            {
                _mapper.Map(request, response);

                await _unitOfWork.Scores.AddAsync(response);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: CreateScore - Score");
            }

            return new JsonResult(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetScoresAsync(int gameId = 0, int playerId = 0)
        {
            IEnumerable<Score> response = Enumerable.Empty<Score>();

            try
            {
                //Performance task - filter the data on ef level, not when you've already returned all of the objects
                var query = await _unitOfWork.Scores.GetAllAsync();

                if (gameId != 0)
                {
                    query = query.Where(x => x.GameId == gameId);
                }

                if (playerId != 0)
                {
                    query = query.Where(x => x.PlayerId == playerId);
                }

                response = query.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetScores - Score");
            }

            return new JsonResult(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetScoreAsync(long id)
        {
            Score? response = null;

            try
            {
                response = await _unitOfWork.Scores.GetAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetScore - Score");
            }

            return new JsonResult(response);
        }

        [Authorize("Administrator")]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteScoreAsync(int id)
        {
            Score? response = null;

            try
            {
                response = await _unitOfWork.Scores.GetAsync(id);

                if (response is not null)
                {
                    _unitOfWork.Scores.Remove(response);

                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while making an api call: Delete Score with id: {id}");
            }

            return new JsonResult(response);
        }
    }
}
