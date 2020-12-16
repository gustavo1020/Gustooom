using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GusToom.Models;

namespace GusToom.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult ListMangas() => View(Repositorio.Mangas);
        public ViewResult ListCategoria() => View(Repositorio.Categoriamangas);
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Mangaadd(){
            List<Categoriamanga> categoria = Repositorio.Categoriamangas.ToList();
            ViewBag.Categoriasdemangas = categoria;
            return View("Mangaadd");
        } 
            
        public IActionResult Categoriaadd() => View("Categoriaadd");

        [HttpPost]
        public IActionResult Categoriaadd(Categoriamanga categoriamanga)
        {
            Repositorio.AgregarCategoriasdeManga(categoriamanga);
            return View("ListCategoria", Repositorio.Categoriamangas);
        }
       
        [HttpPost]
        public IActionResult Mangaadd(Manga manga)
        {
            Repositorio.AgregarManga(manga);
            return View("ListMangas", Repositorio.Mangas);
        }
        [HttpPost]
        public IActionResult Modificar(Categoriamanga categoriamanga)
        {
            Repositorio.ActualizarCategoria(categoriamanga);
            return View("Index", Repositorio.Categoriamangas);

        }
        
    }
}
