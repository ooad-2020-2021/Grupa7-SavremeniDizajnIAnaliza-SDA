using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    [Table("Gradjanin")]
    public class Gradjanin : RegistrovaniKorisnik
    {
        [Required]
        string adresaStanovanja { get; set; }
        [Required]
        int brojZalbiNaKorisnika { get; set; }
        ZahtjevZaBanku kreirajZahtjevZaBanku() { return new ZahtjevZaBanku(); }
        ZahtjevZaPostu kreirajZahtjevZaPostu() { return new ZahtjevZaPostu(); }
        ZahtjevZaKupovinu kreirajZahtjevZaKupovinu() { return new ZahtjevZaKupovinu();}

        public Gradjanin()
        {

        }
    }
}
