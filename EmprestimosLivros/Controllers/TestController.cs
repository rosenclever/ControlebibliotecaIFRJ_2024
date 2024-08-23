using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
