using BookCommerce3.DataAccess;
using BookCommerce3.DataAccess.Repository.IRepository;
using BookCommerce3.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookCommerce3.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MbulesaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MbulesaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Listo()
        {
          List<Mbulesa> lista= _unitOfWork.Mbulesa.GetAll().ToList();
            return View(lista);
        }

        public IActionResult Krijo()
        {
            var obj = new Mbulesa();
            return View(obj);
        }

        [HttpPost]
        public IActionResult Krijo(Mbulesa mbulesa)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Mbulesa.Add(mbulesa);
                _unitOfWork.Save();
                TempData["suksesi"] = "U shtua me sukses!";
                return RedirectToAction("Listo");
            }

            return View(mbulesa);
        }

        public IActionResult Ndrysho(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            Mbulesa kat= _unitOfWork.Mbulesa.FirstOrDefault(x=>x.Id==id);
            if (kat==null)
            {
                return NotFound();
            }
            return View(kat);
        }

        [HttpPost]
        public IActionResult Ndrysho(Mbulesa mbulesa)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Mbulesa.Update(mbulesa);
                _unitOfWork.Save();
                TempData["suksesi"] = "U ndryshua me sukses!";
                return RedirectToAction("Listo");
            }

            return View(mbulesa);
        }

        public IActionResult Fshi(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Mbulesa mbulesa = _unitOfWork.Mbulesa.FirstOrDefault(x=>x.Id==id);
            if (mbulesa == null)
            {
                return NotFound();
            }
            return View(mbulesa);
        }

        [HttpPost,ActionName("Fshi")]
        public IActionResult FshiPo(int? id)
        {
            if (id==0 || id==null)
            {
                return NotFound();
            }
            var mbulesat = _unitOfWork.Mbulesa.FirstOrDefault(y=>y.Id==id);
            if (mbulesat == null)
            {
                return NotFound();
            }
            _unitOfWork.Mbulesa.Remove(mbulesat);
            _unitOfWork.Save();
            TempData["suksesi"] = "Eshte fshire me sukses!";
            return RedirectToAction("Listo");
        }

    }
}
