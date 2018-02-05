using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quaddxmas.DTOs;

namespace quaddxmas.DAL
{
    public class BddContext : DbContext
    {
        public DbSet<Squadd> Squadds { get; set; }
        public DbSet<Objet> Objets { get; set; }
        public DbSet<Personnage> Personnages { get; set; }
        public DbSet<Batiment> Batiments { get; set; }
    }
}
