using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solidarity.Models
{
    [Table("ZahtjevZaKupovinu")]
    public class ZahtjevZaKupovinu : Zahtjev
    {
        [NotMapped]
        Dictionary<string, double> artikli;
        void dodajArtikl(string artikl, double kolicina) { }
        void obrisiArtikl(string artikl) { }
    }
}
