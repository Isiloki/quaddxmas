using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Compte
    {
        public int Id { get; set; }
        public string Identifiant { get; set; }
        public string MotDePasse { get; set; }
        public List<Personnage> Personnages { get; set; }
    }
}
