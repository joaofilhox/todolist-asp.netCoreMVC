using Microsoft.AspNetCore.Mvc;
using TWTodoList.Models;

namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        // Formas de passar dados da Controller para a View
        //ViewData["apresentacao"] = "Hello, World!";
        //ViewData.Add("apresentacao", "Hello World Update!");

        var todo = new Todo         {
            Title = "Estudar ASP.NET Core",
            Description = "Estudar ASP.NET Core MVC e Razor Pages"
        };
        
        //ViewData["todo"] = todo;
        ViewBag.Todo = todo;

        TempData["message"] = "Mensagem de teste com TempData";
        return View();
    }
    public IActionResult Message()
    {
        return View();
    }
}
