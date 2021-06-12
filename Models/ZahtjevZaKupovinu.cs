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
        [Key]
        [Required]
        public int id { get; set; }
        [NotMapped]
        Dictionary<string, double> artikli;
        void dodajArtikl(string artikl, double kolicina) { artikli.Add(artikl, kolicina); }
        void obrisiArtikl(string artikl) { artikli.Remove(artikl); }
    }
}
