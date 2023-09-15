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
        [Authorize("User")]
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


        [HttpGet("{id}")]
        [Authorize("User")]
        public async Task<IActionResult> GetScoreAsync(int id)
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
