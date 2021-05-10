using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidarity.Models
{
    public class Recenzija
    {
        int recenzijaId;
        int ocjena;
        string komentar;
        DateTime vrijemeIDatum;

        public Recenzija(int recenzijaId, int ocjena, string komentar, DateTime vrijemeIDatum)
        {
            this.recenzijaId = recenzijaId;
            this.ocjena = ocjena;
            this.komentar = komentar;
            this.vrijemeIDatum = vrijemeIDatum;
        }
    }
}
