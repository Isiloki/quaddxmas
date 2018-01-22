using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Carte
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DefiningPoint> Limites { get; set; }

        public class DefiningPoint
        {
            public int Numero { get; set; }
            public int Abscisse { get; set; }
            public int Ordonnee { get; set; }
        }
    }

    
}
