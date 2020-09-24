using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers {
    [Route("api/questions")]
    [ApiController]
    public class QuestionValuesController : Controller {
        private DataContext context;

        public QuestionValuesController(DataContext ctx){
            context = ctx;
        }

        [HttpGet("{id}")]
        public Question GetQuestion(int id){
            return context.Questions.Find(id);
        }
    }
}