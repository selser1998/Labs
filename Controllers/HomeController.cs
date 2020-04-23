using Microsoft.AspNetCore.Mvc;

namespace WebSocketChat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
