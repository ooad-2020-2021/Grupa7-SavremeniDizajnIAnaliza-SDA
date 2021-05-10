using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidarity.Models
{
    public class Zahtjev
    {
        int zahtjevId;
        int podnosilacId;
        int volonterId;
        Recenzija recenzija;
        Zalba zalba;
        bool izvrsen;
        DateTime datumIVrijemeIzvrsenja;
    }
}
