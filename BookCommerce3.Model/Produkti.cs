using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCommerce3.Model
{
    [Table("Produkti")]
    public class Produkti
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Pershkrimi { get; set; }
        public string Autori { get; set; }
        public double CmimiBaze { get; set; }
        public double Cmimi { get; set; }
        public double Cmimi50 { get; set; }
        public double Cmimi100 { get; set; }
        public string ImagePath { get; set; }

        public int KategoriaId { get; set; }
        [ForeignKey("KategoriaId")]
        public Kategoria Kategoria { get; set; }


    }
}
