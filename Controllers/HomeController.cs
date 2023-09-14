using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica_pre_examen.Models;

namespace practica_pre_examen.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Alumnos = BD.ObtenerAlumnos();
        return View();
    }

    [HttpGet]
    public IActionResult DetalleAlumno(int idAlumno)
    {
        ViewBag.DetalleAlumno = BD.ObtenerAlumno(idAlumno);
        ViewBag.CursoAlumno = BD.ObtenerCurso(ViewBag.DetalleAlumno.idCurso);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
