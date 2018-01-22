using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Batiment
    {
        public TypeBatiment TypeBatiment { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int IdProprietaire { get; set; }
        public TypeProprietaire TypeProprietaire { get; set; }
    }
    
}
