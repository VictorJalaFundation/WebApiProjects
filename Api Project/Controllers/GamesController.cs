using Api_Project.Data;
using Api_Project.Models;
using Api_Project.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace Api_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGamesService _gamesService;

        public GamesController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Games>> GetGames()
        {
            try
            {
                return Ok(_gamesService.GetGamesList());
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
                throw e;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Games>> GetGamesById(string id)
        {
            Games game = _gamesService.GetGamesById(id);
            if(game != null) {
                return Ok(game);
            }
            else
            {
                return NotFound();
            }

        }

    }
}
