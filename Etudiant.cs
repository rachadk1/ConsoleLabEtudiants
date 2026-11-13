using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabEtudiants
{
    public class Etudiant
    {
        public string Matricule { get; set; } = "";
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";
        public Programme Programme { get; set; }
        public Adresse Adresse { get; set; }
        public double NoteFinale { get; set; }
    }
}
