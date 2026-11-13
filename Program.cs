
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
                "Meriem",
                "Khalil",
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


            // Etape 6 : Gestion des étudiants avec Repository
            Console.WriteLine("\n=== REPOSITORY ETUDIANTS ===");

            Repository<Etudiant> college = new Repository<Etudiant>();

            Etudiant etudiant2 = new Etudiant(
                "ETU002", "Rachad", "K.",
                Programme.Reseau, adresse, 78
            );

            Etudiant etudiant3 = new Etudiant(
                "ETU003", "Youness", "B.",
                Programme.Cybersecurite, adresse, 92
            );

            Etudiant etudiant4 = new Etudiant(
                "ETU004", "Diallo", "Aminata",
                Programme.IntelligenceArtificielle, adresse, 88
            );

            Etudiant etudiant5 = new Etudiant(
                "ETU005", "Yves", "F.",
                Programme.Informatique, adresse, 65
            );

            college.Ajouter(etudiant1);
            college.Ajouter(etudiant2);
            college.Ajouter(etudiant3);
            college.Ajouter(etudiant4);
            college.Ajouter(etudiant5);

            Console.WriteLine(
                "Nombre d'étudiants : " + college.NombreElements()
            );



            Console.ReadKey();
        }
    }
}
