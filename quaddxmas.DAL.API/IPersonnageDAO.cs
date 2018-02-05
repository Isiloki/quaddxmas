using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quaddxmas.DTOs;

namespace quaddxmas.DAL.API
{
    public interface IPersonnageDAO : IDisposable
    {
        //Récupère l'ensemble des caractéristiques d'un personnage en fonction de son index
        Personnage GetPersonnage(int index);

        //Récupère l'ensemble des caractéristiques d'un personnage en fonction de son nom
        Personnage GetPersonnage(string name);

        //On update un personnage existant
        Boolean UpdatePersonnage(Personnage personnage);

        //On crée un personnage
        void CreatePersonnage(Personnage personnage);

    }
}
