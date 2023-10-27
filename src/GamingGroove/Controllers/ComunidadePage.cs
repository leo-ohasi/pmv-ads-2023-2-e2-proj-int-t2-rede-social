using Microsoft.AspNetCore.Mvc;
using GamingGroove.Data;
using GamingGroove.Views.ComunidadePage;

namespace GamingGroove.Controllers
{
    public class ComunidadePageController : BaseController
    {
        private readonly GamingGrooveDbContext _contexto;

        public ComunidadePageController(GamingGrooveDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            

            return View();
        }
            
    }
}