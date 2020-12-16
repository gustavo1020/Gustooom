using System;
using System.Collections.Generic;
using System.Linq;

namespace GusToom.Models
{
    public class Categoriamanga
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public List<Manga> Mangas { get; set; }
        public Categoriamanga()
        {
            Mangas = new List<Manga>();
        }


        
    }
}