using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.DataAccess.Repository.IRepository;
using BookCommerce3.Model;

namespace BookCommerce3.DataAccess.Repository
{
    public class NenKategoriaRepository:Repository<NenKategoria>,INenKategoriaRepository
    {
        private readonly Konteksti _konteksti;

        public NenKategoriaRepository(Konteksti konteksti) : base(konteksti)
        {
            _konteksti = konteksti;
        }

        public void Update(NenKategoria nenKategoria)
        {
            var entitetiprjDb = _konteksti.NenKategorite.
                FirstOrDefault(x => x.Id == nenKategoria.Id);
            entitetiprjDb.Emri= nenKategoria.Emri;
        }
    }
}
