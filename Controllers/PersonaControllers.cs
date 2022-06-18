using remp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace rempRepository.Controllers
{
    public class personaController : Controller
    {
        RegEmpleadosDBContext db = new RegEmpleadosDBContext();
        public IActionResult Index()
        {
            return View(db.Personas.ToList());
        }
    }
}