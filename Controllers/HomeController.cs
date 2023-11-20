using Microsoft.AspNetCore.Mvc;

namespace TP11.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Partidos()
    {
        ViewBag.partidos = BD.ObtenerPartidos();
        return View("Partidos");
    }
}
