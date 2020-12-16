using System;
using System.Collections.Generic;
using System.Linq;

namespace GusToom.Models
{
    public class ScoredeManga
    {
        public float Calificacion { get; set; }
        public DateTime FechaHora { get; set; }
        public List<ScoredeManga> Calificaciones { get; set; }
        public ScoredeManga(int calificacion)
        {
            Calificacion = calificacion;
        }
       
    }
}

