using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vyacheslav.vorotov._932101.labs.Models;
using vyacheslav.vorotov._932101.labs.Services;

namespace vyacheslav.vorotov._932101.labs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private CalcService _calcService;

    private string parseData()
    {
        try
        {
            int FirstTerm = int.Parse(Request.Form["FirstTerm"]);
            int SecondTerm = int.Parse(Request.Form["SecondTerm"]);
            string operation = Request.Form["operation"];
            return _calcService.Calc(FirstTerm, SecondTerm, operation);
        }
        catch(Exception exception)
        {
            return exception.Message;
        }
    }

    public HomeController(ILogger<HomeController> logger, CalcService calcService)
    {
        _logger = logger;
        _calcService = calcService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Manual()
    {
        if (Request.Method == "GET")
            return View("InputView");
        else
        {
            ViewData["result"] = parseData();
            return View("Result");
        }
    }

    [HttpGet, ActionName("ManualSeparate")]
    public IActionResult ManualSeparateGet()
    {
        return View("InputView");
    }

    [HttpPost, ActionName("ManualSeparate")]
    public IActionResult ManualSeparatePost()
    {
        ViewData["result"] = parseData();
        return View("Result");
    }

    [HttpGet]
    public IActionResult ModelBindingSeparate()
    {
        return View("InputView");
    }

    [HttpPost]
    public IActionResult ModelBindingSeparate(int FirstTerm, int SecondTerm, string operation)
    {
        ViewData["result"] = _calcService.Calc(FirstTerm, SecondTerm, operation);
        return View("Result");
    }

    [HttpGet]
    public IActionResult ModelBinding()
    {
        return View("InputView");
    }

    [HttpPost]
    public IActionResult ModelBinding(CalcExpressionModel expressionModel)
    {
        ViewData["result"] = _calcService.Calc(expressionModel);
        return View("Result");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
