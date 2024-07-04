using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DataAccess;
using MinhaPrimeiraAPI.Domain;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : Controller
    {
        private readonly MinhaAppContext _db;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(ILogger<QuestionController> logger, MinhaAppContext db)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet("view")]
        public IActionResult GetView()
        {
            ViewData["Title"] = "Testando a view";
            ViewData["Message"] = "teesssteeeeeeee.";

            return View("./Index");
        }
    }

}
