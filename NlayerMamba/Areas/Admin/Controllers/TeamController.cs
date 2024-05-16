using Microsoft.AspNetCore.Mvc;

namespace NlayerMamba.Areas.Admin.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
