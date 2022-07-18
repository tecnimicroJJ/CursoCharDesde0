using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_de_clase
{
    public class Menu
    {
        private string s; 

        public Menu(string s) //Constructor con un parametro de tipo cadena.
        {
            this.s = s;
        }

        //para que se puede sobreescribir el metodo desde la clase hija se le pone la clase virtual.
        protected void getProducto()
        {
            Console.WriteLine(s);
        }


    }
}
