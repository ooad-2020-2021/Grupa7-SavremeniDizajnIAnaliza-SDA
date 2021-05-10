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
        int brojZalbiNaKorisnika;

        void dodajNoviZahtjev(Zahtjev zahtjev) { }
    }
}
