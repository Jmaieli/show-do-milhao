using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.DataAccess;
using MinhaPrimeiraAPI.DataTransferObject;
using MinhaPrimeiraAPI.Domain;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly MinhaAppContext _db;

        public GameController(MinhaAppContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var game = _db.Games
                .Include(g => g.Questions)
                .SingleOrDefault(g => g.GameId == id);

            if (game is null)
                return NotFound("jogo não encontrado");

            // coverter pra um DTO
            return Ok(new GameDTO
            {
                GameId = game.GameId,
                Questions = game.Questions.Select(q => new QuestionDTO
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                }).ToList(),
            });
        }
    }
}