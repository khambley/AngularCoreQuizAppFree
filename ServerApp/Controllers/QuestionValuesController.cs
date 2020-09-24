using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ServerApp.Controllers {
    [Route("api/questions")]
    [ApiController]
    public class QuestionValuesController : Controller {
        private DataContext context;

        public QuestionValuesController(DataContext ctx){
            context = ctx;
        }

        [HttpGet("{id}")]
        public Question GetQuestion(int id) {
            //System.Threading.Thread.Sleep(5000);
            Question result = context.Questions
                .Include(q => q.Quiz).ThenInclude(qu => qu.Questions)
                .FirstOrDefault(q => q.QuestionId == id);
            
            if (result != null) {
                if (result.Quiz != null) {
                    result.Quiz.Questions = result.Quiz.Questions.Select(qu => 
                        new Question {
                            QuestionId = qu.QuestionId,
                            Text = qu.Text,
                            CorrectAnswer = qu.CorrectAnswer,
                            WrongAnswer1 = qu.WrongAnswer1,
                            WrongAnswer2 = qu.WrongAnswer2,
                            WrongAnswer3 = qu.WrongAnswer3
                        });
                }

            }
            return result;
        }   
    }
}