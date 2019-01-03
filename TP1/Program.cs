using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            double IMC, taille;
            int poids;


           
            Console.WriteLine("Quel est votre poids ? ");
            //On récupère le poids en testant sa validité 
            bool poidsvf = int.TryParse(Console.ReadLine(), out poids);
            Console.WriteLine("Quelle est votre taille en m ?");
            bool taillevf = double.TryParse(Console.ReadLine(), out taille;
           
            if (poidsvf && taillevf)
            {
                IMC = (poids / Math.Pow(taille, 2));


                if (IMC < 16.5 && IMC > 0)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Dénutrition.");
                else if (IMC >= 16.5 && IMC < 18.5)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Maigreur.");
                else if (IMC >= 18.5 && IMC < 25)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Corpulence normale.");
                else if (IMC >= 25 && IMC < 30)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Surpoids.");
                else if (IMC >= 30 && IMC < 35)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Obésité modérée.");
                else if (IMC >= 35 && IMC < 40)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Obésité sévère.");
                else if (IMC >= 40)
                    Console.WriteLine("Vous avez un IMC de " + IMC + ", vous êtes en Obésité morbide ou sévère.");
                else
                    Console.WriteLine("Vous avez mal entré vos valeurs");
            }
            else
                Console.WriteLine("Vous avez mal entré vos valeurs");
            Console.ReadKey();
        }
    }
}
