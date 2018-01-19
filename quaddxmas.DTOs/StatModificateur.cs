using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class StatModificateur
    {
        public int Id { get; set; }
        public int Modificateur { get; set; }
        public StatistiqueType StatistiqueType { get; set; }
        public int DureeEnSecondes { get; set; }
        public int CibleId { get; set; }
        public bool IsQuestItem { get; set; }
    }
}
