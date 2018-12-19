using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition4
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "Mickael";
            String password = "123";
            Console.WriteLine("Entrez votre identifiant"); ;
            string userLogin = Console.ReadLine();
            Console.WriteLine("Entrez votre mot de passe");
            string userPassword = Console.ReadLine();

            if(login == userLogin && password == userPassword)
            {
                Console.WriteLine("Bienvenue à la Manu le Havre.");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
        }
    }
}
