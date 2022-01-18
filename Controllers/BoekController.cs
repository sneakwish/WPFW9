using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFW6._1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
namespace WPFW6._1.Controllers
{


public class BoekController : Controller{
    private readonly MijnContext _context;

    public BoekController(MijnContext context)
    {
        _context = context;
    }

    public static List<Boek> Boekelijst(MijnContext _context)
    {
    List<Boek> boeken3 = _context.Boeken.ToList();
    return boeken3;
    }

    public ViewResult Index(){
        ViewData["aantal"] = _context.Boeken.Count();
        return View(_context.Boeken.ToList());
    }    


     
    public IActionResult aantal(string id){
        ViewData["aantal"] = _context.Boeken.Count(boek=>boek.Auteur == id);
        ViewData["Auteur"] = id;
        return View();
    } 
    public IActionResult genre(string id){
        Boek boek = _context.Boeken.Where(boek=>boek.ISBN == id).SingleOrDefault();
        return View(boek);
    }

      public IActionResult zoek(string id){
        List<string> auteurs = _context.Boeken
        .Where(boek=>boek.Auteur.StartsWith(id))
        .GroupBy(boek=>boek.Auteur)
        .Select(g=>g.Key).ToList();
        return View(auteurs);
    }

    [HttpGet]
    public IActionResult create(){
        return View();
    }

    [HttpPost]
    public IActionResult create(String ISBN, String Auteur, String Titel, String Genre){
        _context.Boeken.Add(new Boek{ISBN = ISBN, Auteur = Auteur, Titel = Titel, Genre = Genre});
        _context.SaveChanges();
        return Redirect("index");
    }

    

    [HttpGet]
    public IActionResult delete(){
        return View(_context.Boeken.ToList());
    }

    [HttpPost]
    public IActionResult delete(String ISBN){
        // List<Boek> nieuweLijst = Boekelijst();
        Boek boek6 = _context.Boeken.Where(boek=>boek.ISBN == ISBN).SingleOrDefault();
        _context.Boeken.Remove(boek6);
        _context.SaveChanges();

        return Redirect("index");
    }


    [HttpGet]
    public IActionResult update(String ISBN){
        Boek boek6 = _context.Boeken.Where(boek=>boek.ISBN == ISBN).SingleOrDefault();
        return View(boek6);
    }

    [HttpPost]
    public IActionResult update(String ISBN, String Auteur, String Titel, String Genre){

        Boek boek6 = _context.Boeken.Where(boek=>boek.ISBN == ISBN).SingleOrDefault();
        boek6.ISBN = ISBN;
        boek6.Auteur = Auteur;
        boek6.Titel = Titel;
        boek6.Genre = Genre;
        _context.SaveChanges();
        
        return Redirect("index");
    }


   
}
}


