using System;
using System.Collections.Generic;

public class Personne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Age { get; set; }
    public string Sexe { get; set; }
    public bool Est_ingenieur { get; set; }

    // Constructeur pour une personne non spécifiée en tant qu'ingénieur
    public Personne(string nom, string prenom, int age, string sexe)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
        Sexe = sexe;
        Est_ingenieur = false; // Par défaut, une personne n'est pas un ingénieur
    }

    // Constructeur pour une personne spécifiée en tant qu'ingénieur
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
        List<Personne> personnes = new List<Personne> {
            new Personne("Beauvoir", "Simon", 16, "M"),
            new Personne("Beauvoir", "Simone", 25, "F"),
            new Personne("De Caunes", "Richard", 41, "M"),
            new Personne("Sullivan", "Sullivan", 31, "M"),
            new Personne("Rémy", "Camille", 22, "F"),
            new Personne("Manchon", "Camille", 19, "M"),
            new Personne("Thiebaud", "Marie", 61, "F"),
            new Personne("Crouchon", "Mélanie", 55, "F"),
            new Personne("Baline", "Mélodie", 74, "F"),
            new Personne("Karine", "Pascal", 31, "M"),
            new Personne("Katherine", "Pascale", 36, "F"),
            new Personne("Zoula", "Charles", 20, "M"),
            new Personne("Romain", "Collin", 34, "M"),
            new Personne("Fouchard", "Aïcha", 48, "F"),
            new Personne("Blandine", "Maëva", 18, "F")
        };

       foreach (Personne personne in personnes)
        {
            var nom_complet = personne.Nom + personne.Prenom;
            Console.WriteLine($"{ nom_complet} | Age : {personne.Age}");
        }

        var personnesMajeures = personnes.Where(p => p.Age >= 18);
        var personnesMoinsDe50Ans = personnes.Where(p => p.Age < 50);

        var query = personnes.Select(p => new
        {
            Nom = p.Nom,
            Prenom = p.Prenom,
            Initiale = p.Nom[0] + "." + p.Prenom[0],
            TailleNomComplet = p.Nom.Length + p.Prenom.Length,
            Age = p.Age
        });

        foreach (var p in query)
        {
            Console.WriteLine($"Nom: {p.Nom}, Prénom: {p.Prenom}, Initiale: {p.Initiale}, Taille Nom Complet: {p.TailleNomComplet}, Age: {p.Age}");
        }

    }
}
