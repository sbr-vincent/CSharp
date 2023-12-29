// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here!
namespace FirstWeb.Controllers;

public class HelloController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hello World from HelloController!";
    }

    [HttpGet("greet/{name}")]
    public string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}