
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


            // Etape 7 : Recherche d'un étudiant
            Console.WriteLine("\n=== RECHERCHE D'ETUDIANTS ===");

            // Recherche qui est supposée réussir
            Etudiant? resultat1 = RechercherEtudiant(college, "ETU003");

            if (resultat1 != null)
            {
                Console.WriteLine("Etudiant trouvé :");
                resultat1.Afficher();
            }
            else
            {
                Console.WriteLine("Etudiant introuvable.");
            }

            // Recherche qui est supposée échouer
            Etudiant? resultat2 = RechercherEtudiant(college, "ETU999");

            if (resultat2 != null)
            {
                Console.WriteLine("Etudiant trouvé :");
                resultat2.Afficher();
            }
            else
            {
                Console.WriteLine("Etudiant introuvable.");
            }


            // Etape 8 : Calcul de la moyenne du groupe
            Console.WriteLine("\n=== MOYENNE DU GROUPE ===");

            double moyenne = CalculerMoyenne(college);

            Console.WriteLine("Nombre d'étudiants : " + college.NombreElements());
            Console.WriteLine("Moyenne générale : " + moyenne.ToString("F2") + " / 100");


            Console.ReadKey();
        }


        static Etudiant? RechercherEtudiant(
            Repository<Etudiant> college, string matricule)
        {
            foreach (Etudiant etudiant in college.ObtenirTous())
            {
                if (etudiant.Matricule == matricule)
                {
                    return etudiant;
                }
            }

            return null;
        }



        static double CalculerMoyenne(Repository<Etudiant> college)
        {
            double somme = 0;

            foreach (Etudiant etudiant in college.ObtenirTous())
            {
                somme += etudiant.NoteFinale;
            }

            if (college.NombreElements() == 0)
            {
                return 0;
            }

            return somme / college.NombreElements();
        }


    }

}
