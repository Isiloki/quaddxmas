using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Objet
    {
        public int Id { get; set; }
        public int ProprietaireId { get; set; }
        public List<StatModificateur> Modificateur { get; set; }        
        public Position Position { get; set; }

    }
}
