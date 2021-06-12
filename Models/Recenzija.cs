using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solidarity.Models
{
    [Table("Recenzija")]
    public class Recenzija
    {
        [Key]
        [Required]
        int id { get; set; }
        [Required]
        int ocjena { get; set; }
        [Column]
        string komentar { get; set; }
        [Required]
        DateTime vrijemeIDatum { get; set; }

        public Recenzija(int recenzijaId, int ocjena, string komentar, DateTime vrijemeIDatum)
        {
            this.id = recenzijaId;
            this.ocjena = ocjena;
            this.komentar = komentar;
            this.vrijemeIDatum = vrijemeIDatum;
        }
    }
}
