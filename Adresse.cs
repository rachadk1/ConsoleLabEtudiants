using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabEtudiants
{
    public struct Adresse
    {
        public int NumeroCivique;
        public string Rue;
        public string Ville;
        public string CodePostal;

        public void Afficher()
        {
            Console.WriteLine("Adresse : " + NumeroCivique
                              + " " + Rue + ", " + Ville
                              + ", " + CodePostal);
        }
    }
}
