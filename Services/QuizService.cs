using vyacheslav.vorotov._932101.labs.Models;

namespace vyacheslav.vorotov._932101.labs.Services
{
    public interface QuizService
    {
        public Quiz getCurrentQuiz();
        public QuizQuestion addNewQuestion(Quiz quiz);
        public QuizQuestion getCurrentQuestion(Quiz quiz);
        public void answerLastQuestion(QuizQuestionAnswer answer, Quiz quiz);
        public void finish(Quiz quiz);
    }
}