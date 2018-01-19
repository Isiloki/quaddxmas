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
        public Position position { get; set; }
    }
}
