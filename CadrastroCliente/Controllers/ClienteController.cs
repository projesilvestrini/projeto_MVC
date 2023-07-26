using Microsoft.AspNetCore.Mvc;

namespace CadrastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
