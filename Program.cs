// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Permet d'indiquer qu'il faut utiliser différentes fonctionnalités
// de l'environement dotnet
// namespace (espace de nom)
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Hello World! ");
        // Pour faire biper le terminale

        Console.Beep();
        
        // Permet de renouveler le terminal
        Console.Clear();

        // Ajouter un titre
        Console.Title = "Hakan Kenter";

        // Ecrire du texte
        Console.Write("TESST");

        // Pour un retour a la ligne
        Console.Write("Bonjour ! Comment aller vous ? \n");
        
        // Tabulation
        Console.Write("\t Bonjour ! Comment aller vous ? \n");
    }
}

