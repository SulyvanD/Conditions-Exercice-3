using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions___Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string sexe;

            Console.WriteLine("Vous avez quel age ?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Etes vous un homme ou une femme ?");
            sexe = Console.ReadLine();

            if (age > 18)
            {
                if (sexe == "Homme")
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
                }
            }
            else
            {
                if (sexe == "Homme")
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.")
                }
            }
        }
    }
}
