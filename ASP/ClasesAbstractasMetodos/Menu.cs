using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractasMetodos
{
   
    public class Menu: Principal, IProductos
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
           
        }


        
        //protected virtual void getProducto()
        //{
        //    Console.WriteLine(s);
        //}
    }

    //La interface se le pone por convencion una I mayusculas al principio del nombre
    interface IProductos
    {
        void addProducto();
    }
}
