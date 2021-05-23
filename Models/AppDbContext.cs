using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Solidarity.Models
{
    public class AppDbContext : System.Data.Entity.DbContext
    {
        System.Data.Entity.DbSet<RegistrovaniKorisnik> RegistrovaniKorisniks { get; set; }
        


    }
}
