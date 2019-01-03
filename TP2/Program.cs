using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(); // On crée une liste aléatoire
            int number;
            number = random.Next(1, 51); // De 1 à 50 
            
            int i;
            int tentative = 0;
            Console.WriteLine("Donnez un chiffre entre 1 et 50"); // On crée un message pour démarrer le jeu
            int.TryParse(Console.ReadLine(), out i); // On convertit la chaine de caractères 

        
            while (i != number)
            {
                if (i < 0 || i > 50)
                {
                    Console.WriteLine("Entrez un nombre entre 1 et 50 : ");
                          
                }
                else if (i < number)
                {
                    tentative++;
                    Console.WriteLine("Le nombre est plus grand, réessayez.");
                }
                else
                {
                    tentative++;
                    Console.WriteLine("Le nombre est plus petit, réessayez.");
                  
                }
                int.TryParse(Console.ReadLine(), out i);
            }
            tentative++;
            Console.WriteLine("Bravo !");
            Console.WriteLine("Vous avez fait " + tentative + " tentatives.");
            Console.ReadKey();

        }
    }
}
