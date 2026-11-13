
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


            // Etape 3 : Test de la structure Adresse
            Adresse adresse = new Adresse();

            adresse.NumeroCivique = 123;
            adresse.Rue = "Distillery Lane";
            adresse.Ville = "Toronto";
            adresse.CodePostal = "M1M 1M1";

            adresse.Afficher(); Console.ReadKey();
        }
    }
}
