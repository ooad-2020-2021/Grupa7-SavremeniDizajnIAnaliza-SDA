using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solidarity.Models
{
    [Table("RegistrovaniKorisnik")]
    public abstract class RegistrovaniKorisnik
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        string ime { get; set; }
        [Required]
        string prezime { get; set; }
        [Required]
        DateTime datum { get; set; }
        [Required]
        string jmbg { get; set; }
        [Required]
        string email { get; set; }
        [Required]
        string brojTelefona { get; set; }
    }
}
