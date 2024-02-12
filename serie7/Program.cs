using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Chien
{
    public string Nom { get; set; }
    public string Surnom { get; set; }
    public string Race { get; set; }
    public string Couleur { get; set; }
    public string Sexe { get; set; }
    public int Age { get; set; }
    public int Poids { get; set; }

    public Chien(string nom, string surnom, string race, string couleur, string sexe, int age, int poids)
    {
        this.Surnom = surnom;
        this.Race = race;
        this.Couleur = couleur;
        this.Sexe = sexe;
        this.Nom = nom;
        this.Age = age;
        this.Poids = poids;
    }
}

public class Program
{
    public static void Main()
    {
        List<Chien> chiens = new List<Chien>()
         {
         new Chien("Gnocci", "Gnoc Gnoc", "Labrador", "Sable", "M", 1, 20),
         new Chien("Vagabond", "Gros Loup", "Labrador", "Noir", "M", 8, 25),
         new Chien("Milou", "Milos", "Labrador", "Sable", "M", 10, 24),
         new Chien("Sirène", "Sissy", "Labrador", "Sable","F", 4, 19),
         new Chien("Félicia", "Felicci", "Labrador", "Sable", "F", 6, 20),
         new Chien("Kratos", "Mon tueur", "Chihuahua", "Fauve", "M", 1, 2),
         new Chien("Jack", "Jaja", "Chihuahua", "Fauve", "M", 1, 2),
         new Chien("Mojave", "Mojojo", "Chihuahua", "Fauve", "M", 1, 2),
         new Chien("Hercule", "Herc", "Chihuahua", "Beige", "M", 35, 2),
         new Chien("Médusa", "Med", "Terre-Neuve", "Noire", "F", 6, 40),
         new Chien("Mélusine", "Mel", "Terre-Neuve", "Noire", "F", 7, 41),
         new Chien("Venus", "Violette", "Terre-Neuve", "Noire", "F", 8, 38),
         new Chien("Letto", "Lele", "Berger Australien", "Bleu Merle", "M", 3, 30),
         new Chien("Cabron", "Dum dum", "Berger Australien", "Bleu Merle", "M", 9, 31),
         new Chien("Banzaï", "Zaïzaï", "Berger Australien", "Noir et blanc", "M", 1, 28 ),
         new Chien("Haricot", "Harry", "Berger Australien", "Noir et blanc", "M", 2, 27),
         new Chien("Gédéon", "Gégé", "Berger Allemand", "Noir et feu", "M", 9, 31),
         new Chien("Bella", "Belbel", "Berger Allemand", "Noir et feu", "F", 5, 28),
         new Chien("Oui-oui", "oui", "Berger Allemand", "Sable", "M", 7, 35),
         new Chien("Pataud", "Patoche", "Carlin", "Sable", "M", 16, 8),
         new Chien("Killer", "Kiki", "Carlin", "Sable", "M", 10, 8),
         new Chien("Frank", "Colonel", "Carlin", "Noir", "M", 9, 9)
         };

        var groupeRC = chiens.GroupBy(c => new { c.Race, c.Couleur });

        foreach (var groupe in groupeRC)
        {
            Console.WriteLine($"Race: {groupe.Key.Race}, Couleur: {groupe.Key.Couleur}");

            foreach (var chien in groupe)
            {
                Console.WriteLine($"  Nom: {chien.Nom}, Surnom: {chien.Surnom}, Age: {chien.Age}, Poids: {chien.Poids}");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Requête2");


        var groupeCS = chiens.OrderBy(c => c.Sexe).GroupBy(c => new { c.Couleur, c.Sexe });

        foreach (var itemCS in groupeCS)
        {
            Console.WriteLine($"Sexe: {itemCS.Key.Sexe}, Couleur: {itemCS.Key.Couleur}");

            foreach (var chien in itemCS)
            {
                Console.WriteLine(chien.Surnom);
            }
        }
        Console.WriteLine() ;
        Console.WriteLine("Requête 3");

        var groupeSAC = chiens.Where(c => c.Age >= 2 && c.Age <= 15 && !c.Surnom.Contains(" "))
                              .OrderBy(c => c.Sexe) // Tri croissant par sexe
                              .ThenBy(c => c.Age) // Tri croissant par âge
                              .ThenByDescending(c => c.Race) // Tri décroissant par race
                              .ThenByDescending(c => c.Couleur)
                              .GroupBy(c => new {c.Sexe, c.Age, c.Couleur});

        foreach (var itemSAC in groupeSAC)
        {
            Console.WriteLine($"Sexe : {itemSAC.Key.Sexe},Age : {itemSAC.Key.Age}, Couleur : {itemSAC.Key.Couleur} ");
            
            foreach (var chien in itemSAC)
            {
                Console.WriteLine(chien.Surnom);
            }
        }
    }
}

