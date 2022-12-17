﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCommerce3.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public IKategoriaRepository Kategoria { get; }
        public INenKategoriaRepository NenKategoria { get; }
        public IMbulesaRepository Mbulesa { get; }

        public IProduktiRepository Produkti { get;  }

        void Save();
    }
}
