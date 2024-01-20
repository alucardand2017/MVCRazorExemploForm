using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AULA06APPENQUETES.Models;

namespace AULA06APPENQUETES.Controllers;

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

    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Responder(Resposta resposta)
    {
        if(ModelState.IsValid)
        {
        Repositorio.AdicionaResposta(resposta);
        return View("RespostaSucesso");
        }
        else
        {
            return View(resposta);
        }
    }

    public IActionResult Resultado()
    {
        return View(Repositorio.Respostas);
    }
}
