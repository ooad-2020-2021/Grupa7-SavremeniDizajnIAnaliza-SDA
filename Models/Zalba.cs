using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidarity.Models
{
    public enum TipZalbe
    {
        ZalbaNaVolontera,
        ZalbaNaGradjanina
    }
    public class Zalba
    {
        int zalbaId;
        int gradjaninId;
        int volonterId;
        TipZalbe tipZalbe;
        string tekst;

        public Zalba(int zalbaId, int gradjaninId, int volonterId, TipZalbe tipZalbe, string tekst)
        {
            this.zalbaId = zalbaId;
            this.gradjaninId = gradjaninId;
            this.volonterId = volonterId;
            this.tipZalbe = tipZalbe;
            this.tekst = tekst;
        }
    }
}
