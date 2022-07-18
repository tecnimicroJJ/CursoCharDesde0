using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    public class CursoException : Exception
    {
        public CursoException(string message): base(message) //para heredar de la clase exception
        {

        }
    }
}
