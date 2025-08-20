using Microsoft.AspNetCore.Mvc;
using TWTodoList.Contexts;

namespace TWTodoList.Controllers;

public class TodoController : Controller
{
    private readonly AppDbContext _context;

    public TodoController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todos = _context.Todos.ToList();
        var viewModel = new ViewModels.ListTodoViewModel
        {
            Todos = todos
        };
        ViewData["Title"] = "Lista de Tarefas";
        return View(viewModel);
    }
}
