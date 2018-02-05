using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Personnage
    {
        public int Id { get; set; }
        public Statistique StatistiquesNaturelles { get; set; }
        public string Nom { get; set; }
        public Position Position { get; set; }
        public List<StatModificateur> Modificateurs { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int XP { get; set; }
        public int Niveau { get; set; }
        public int Or { get; set; }
        public Squadd Squadd { get; set; }
        public virtual List<Objet> Objets { get; set; }
        public virtual List<Batiment> Batiments { get; set; }


    }
}
