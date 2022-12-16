using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.DataAccess.Repository.IRepository;
using BookCommerce3.Model;

namespace BookCommerce3.DataAccess.Repository
{
    public class KategoriaRepository:Repository<Kategoria>,IKategoriaRepository
    {
        private readonly Konteksti _konteksti;

        public KategoriaRepository(Konteksti konteksti) : base(konteksti)
        {
            _konteksti = konteksti;
        }

        public void Update(Kategoria kategoria)
        {
            var entitetiprjDb = _konteksti.Kategorite.FirstOrDefault(x => x.Id == kategoria.Id);
            entitetiprjDb.Emri= kategoria.Emri;
        }
    }
}
