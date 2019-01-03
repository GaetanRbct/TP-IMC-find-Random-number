using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2bis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Message de Bienvenue & de démarrage de jeu.
            Console.WriteLine("Bienvenue dans le jeu du + ou -. \nDevinez un nombre entre 1 & 50.");
            //On fait tirer un nombre aléatoire à la machine.
            Random random = new Random();
            int number = random.Next(1, 51);
            int tentative = 0;
            bool trouve = false;
            //Tant que je n'ai pas deviné le nombre, je continue de faire des propositions.
            while (!trouve)
            {
                //Faire des propositions. 
                int proposition;
            
            //Si la proposition est valide, 
            if (int.TryParse(Console.ReadLine(), out proposition))
                {                    
                    //j'augmente le nombre de tentatives.
                    tentative++;
                    //Si le nombre est plus grand que celui à deviner, j'affiche un message disant que le nombre est trop grand. 
                    if (proposition > number)
                    {
                        Console.WriteLine("Le nombre est trop grand !!!!!");
                    }
                    //S'il est plus petit, j'affiche un message disant que le nombre est trop petit.
                    else if ( proposition < number)
                    {
                        Console.WriteLine("Le nombre est trop petit !!!!");
                    }
                    //Sinon, j'affiche un message de félicitations & je sors de la boucle.
                    else
                    {
                        Console.WriteLine("Félicitations, vous avez trouvé le nombre en " + tentative + " tentatives !");
                        trouve = true;
                    }
                
                }
            }
            //Fin du programme.

            Console.ReadKey();
        }
    }
}
