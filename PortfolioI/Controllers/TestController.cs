// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here!
namespace PortfolioI.Controllers;

public class TestController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "This is my Index!";
    }

    [HttpGet("projects")]
    public string Project()
    {
        return "These are my projects.";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my Contact!";
    }
}