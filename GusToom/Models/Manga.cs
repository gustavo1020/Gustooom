using System;
using System.Collections.Generic;
using System.Linq;

namespace GusToom.Models
{
    public class Manga
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public Categoriamanga categoriamanga {get ; set;}
        public String link {get; set;}
        public List<string> estadom {get;set;}
        public string autor {get; set;}
        public int volumenes { get; set; }
        public int puntuacion {get; set;}
        public DateTime fechaemitido {get; set;}
        public byte preciopromedio {get; set;}


        public List<ScoredeManga> Scores { get; set; }
        public Manga() => Scores = new List<ScoredeManga>();

        public void estados ()
        {
            estadom.Add("Emision");
            estadom.Add("pausado");
            estadom.Add("finalizado");
        }

        public void Modificarscore(int score)
        {
            puntuacion = score;
            Scores.Add(new ScoredeManga(score));
        }


    }
}