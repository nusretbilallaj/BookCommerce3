using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.DataAccess.Repository.IRepository;
using BookCommerce3.Model;

namespace BookCommerce3.DataAccess.Repository
{
    public class MbulesaRepository:Repository<Mbulesa>,IMbulesaRepository
    {
        private readonly Konteksti _konteksti;

        public MbulesaRepository(Konteksti konteksti) : base(konteksti)
        {
            _konteksti = konteksti;
        }

        public void Update(Mbulesa mbulesa)
        {
            var entitetiprjDb = _konteksti.Mbulesat.FirstOrDefault(x => x.Id == mbulesa.Id);
            entitetiprjDb.Emri= mbulesa.Emri;
        }
    }
}
