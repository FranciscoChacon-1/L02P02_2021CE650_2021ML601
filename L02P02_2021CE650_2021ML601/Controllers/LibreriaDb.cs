using Microsoft.AspNetCore.Mvc;

namespace L02P02_2021CE650_2021ML601.Controllers
{
    public class LibreriaDb : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
