using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    [Table("Volonter")]
    public class Volonter : RegistrovaniKorisnik
    {
        [NotMapped]
        List<Zahtjev> aktivniZahtjevi;
        [Column]
        int brojZalbiNaKorisnika { get; set; }

        void dodajNoviZahtjev(Zahtjev zahtjev) {
            aktivniZahtjevi.Add(zahtjev);
        }
    }
}
