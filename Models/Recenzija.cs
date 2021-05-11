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
        int recenzijaId;
        [Required]
        int ocjena;
        [Column]
        string komentar;
        [Required]
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
