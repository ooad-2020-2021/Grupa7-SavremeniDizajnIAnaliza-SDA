using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidarity.Models
{
    public class ZahtjevZaPostu : Zahtjev
    {
        int brojPosiljki;
        string vrstaUsluge;
        string vrstaPosiljke;
        string odredisnaPosta;
        string primalac;
        string adresaPrimaoca;
        int masaUGramima;
        DateTime rokIsporuke;
        double vrijednostPosiljke;
        int prijemniBroj;
    }
}
