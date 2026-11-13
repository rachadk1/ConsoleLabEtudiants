using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabEtudiants
{
    public class NoteInvalideException : Exception
    {
        public NoteInvalideException(string message)
            : base(message)
        {
        }
    }
}
