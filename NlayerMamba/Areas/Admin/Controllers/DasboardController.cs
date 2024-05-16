using Microsoft.AspNetCore.Mvc;

namespace NlayerMamba.Areas.Admin.Controllers
{
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
