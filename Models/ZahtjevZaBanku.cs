using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    [Table("ZahtjevZaBanku")]
    public class ZahtjevZaBanku : Zahtjev
    {
        [Required]
        string svrhaDoznake;
        [Required]
        string imeIPrezimeUplatioca;
        [Required]
        string primalac;
        [Required]
        string racunPrimaoca;
        [Column]
        string sifraOpcine;
        [Column]
        string vrstaPrihoda;
        [Column]
        string budzetskaOrganizacija;
        [Column]
        string pozivNaBroj;
        [Required]
        double iznos;
        [Column]
        bool hitniNalog;
    }
}
