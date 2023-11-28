using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vyacheslav.vorotov._932101.labs.Models;
using vyacheslav.vorotov._932101.labs.Services;

namespace vyacheslav.vorotov._932101.labs.Controllers;

public class HomeController : Controller
{
    private QuizService quizService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, QuizService quizService)
    {
        _logger = logger;
        this.quizService = quizService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet, ActionName("Quiz")]
    public IActionResult Quiz()
    {
        Quiz quiz = quizService.getCurrentQuiz();
        quiz.reset();
        quizService.addNewQuestion(quiz);

        return View("QuizQuestion", new QuizModel(quiz));
    }

    [HttpGet]
    public IActionResult GetResult()
    {
        Quiz quiz = quizService.getCurrentQuiz();
        return View("Result", quiz);
    }

    [HttpPost, ActionName("Quiz")]
    public IActionResult Quiz(int answer, string action)
    {
        Quiz quiz = quizService.getCurrentQuiz();

        if (!ModelState.IsValid)
        {
            QuizQuestion quizQuestion = quizService.getCurrentQuestion(quiz);
            return View("QuizQuestion", new QuizModel(quiz));
        }
        quizService.answerLastQuestion(new QuizQuestionAnswer(answer), quiz);
        if (action == "next")
        {
            QuizQuestion quizQuestion = quizService.addNewQuestion(quiz);
            return View("QuizQuestion", new QuizModel(quiz));
        }
        return View("Result", quiz);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
