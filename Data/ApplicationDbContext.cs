using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Solidarity.Models;

namespace Solidarity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Solidarity.Models.Administrator> Administrator { get; set; }
        public DbSet<Solidarity.Models.Gradjanin> Gradjanin { get; set; }
        public DbSet<Solidarity.Models.Volonter> Volonter { get; set; }
        public DbSet<Solidarity.Models.ZahtjevZaBanku> ZahtjevZaBanku { get; set; }
        public DbSet<Solidarity.Models.ZahtjevZaKupovinu> ZahtjevZaKupovinu { get; set; }
        public DbSet<Solidarity.Models.ZahtjevZaPostu> ZahtjevZaPostu { get; set; }
        public DbSet<Solidarity.Models.Zalba> Zalba { get; set; }
        public DbSet<Solidarity.Models.Recenzija> Recenzija { get; set; }
    }
}
