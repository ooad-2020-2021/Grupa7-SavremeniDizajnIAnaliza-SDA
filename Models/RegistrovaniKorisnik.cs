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
        int id;
        [Required]
        string ime;
        [Required]
        string prezime;
        [Required]
        DateTime datum;
        [Required]
        string jmbg;
        [Required]
        string email;
        [Required]
        string brojTelefona;
    }
}
