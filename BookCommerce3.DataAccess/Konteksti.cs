﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCommerce3.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookCommerce3.DataAccess
{
    public class Konteksti:IdentityDbContext
    {
        public Konteksti(DbContextOptions<Konteksti> op):base(op)
        {
            
        }

        public DbSet<Kategoria> Kategorite { get; set; }
        public DbSet<NenKategoria> NenKategorite { get; set; }
        public DbSet<Mbulesa> Mbulesat { get; set; }

        public DbSet<Produkti> Produktet { get; set; }

    }
}
