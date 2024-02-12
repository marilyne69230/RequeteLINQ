using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> entiers = new List<int> { 4, 5, 2, 3, 1, 1, 0, 5, 8, 9, 10, 15, 16, 20, 21, 4, 5 };

        // AFFICHER LES NOMBRES SUPERIEURS A 5
        var query = from obj in entiers
                    where obj > 5
                    select obj;
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // AFFICHER LES NOMBRES ENTRE 15 ET 20
        var query2 = from obj in entiers
                     where obj >= 15 && obj < 20
                     select obj;
        foreach (var item in query2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // AFFICHER LES NOMBRES SUPERIEURS A 2, DIVISIBLE PAR 2, INFERIEUR A 20 ET DIFFERENT DE 8
        var query3 = from obj in entiers
                     where obj > 2 && obj % 2 == 0 && obj < 20 && obj != 8
                     select obj;
        foreach (var item in query3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();


        List<string> fruits = new List<string> {"Banane", "Ananas", "Cerise", "Framboise", "Groseilles",
                                         "Pomme", "Poire", "Tomate", "Kiwi", "Raisin", "Mangue", "Datte"};

        // AFFICHER LES FRUITS DE PLUS DE 5 LETTRES 
        var query4 = from fruit in fruits
                     where fruit.Length > 5
                     select fruit;
        foreach (var item in query4)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // AFFICHER LES FRUITS COMMENCANT PAR P ET DE PLUS DE 4 LETTRES ET QUI CONTIENT UN O
 var query5 = from fruit in fruits
              where fruit.StartsWith("P") &&
              fruit.Length > 4 &&
              fruit.Contains("o") &&
              !fruit.Contains("m")
              select fruit;

        foreach (var item in query5)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // AFFICHE LES FRUITS PAR ORDRE CROISSANT
        var query6 = from fruit in fruits
                     orderby fruit.Length
                     select fruit;

        foreach (var item in query6)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

    }
}
