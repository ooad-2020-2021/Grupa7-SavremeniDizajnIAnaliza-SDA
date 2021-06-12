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
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        string svrhaDoznake { get; set; }
        [Required]
        string imeIPrezimeUplatioca { get; set; }
        [Required]
        string primalac { get; set; }
        [Required]
        string racunPrimaoca { get; set; }
        [Column]
        string sifraOpcine { get; set; }
        [Column]
        string vrstaPrihoda { get; set; }
        [Column]
        string budzetskaOrganizacija { get; set; }
        [Column]
        string pozivNaBroj { get; set; }
        [Required]
        double iznos
        {
            get; set;
        }
        [Column]
        bool hitniNalog { get; set; }
    }
}
