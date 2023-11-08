using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;
using BMO.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading;

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
            int minScore = 0;

            try
            {
                _mapper.Map(request, response);

                var scores = _unitOfWork.Scores.Where(x => x.GameId == request.GameId).Result;

                var currentPlayerHighscore = scores.FirstOrDefault(x => x.PlayerId == request.PlayerId)?.Value ?? 0;

                var scoreCount = scores.Count();

                minScore = scoreCount > 0 ? scores.Select(x => x.Value).Min() : 0;

                if ((scoreCount < 100 || request.Value > minScore) && (request.Value > currentPlayerHighscore))
                {
                    await _unitOfWork.Scores.AddAsync(response);

                    await _unitOfWork.SaveChangesAsync();

                    return new JsonResult(response);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: CreateScore - Score");
            }

            return new JsonResult(new { StatusCode = 200, Value = "The sent score is too low to enter the leaderboard top 100, the minimum to beat is " + minScore });
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetScoresAsync()
        {
            IEnumerable<Score> response = Enumerable.Empty<Score>();

            try
            {
                response = await _unitOfWork.Scores.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetScores - Score");
            }

            return new JsonResult(response);
        }

        [AllowAnonymous]
        [HttpGet("leaderboard/{gameId}")]
        public async Task<IActionResult> GetTopScoresAsync(int gameId)
        {
            IEnumerable<Score> response = Enumerable.Empty<Score>();

            try
            {
                response = await _unitOfWork.Scores.GetTopScoresAsync(gameId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetScores - Score");
            }

            return new JsonResult(response);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScoreAsync(long id)
        {
            Score? response = null;

            try
            {
                response = await _unitOfWork.Scores.GetAsync(id);

                if (response == null)
                {
                    return new NotFoundResult();
                }
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
                else return new NotFoundResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while making an api call: Delete Score with id: {id}");
            }

            return new JsonResult(response);
        }

        [Authorize("Administrator")]
        [HttpDelete("delete/{gameId}/{username}")]
        public async Task<IActionResult> DeleteScoreByUsernameAsync(int gameId, string username)
        {
            Score? response = null;

            try
            {
                response = await _unitOfWork.Scores.GetScoreByGameAndUsername(gameId, username);

                if (response is not null)
                {
                    _unitOfWork.Scores.Remove(response);

                    await _unitOfWork.SaveChangesAsync();
                } else return new NotFoundResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while making an api call: Delete Score with id: {gameId} and username: {username}");
            }

            return new JsonResult(response);
        }
    }
}
