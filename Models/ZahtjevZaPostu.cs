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
        [Required]
        int brojPosiljki;
        [Required]
        string vrstaUsluge;
        [Required]
        string vrstaPosiljke;
        [Required]
        string odredisnaPosta;
        [Required]
        string primalac;
        [Required]
        string adresaPrimaoca;
        [Required]
        int masaUGramima;
        [Required]
        DateTime rokIsporuke;
        [Required]
        double vrijednostPosiljke;
        [Required]
        int prijemniBroj;
    }
}
