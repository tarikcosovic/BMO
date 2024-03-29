﻿using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;
using BMO.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMO.Api.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GameController> _logger;
        private readonly IMapper _mapper;
        public PlayerController(IUnitOfWork unitOfWork, ILogger<GameController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        /// <summary>
        /// When we try to connect to the bmo-services-network for the first time, this method is called prompting the user to insert a username.
        /// <para>
        /// Then that username and player id is stored in the local eeprom memory of the bmo-device so it is easily accessible and re-usable for upcoming requests
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        [HttpPost("create")]
        [Authorize("User")]
        public async Task<IActionResult> CreateUserAsync(CreatePlayerRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            Player response = new();

            try
            {
                var existingUsername = (await _unitOfWork.Players.Where(x => x.Username == request.Username && x.DeviceId == request.DeviceId)).FirstOrDefault();

                if (existingUsername != null)
                {
                    return new JsonResult(existingUsername);
                }
                else
                {
                    _mapper.Map(request, response);

                    await _unitOfWork.Players.AddAsync(response);

                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: CreateUsers - Player");
            }

            return new JsonResult(response);
        }

        [HttpGet]
        [Authorize("Administrator")]
        public async Task<IActionResult> GetUsersAsync()
        {
            IEnumerable<Player> response = Enumerable.Empty<Player>();

            try
            {
                response = await _unitOfWork.Players.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetUsers - Player");
            }

            return new JsonResult(response);
        }

        [HttpGet("{id}")]
        [Authorize("Administrator")]
        public async Task<IActionResult> GetUserAsync(int id)
        {
            Player? response = null;

            try
            {
                response = await _unitOfWork.Players.GetAsync(id);

                if(response == null)
                {
                    return new NotFoundResult();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetUser - Player");
            }

            return new JsonResult(response);
        }

        [Authorize("Administrator")]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            Player? response = null;

            try
            {
                response = await _unitOfWork.Players.GetAsync(id);

                if (response is not null)
                {
                    _unitOfWork.Players.Remove(response);

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