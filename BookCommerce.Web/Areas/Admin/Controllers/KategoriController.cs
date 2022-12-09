using BookCommerce3.DataAccess;
using BookCommerce3.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookCommerce3.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KategoriController : Controller
    {
        private Konteksti _kontekst;
        public KategoriController(Konteksti kon)
        {
            _kontekst = kon;
        }
        public IActionResult Listo()
        {
          List<Kategoria> lista=  _kontekst.Kategorite.ToList();
            return View(lista);
        }
    }
}
