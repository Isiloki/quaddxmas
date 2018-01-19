using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Squadd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Richesse { get; set; }
        public string Description { get; set; }
        public List<Personnage> Membres { get; set; }
        public List<Batiment> Possessions { get; set; }
    }
}
