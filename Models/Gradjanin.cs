using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidarity.Models
{
    public class Gradjanin : RegistrovaniKorisnik
    {
        string adresaStanovanja;
        int brojZalbiNaKorisnika;

        ZahtjevZaBanku kreirajZahtjevZaBanku() { }
        ZahtjevZaPostu kreirajZahtjevZaPostu() { }
        ZahtjevZaKupovinu kreirajZahtjevZaKupovinu() { }
    }
}
