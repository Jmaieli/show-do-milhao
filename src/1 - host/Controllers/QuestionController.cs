using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DataAccess;
using MinhaPrimeiraAPI.Domain;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<QuestionController> _logger;
        private readonly MinhaAppContext _db;

        public QuestionController(ILogger<QuestionController> logger, MinhaAppContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return _db.Players.ToList();
        }
    }
}
