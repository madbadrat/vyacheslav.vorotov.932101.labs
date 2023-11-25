using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vyacheslav.vorotov._932101.labs.Models;

namespace vyacheslav.vorotov._932101.labs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewModel() 
    {
        CalcModel model = new CalcModel();
        return View(model);
    }

    public IActionResult ViewBagMethod()
    {
        CalcModel model = new CalcModel();
        ViewBag.FirstTerm = model.FirstTerm;
        ViewBag.SecondTerm = model.SecondTerm;
        return View();
    }

    public IActionResult ViewDataCalc()
    {
        CalcModel model = new CalcModel();
        ViewData["FirstTerm"] = model.FirstTerm;
        ViewData["SecondTerm"] = model.SecondTerm;
        return View();
    }

    public IActionResult InjectionCalc()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
