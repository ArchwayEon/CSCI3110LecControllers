using CSCI3110LecControllers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSCI3110LecControllers.Controllers;

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

    public IActionResult Parameter(string? id)
    {
        ViewData["id"] = id;
        return View();
    }

    public IActionResult FourSegments(string code, string idNumber)
    {
        ViewData["code"] = code;
        ViewData["idNumber"] = idNumber;
        return View();
    }

    public IActionResult Bind([Bind(Prefix = "id")] string? name)
    {
        ViewData["name"] = name;
        return View();
    }

    public IActionResult Details(string? enumber)
    {
        ViewData["enumber"] = enumber;
        return View();
    }
    public IActionResult Variable(string? name, string? values)
    {
        ViewData["result"] = $"name = {name} values = {values}";
        string[] itemArray = (values != null) ? values.Split("/") : [];
        ViewData["itemStr"] = String.Join(" ", itemArray);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
