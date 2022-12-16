using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCommerce3.Model
{
    [Table("Mbulesa")]
    public class Mbulesa
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Specifikoni emrin ")]
        public string Emri { get; set; }
    }
}
