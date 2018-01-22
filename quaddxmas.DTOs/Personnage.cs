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
        public int Force { get; set; }
        public int Dexterite { get; set; }
        public int Resistance { get; set; }
        public int Vision { get; set; }
        public int Intelligence { get; set; }
        public int Recuperation { get; set; }
        public int Guerison { get; set; }
        public int Apprentissage { get; set; }
        public int Sensibilite { get; set; }
        public string Nom { get; set; }
        public Position Position { get; set; }
        public List<StatModificateur> Modificateurs { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int XP { get; set; }
        public int Niveau { get; set; }
        public int Or { get; set; }
        public Squadd Squadd { get; set; }
        public List<Objet> Objets { get; set; }
        public List<Batiment> Batiments { get; set; }
        

    }
}
