using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.Model;

namespace BookCommerce3.DataAccess.Repository.IRepository
{
    public interface IProduktiRepository:IRepository<Produkti>
    {
        void Update(Produkti produkti);
    }
}
