using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabEtudiants
{
    public class Repository<T>
    {
        private List<T> elements = new List<T>();

        public void Ajouter(T element)
        {
            elements.Add(element);
        }

        public List<T> ObtenirTous()
        {
            return elements;
        }

        public int NombreElements()
        {
            return elements.Count;
        }
    }
}
