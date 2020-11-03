using Api_Project.Data;
using Api_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {

        private readonly IGamesRepo _repository;

        public GamesController(IGamesRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Games>> GetAll()
        {
            var item = _repository.getGamesList();
            return Ok(item);
        }
    }
}
