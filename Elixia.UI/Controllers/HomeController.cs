using Elixia.Shared.DTOs;
using Elixia.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Elixia.UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Login()
    {
        var loginDTO = new LoginDTO();
        return View(loginDTO);
    }

    [HttpPost]
    public IActionResult Login(LoginDTO loginDTO)
    {
        return View(loginDTO);
    }
    public IActionResult LoginWithPassword()
    {
        var loginPasswordDTO = new LoginPasswordDTO();
        return View(loginPasswordDTO);
    }
    [HttpPost]
    public IActionResult LoginWithPassword(LoginPasswordDTO loginPasswordDTO)
    {
        return View(loginPasswordDTO);
    }

    public IActionResult Index()
    {
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
