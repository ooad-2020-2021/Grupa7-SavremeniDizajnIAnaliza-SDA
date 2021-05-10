using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    public enum TipZalbe
    {
        ZalbaNaVolontera,
        ZalbaNaGradjanina
    }
    [Table("ZahtjevZaPostu")]
    public class Zalba
    {
        [Key]
        int zalbaId;
        [ForeignKey("Gradjanin")]
        int gradjaninId;
        [ForeignKey("Volonter")]
        int volonterId;
        [Column]
        TipZalbe tipZalbe;
        [Column]
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
