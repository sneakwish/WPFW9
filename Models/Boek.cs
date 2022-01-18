using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Boek
{
    [Key]
    public string ISBN { get; set; }
    [Required]
    public string Auteur { get; set; }
    [Required]
    public string Titel { get; set; }
    [Required]
    public string Genre { get; set; }
    
}
    // public Boek(string isbn, string auteur, string titel, string genre)
    // {
    //     ISBN = isbn;
    //     Auteur = auteur;
    //     Titel = titel;
    //     Genre = genre;
    // }
