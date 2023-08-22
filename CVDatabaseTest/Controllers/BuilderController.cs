using Microsoft.AspNetCore.Mvc;

namespace CVDatabaseTest.Controllers;

public class BuilderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult GetCv()
    {
        return View();
    }
}