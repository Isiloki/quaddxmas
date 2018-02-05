using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quaddxmas.DAL.API;
using quaddxmas.DTOs;

namespace quaddxmas.DAL
{
    public class PersonnageDAO : IPersonnageDAO
    {
        private BddContext bdd;

        public PersonnageDAO()
        {
            bdd = new BddContext();
        }

        public void CreatePersonnage(Personnage personnage)
        {
            bdd.Personnages.Add(personnage);
            bdd.SaveChanges();
        }

        public Personnage GetPersonnage(int index)
        {
            throw new NotImplementedException();
        }

        public Personnage GetPersonnage(string name)
        {
            BddContext bdd2 = new BddContext();
            return bdd2.Personnages.Where(p => p.Nom == name).FirstOrDefault<Personnage>();
        }

        public bool UpdatePersonnage(Personnage personnage)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}
