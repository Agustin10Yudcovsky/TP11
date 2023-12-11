using Microsoft.AspNetCore.Mvc;

namespace TP11.Controllers;

public class HomeController : Controller
{
    public IActionResult Inicio()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Partidos()
    {
        ViewBag.partidos = BD.ObtenerPartidos();
        return View("Partidos");
    }

    public IActionResult Entradas(){
    ViewBag.ListaEntradas = BD.ObtenerEntradas();
    return View("Entradas");
    }

    public IActionResult Noticias(){
        ViewBag.noticias = BD.ObtenerNoticias();
        return View("Noticias");
    }

    public IActionResult MisEntradas(){
        return View();
    }

    public  IActionResult ComprarEntradas(int entradaid){
        BD.ActualizarEntrada(entradaid);
        return RedirectToAction("Inicio");
    }

    public IActionResult EntradasPartido(int idpartido){
        ViewBag.ListaEntradas = BD.ObtenerEntradasId(idpartido);
        return View("Entradas");
    }

     public string EstadioPorPartido(int Idpartido){
       return  BD.ObetenerEstXPar(Idpartido);
    }

}
