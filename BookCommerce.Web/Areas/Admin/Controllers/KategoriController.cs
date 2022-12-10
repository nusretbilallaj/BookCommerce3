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

        public IActionResult Krijo()
        {
            var obj = new Kategoria();
            obj.Renditja = _kontekst.Kategorite.Max(x=>x.Renditja)+1;
            return View(obj);
        }

        [HttpPost]
        public IActionResult Krijo(Kategoria kat)
        {
            if (ModelState.IsValid)
            {
                _kontekst.Kategorite.Add(kat);
                _kontekst.SaveChanges();
                TempData["suksesi"] = "U shtua me sukses!";
                return RedirectToAction("Listo");
            }

            return View(kat);
        }

        public IActionResult Ndrysho(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            Kategoria kat= _kontekst.Kategorite.Find(id);
            if (kat==null)
            {
                return NotFound();
            }
            return View(kat);
        }

        [HttpPost]
        public IActionResult Ndrysho(Kategoria kat)
        {
            if (ModelState.IsValid)
            {
                _kontekst.Kategorite.Update(kat);
                _kontekst.SaveChanges();
                TempData["suksesi"] = "U ndryshua me sukses!";
                return RedirectToAction("Listo");
            }

            return View(kat);
        }

        public IActionResult Fshi(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Kategoria kat = _kontekst.Kategorite.Find(id);
            if (kat == null)
            {
                return NotFound();
            }
            return View(kat);
        }

        [HttpPost,ActionName("Fshi")]
        public IActionResult FshiPo(int? id)
        {
            if (id==0 || id==null)
            {
                return NotFound();
            }
            Kategoria katPrjDb = _kontekst.Kategorite.Find(id);
            if (katPrjDb==null)
            {
                return NotFound();
            }
            _kontekst.Kategorite.Remove(katPrjDb);
            _kontekst.SaveChanges();
            TempData["suksesi"] = "Eshte fshire me sukses!";
            return RedirectToAction("Listo");
        }

    }
}
