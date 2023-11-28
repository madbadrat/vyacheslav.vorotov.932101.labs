using vyacheslav.vorotov._932101.labs.Models;

namespace vyacheslav.vorotov._932101.labs.Services
{
    public class QuizServiceImplementation : QuizService
    {
        Random random = new();
        public static Quiz? currentQuiz;

        public QuizQuestion addNewQuestion(Quiz quiz)
        {
            int FirstTerm = random.Next(0,11);
            int SecondTerm = random.Next(0,11);
            string operation = "+";
            int answer = FirstTerm + SecondTerm;

            if (random.Next(0, 3) > 0)
            {
                operation = "-";
                answer = FirstTerm - SecondTerm;
            }

            QuizQuestion quest = new(FirstTerm, SecondTerm, operation, answer);
            quiz.addQuestion(quest);

            return quest;
        }

        public void answerLastQuestion(QuizQuestionAnswer answer, Quiz quiz)
        {
            if (quiz.quizQuestionAnswers.Count < quiz.quizQuestions.Count)
                quiz.addAnswerQuestion(answer);
        }

        public void finish(Quiz quiz)
        {
            quiz.reset();
        }

        public QuizQuestion getCurrentQuestion(Quiz quiz)
        {
            if (quiz.quizQuestions.Count == 0) return addNewQuestion(quiz);
            return quiz.quizQuestions.Last();
        }

        public Quiz getCurrentQuiz()
        {
            if (currentQuiz == null) currentQuiz = new Quiz();
            return currentQuiz;
        }
    }
}