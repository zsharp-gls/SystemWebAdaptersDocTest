using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SystemWebAdapters;

namespace SystemWeb_Core.Controllers
{
    [Session]
    public class SomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
