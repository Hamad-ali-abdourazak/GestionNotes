using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gestion des Notes";
            Console.WriteLine("=== GESTION DES NOTES ===\n");

            List<Etudiant> etudiants = new List<Etudiant>();
            
            while (true)
            {
                Console.WriteLine("1. Ajouter étudiant");
                Console.WriteLine("2. Afficher étudiants");
                Console.WriteLine("0. Quitter");
                Console.Write("Choix : ");
                
                string choix = Console.ReadLine();
                
                if (choix == "1")
                {
                    Console.Write("Nom : ");
                    string nom = Console.ReadLine();
                    
                    Console.Write("Note : ");
                    double note = double.Parse(Console.ReadLine());
                    
                    etudiants.Add(new Etudiant { Nom = nom, Note = note });
                    Console.WriteLine("Étudiant ajouté !\n");
                }
                else if (choix == "2")
                {
                    Console.WriteLine("\n=== LISTE ===");
                    foreach (var e in etudiants)
                    {
                        Console.WriteLine($"{e.Nom}: {e.Note}/20");
                    }
                    Console.WriteLine();
                }
                else if (choix == "0")
                {
                    break;
                }
            }
        }
    }
    
    class Etudiant
    {
        public string Nom { get; set; }
        public double Note { get; set; }
    }
}
