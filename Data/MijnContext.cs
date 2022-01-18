using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MijnContext : DbContext{

    public MijnContext(DbContextOptions options) : base(options){
        
    }
    public DbSet <Boek> Boeken {get;set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder b)
    {
        // b.UseSqlite("Data Source=database.db");
        b.UseInMemoryDatabase("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Boek>().HasData(
            new Boek{ISBN ="978-7-6512-7309-0", Auteur="Wade Dorota Kató", Titel="De grote liefde", Genre="liefde"},
            new Boek{ISBN ="978-7-6512-7309-1", Auteur="Josip Suse Dane", Titel="De bloedende brie", Genre="horror"},
            new Boek{ISBN ="978-7-6512-7309-2", Auteur="Genesio Nilüfer Ruzzier", Titel="Schietende mensen", Genre="actie"},
            new Boek{ISBN ="978-7-6512-7309-3", Auteur="CelestineKristaLambert", Titel="De bloedende brie", Genre="horror"},
            new Boek{ISBN ="978-7-6512-7309-4", Auteur="Eilert Farid Holmström", Titel="Pief paf poef", Genre="liefde"},
            new Boek{ISBN ="978-7-6512-7309-5", Auteur="Josip Suse Dane", Titel="De uitgebloede brief", Genre="horror"},
            new Boek{ISBN ="978-7-6512-7309-6", Auteur="Cosip Suse Dane", Titel="John en Emma", Genre="liefde"},
            new Boek{ISBN ="978-7-6512-7309-7", Auteur="CelestineKristaLambert", Titel="De bloedende brie", Genre="actie"},
            new Boek{ISBN ="978-7-6512-7309-8", Auteur="CelestineKristaLambert", Titel="Het grote hart van John", Genre="actie"},
            new Boek{ISBN ="978-7-6512-7309-9", Auteur="AAAA", Titel="DSchietende menseie", Genre="actie"});
    }
}