
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

            adresse.Afficher();

            // Etape 4 : Classe Etudiant
            Console.WriteLine("\n=== INFORMATIONS ETUDIANT ===");

            Etudiant etudiant1 = new Etudiant(
                "ETU001",
                "Dupont",
                "Jean",
                Programme.Informatique,
                adresse,
                85
            );

            etudiant1.Afficher();


            // Étape 5 : Gestion des exceptions
            Console.WriteLine("\n=== TEST DES NOTES ===");

            double[] notes = { -10, 75, 120 };

            for (int i = 0; i < notes.Length; i++)
            {
                try
                {
                    Etudiant etudiantTest = new Etudiant(
                        "TEST" + (i + 1),
                        "Test",
                        "Etudiant",
                        Programme.Informatique,
                        adresse,
                        notes[i]
                    );

                    Console.WriteLine(
                        "Note acceptée : " + etudiantTest.NoteFinale
                    );
                }
                catch (NoteInvalideException ex)
                {
                    Console.WriteLine(
                        "Erreur pour la note " + notes[i]
                        + " : " + ex.Message
                    );
                }
            }


            Console.ReadKey();
        }
    }
}
