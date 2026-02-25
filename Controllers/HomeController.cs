using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08.Models;

namespace Mission08.Controllers;

public class HomeController : Controller
{
    public Mission08Context _context;

    public HomeController(Mission08Context temp)
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }
}