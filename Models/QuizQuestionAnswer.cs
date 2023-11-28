using System.ComponentModel.DataAnnotations;

namespace vyacheslav.vorotov._932101.labs.Models
{
    public class QuizQuestionAnswer
    {
        [Required]
        public int answer {get;set;}

        public QuizQuestionAnswer(int answer)
        {
            this.answer = answer;
        }
    }
}