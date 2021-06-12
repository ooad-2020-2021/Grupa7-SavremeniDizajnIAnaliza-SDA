using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    [Table("ZahtjevZaPostu")]
    public class ZahtjevZaPostu : Zahtjev
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        int brojPosiljki { get; set; }
        [Required]
        string vrstaUsluge { get; set; }
            [Required]
        string vrstaPosiljke { get; set; }
        [Required]
        string odredisnaPosta { get; set; }
        [Required]
        string primalac { get; set; }
        [Required]
        string adresaPrimaoca { get; set; }
        [Required]
        int masaUGramima { get; set; }
        [Required]
        DateTime rokIsporuke { get; set; }
        [Required]
        double vrijednostPosiljke { get; set; }
        [Required]
        int prijemniBroj { get; set; }
    }
}
