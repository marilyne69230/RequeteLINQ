using System;
using System.Linq;
using System.Collections.Generic;

class Personne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Age { get; set; }
    public string Sexe { get; set; }
    public bool Est_ingenieur { get; set; }
    public Personne(string nom, string prenom, bool ingenieur)
    {
        Nom = nom;
        Prenom = prenom;
        Est_ingenieur = ingenieur;
    }
    public Personne(string nom, string prenom, int age, string sexe)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
        Sexe = sexe;
    }
    public Personne(string nom, string prenom, int age, string sexe, bool ingenieur)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
        Sexe = sexe;
        Est_ingenieur = ingenieur;
    }
}

public class Program
{
    public static void Main()
    {

        List<Personne> personnes = new List<Personne>()
        {
        new Personne("Garett", "Ramzy", 45, "M"),
        new Personne("Caire", "Joe", 35, "M"),
        new Personne("Clay", "Alicia", 18, "F"),
        new Personne("Bavette", "Simone", 68, "F"),
        new Personne("Henry", "Thierry", 44, "M"),
        new Personne("Jacquesonne", "Janett", 25, "F"),
        new Personne("Buveur", "Joe", 25, "M"),
        new Personne("Louet", "Karim", 31, "M"),
        new Personne("Louette", "Karima", 31, "F"),
        new Personne("Caire", "Paul", 19, "M"),
        new Personne("Mille", "Camille", 20, "F"),
        new Personne("Cent", "Camille", 40, "F"),
        new Personne("Million", "Camille", 60, "M"),
        new Personne("Gold", "Roger", 17, "M"),
        new Personne("Lion", "Sandra", 8, "F"),
        new Personne("René", "Jean", 6, "M")
        };

        var groupeSexe = personnes.GroupBy(p => p.Sexe);
        // trier par groupe
        foreach (var groupe in groupeSexe)
        {
            Console.WriteLine($"Genre {groupe.Key}");
            // retrier par nom et prenom par group
            foreach (var personne in groupe)
            {
                Console.WriteLine($"Nom : {personne.Nom}, Prénom : {personne.Prenom}");
            }
        }
        Console.WriteLine();

        var groupeAge = personnes.OrderBy(p => p.Age).GroupBy(p => p.Age);
        foreach (var groupe in groupeAge)
        {
            foreach (var personne in groupe)
            {
                Console.WriteLine($"Nom : {personne.Nom} Prénom : {personne.Prenom} Age : {personne.Age}");
            }
        }
        Console.WriteLine();

        var groupePrenom = personnes.Where(p => p.Age >= 18).GroupBy(p => p.Prenom);
        foreach ( var groupe in groupePrenom)
        {
            Console.WriteLine($"Prénom: {groupe.Key}");
        }


        // EXERCICE 2
        List<int> nombres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 13, 12, 14, 18, 17, 16, 14, 14 };

        var groupesNombre = nombres.GroupBy(n => n % 2 == 0 ? "Pairs" : "Impairs");

        foreach (var groupe in groupesNombre)
        {
            Console.WriteLine($"Groupe: {groupe.Key}");

            foreach (var nombre in groupe)
            {
                Console.WriteLine(nombre);
            }
        }
        Console.WriteLine();

        var groupeLettre = personnes.OrderBy(p => p.Nom).GroupBy(p => p.Nom[0]);

        foreach (var groupe in groupeLettre)
        {
            foreach ( var personne in groupe)
            {
                Console.WriteLine($"Nom : {personne.Nom}");
            }
        }

    }
}
