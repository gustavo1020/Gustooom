using System;
using System.Collections.Generic;
using System.Linq;

namespace GusToom.Models
{
    public static class Repositorio
    {
 

        /*-----Categoria------*/
        static List<Categoriamanga> categoriasdemangas = new List<Categoriamanga>();
        public static IEnumerable<Categoriamanga> Categoriamangas => categoriasdemangas;
        public static void AgregarCategoriasdeManga(Categoriamanga categoriamanga) => categoriasdemangas.Add(categoriamanga);
        
        public static void ActualizarCategoria(Categoriamanga categoriamanga) { var indic = categoriasdemangas.FindIndex(c => c.Id == categoriamanga.Id); if (indic != -1){categoriasdemangas[indic]= categoriamanga; }}

        /*------Manga-----*/
        static List<Manga> mangas = new List<Manga>();
        public static IEnumerable<Manga> Mangas => mangas;
        public static void AgregarManga(Manga manga) => mangas.Add(manga);

       


    }
}