using BookCommerce3.DataAccess;
using BookCommerce3.DataAccess.Repository.IRepository;
using BookCommerce3.Model;
using BookCommerce3.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookCommerce3.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProduktiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProduktiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Listo()
        {
            return View();
        }
        public IActionResult ShtoNdrysho(int? id)
        {
            var pvm = new ProduktiViewModel();
            pvm.Kategorite = _unitOfWork.Kategoria.GetAll().Select(x => new SelectListItem()
            {
               Value = x.Id.ToString(),
               Text = x.Emri
            });

            pvm.Mbulesat = _unitOfWork.Mbulesa.GetAll().Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Emri
            });



            if (id==null || id==0)
            {
                pvm.Produkti = new Produkti();
                //insertimi i produktit
            }
            else
            {
                pvm.Produkti = _unitOfWork.Produkti.FirstOrDefault(x=>x.Id==id);
                if (pvm.Produkti==null)
                {
                    return NotFound();
                }
                //ndryshimi i produktit
            }
            return View(pvm);
        }

        [HttpPost]
        public IActionResult ShtoNdrysho(Produkti prod)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Produkti.Update(prod);
                _unitOfWork.Save();
                TempData["suksesi"] = "U ndryshua me sukses!";
                return RedirectToAction("Listo");
            }

            return View(prod);
        }

        
    }
}
