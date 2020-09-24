using System.Collections.Generic;

namespace ServerApp.Models {
    public class Quiz {
        public int QuizId { get; set; }
        public string Title { get; set; }

        public IEnumerable<Question> Questions {get; set;}
        
    }
}