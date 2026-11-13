
using System;

namespace ConsoleLabEtudiants
{
    class Program
    {
        static void Main(string[] args)
        {
            // Étape 1 : Test de l'énumération Programme
            Programme programme = Programme.Informatique;

            Console.WriteLine("Programme : " + programme);

            Console.ReadKey();
        }
    }
}
