using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Statistique
    {
        public int Force { get; set; }
        public int Dexterite { get; set; }
        public int Resistance { get; set; }
        public int Vision { get; set; }
        public int Sensibilite { get; set; }
        public int Recuperation { get; set; }
        public int Intelligence { get; set; }
        public int Guerison { get; set; }
        public int Apprentissage { get; set; }

        public Statistique(int force, int dexterite, int resistance, int vision, int sensibilite, int recuperation, int intelligence, int guerison, int apprentissage)
        {
            Force = force;
            Dexterite = dexterite;
            Resistance = resistance;
            Vision = vision;
            Sensibilite = sensibilite;
            Recuperation = recuperation;
            Intelligence = intelligence;
            Guerison = guerison;
            Apprentissage = apprentissage;
        }

        public Statistique()
        {

        }
    }
}
