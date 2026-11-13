using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabEtudiants
{
    public class Etudiant : IAffichable
    {
        // Propriétés
        public string Matricule { get; set; } = "";
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";
        public Programme Programme { get; set; }
        public Adresse Adresse { get; set; }
        public double NoteFinale { get; set; }

        // Constructeur
        public Etudiant(string matricule, string nom,
                       string prenom, Programme programme,
                       Adresse adresse, double noteFinale)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Programme = programme;
            Adresse = adresse;
            NoteFinale = noteFinale;
        }

        // Méthode imposée par IAffichable
        public void Afficher()
        {
            Console.WriteLine("Matricule : " + Matricule);
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prénom : " + Prenom);
            Console.WriteLine("Programme : " + Programme);
            Adresse.Afficher();
            Console.WriteLine("Note finale : " + NoteFinale);
        }
    }
}
