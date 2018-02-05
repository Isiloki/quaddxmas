﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaddxmas.DTOs
{
    public class Position
    {
        public int Carte { get; set; }
        public int Abscisse { get; set; }
        public int Ordonnee { get; set; }
        public Position(int carte, int abscisse, int ordonnee)
        {
            Carte = carte;
            Abscisse = abscisse;
            Ordonnee = ordonnee;
        }
        public Position()
        {

        }
    }
}
