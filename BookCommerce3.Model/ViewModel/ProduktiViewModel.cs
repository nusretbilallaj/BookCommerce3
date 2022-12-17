using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookCommerce3.Model.ViewModel
{
    public class ProduktiViewModel
    {
        public Produkti Produkti { get; set; }
        public IEnumerable<SelectListItem> Kategorite { get; set; }
        public IEnumerable<SelectListItem> Mbulesat { get; set; }
    }
}
