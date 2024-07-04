using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.DataAccess;
using MinhaPrimeiraAPI.DataTransferObject;
using MinhaPrimeiraAPI.Domain;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : Controller
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

        [HttpGet("new")]
        public IActionResult NewGameView()
        {
            return View("./NewGame");
        }

        [HttpPost("new")]
        public IActionResult CreateNewGame([FromForm] NewGameDTO newGame)
        {

            if (!ModelState.IsValid)
            {
                // redireciona para erro
                return View("NewGameError");
            }

            var g = new Game()
            {
                Theme = newGame.Theme,
                Questions = new List<Question>()
            };

            foreach(var q in newGame.Questions)
            {
                var question = new Question()
                {
                    Game = g,
                    QuestionText = q.Description,
                    Options = new List<Option>()
                };

                foreach (var o in q.Options)
                {
                    question.Options.Add(new Option
                    {
                        Question = question,
                        Description = o.Description,
                        IsCorrect = o.IsCorrectValue,
                    });
                }

                g.Questions.Add(question);
            }

            _db.Games.Add(g);

            _db.SaveChanges();


            // poderia redirecionar para uma pagina de sucesso
            return View("NewGameSuccess", new GameDTO
            {
                GameId = g.GameId,
                Theme = newGame.Theme,
                Questions = g.Questions.Select(q => new QuestionDTO
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                }).ToList()
            });

            //return Created($"game/{g.GameId}", new GameDTO 
            //{ 
            //    GameId = g.GameId,
            //    Theme = newGame.Theme,
            //    Questions = g.Questions.Select(q =>  new QuestionDTO
            //    {
            //        QuestionId= q.QuestionId,
            //        QuestionText = q.QuestionText,
            //    }).ToList()
            //});
        }

        //[HttpPost]
        //public IActionResult NewGame(NewGameDTO model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Process the model
        //        // Save to database or perform any other action

        //        return RedirectToAction("Success"); // Redirect to a success page or any other action
        //    }

        //    return View(model);
        //}
    }
}