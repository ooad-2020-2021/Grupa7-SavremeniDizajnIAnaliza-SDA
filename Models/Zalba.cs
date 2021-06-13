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
    [Table("Zalba")]
    public class Zalba
    {
        [Key]
        [Required]
        public int id { get; set; }
        [ForeignKey("Gradjanin")]
        int gradjaninId { get; set; }
        [ForeignKey("Volonter")]
        int volonterId { get; set; }
        [Column]
        TipZalbe tipZalbe { get; set; }
        [Column]
        string tekst { get; set; }
        public Zalba() { }

        public Zalba(int zalbaId, int gradjaninId, int volonterId, TipZalbe tipZalbe, string tekst)
        {
            this.id = zalbaId;
            this.gradjaninId = gradjaninId;
            this.volonterId = volonterId;
            this.tipZalbe = tipZalbe;
            this.tekst = tekst;
        }
    }
}
