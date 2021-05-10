using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidarity.Models
{
    public class ZahtjevZaBanku : Zahtjev
    {
        string svrhaDoznake;
        string imeIPrezimeUplatioca;
        string primalac;
        string racunPrimaoca;
        string sifraOpcine;
        string vrstaPrihoda;
        string budzetskaOrganizacija;
        string pozivNaBroj;
        double iznos;
        bool hitniNalog;
    }
}
