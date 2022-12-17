using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.DataAccess.Repository.IRepository;
using BookCommerce3.Model;

namespace BookCommerce3.DataAccess.Repository
{
    public class ProduktiRepository:Repository<Produkti>,IProduktiRepository
    {
        private readonly Konteksti _konteksti;

        public ProduktiRepository(Konteksti konteksti) : base(konteksti)
        {
            _konteksti = konteksti;
        }

        public void Update(Produkti produkti)
        {
            var entitetiprjDb = _konteksti.Produktet.
                FirstOrDefault(x => x.Id == produkti.Id);
            entitetiprjDb.Emri= produkti.Emri;
            entitetiprjDb.Pershkrimi= produkti.Pershkrimi;
            entitetiprjDb.Isbn= produkti.Isbn;
            entitetiprjDb.Autori= produkti.Autori;
            entitetiprjDb.CmimiBaze= produkti.CmimiBaze;
            entitetiprjDb.Cmimi= produkti.Cmimi;
            entitetiprjDb.Cmimi50= produkti.Cmimi50;
            entitetiprjDb.Cmimi100= produkti.Cmimi100;
            entitetiprjDb.KategoriaId= produkti.KategoriaId;
            entitetiprjDb.MbulesaId= produkti.MbulesaId;
            if (produkti.ImagePath!=null)
            {
                entitetiprjDb.ImagePath = produkti.ImagePath;
            }
        }
    }
}
