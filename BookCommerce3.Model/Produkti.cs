using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BookCommerce3.Model
{
    [Table("Produkti")]
    public class Produkti
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Specifikoni emrin")]
        public string Emri { get; set; }
        [Required(ErrorMessage = "Specifikoni pershkrimin")]
        public string Pershkrimi { get; set; }
        [Required(ErrorMessage = "Specifikoni isbn")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "Specifikoni autorin")]
        public string Autori { get; set; }
        [Required(ErrorMessage = "Specifikoni cmimin baze")]
        [Range(1,1000)]
        public double CmimiBaze { get; set; }
        [Required(ErrorMessage = "Specifikoni cmimin")]
        [Range(1, 1000)]
        public double Cmimi { get; set; }
        [Required(ErrorMessage = "Specifikoni cmimin per 50 artikuj")]
        [Range(1, 1000)]
        public double Cmimi50 { get; set; }
        [Required(ErrorMessage = "Specifikoni cmimin per 50 artikuj")]
        [Range(1, 1000)]
        public double Cmimi100 { get; set; }
        public string ImagePath { get; set; }

        public int KategoriaId { get; set; }
        [ForeignKey("KategoriaId")]
        [ValidateNever]
        public Kategoria Kategoria { get; set; }

        public int MbulesaId { get; set; }
        [ForeignKey("MbulesaId")]
        [ValidateNever]
        public Mbulesa Mbulesa { get; set; }


    }
}
