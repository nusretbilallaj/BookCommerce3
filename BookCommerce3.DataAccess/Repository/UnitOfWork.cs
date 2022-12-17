using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.DataAccess.Repository.IRepository;

namespace BookCommerce3.DataAccess.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly Konteksti _kon;

        public UnitOfWork(Konteksti kon)
        {
            _kon = kon;
            Kategoria = new KategoriaRepository(_kon);
            Mbulesa = new MbulesaRepository(_kon);
            NenKategoria = new NenKategoriaRepository(_kon);
            Produkti = new ProduktiRepository(_kon);
        }
        public IKategoriaRepository Kategoria { get; }
        public INenKategoriaRepository NenKategoria { get; }
        public IMbulesaRepository Mbulesa { get; }
        public IProduktiRepository Produkti { get; }

        public void Save()
        {
            _kon.SaveChanges();
        }
    }
}
