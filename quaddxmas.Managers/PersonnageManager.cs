using quaddxmas.DAL;
using quaddxmas.DAL.API;
using quaddxmas.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.Managers
{
    public class PersonnageManager
    {

        private IPersonnageDAO personnageDao = new PersonnageDAO();
        public void CreerNouveauPersonnage(string name)
        {
            Personnage persoNiveau1 = new Personnage();

            Statistique statsNiveau1 = new Statistique(1,1,1,1,1,1,1,1,1);

            persoNiveau1.StatistiquesNaturelles = statsNiveau1;
            persoNiveau1.Niveau = 1;
            persoNiveau1.Nom = name;
            persoNiveau1.MaxHP = 55;
            persoNiveau1.CurrentHP = 55;
            persoNiveau1.Batiments = new List<Batiment>();
            persoNiveau1.Or = 50;
            persoNiveau1.Position = new Position(1, 1, 1);
            persoNiveau1.Squadd = null;
            persoNiveau1.XP = 0;

            using (personnageDao)
            {
                personnageDao.CreatePersonnage(persoNiveau1);
            }

        }

        public Personnage GetPersonnage(string name)
        {
            return personnageDao.GetPersonnage(name);
        }
    }
}
