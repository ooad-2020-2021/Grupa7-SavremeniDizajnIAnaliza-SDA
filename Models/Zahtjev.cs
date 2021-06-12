using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    [Table("Zahtjev")]
    public abstract class Zahtjev
    {
        [Key]
        [Required]
        public int id { get; set; }
        [ForeignKey("Gradjanin")]
        [Required]
        int podnosilacId;
        [ForeignKey("Volonter")]
        [Required]
        int volonterId;
        [Column]
        Recenzija recenzija;
        [Column]
        Zalba zalba;
        [Column]
        bool izvrsen;
        [Column]
        DateTime datumIVrijemeIzvrsenja;
    }
}
