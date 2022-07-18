
namespace Clase_generica_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase 59,60,61,62,63,64
            var list = new ListaNodo();
            list.ListaVacia();
            list.addNodo(1);
            list.addNodo(2);
            list.addNodo(3);
            list.addNodo(4);
            //list.DeletePrimero();
            //list.DeleteUltimo();
            //list.DeletePosicionNodo(2);
            list.Sustituir(3, 6);
            list.addNodo(5);
            Console.WriteLine(list.Size()); 

            list.Listar();


            /*/Clase 58
            //Lista enlazada
            //Es una coleccion basada en punteros de nodos.
            //En .NET está implemementacion doblemente enlazada.
            //Es decir que elemento actual esta enlazados con su elemento anterior y posterior y los datos 
            //estan fragmentados,tiene un coste mayor de memoria al realizar las operaciones que la lista normal.
            LinkedList<string> nodos = new LinkedList<string>();
             * clase 4
             * Esta clase es mas rapida en la busqueda de elemento y optimizar el coste de memoria. 
             /Clase List, lista generica para poder crear colecciones de objeto y datos.
            //Puede ser un Objeto ,o todos los tipos ya conocidos string,int etc
            List<Object> lista = new List<Object>();
            List<String> lista2 = new List<String>();
            lista2.Add("A");
            lista.Add(32);
            lista.Add("Alex");
            lista.Add('a');
            lista.Add("Alex");
            lista.Add("Manuel");
            lista.Add("Alex");
            lista.Insert(3,"Joel");
             * 
             * //obtener el ultimo elemento en la coleccion de datos que exista aunque este repetido,se le puede indicar 
            //la posicion a partir de la que debe buscar.
            Console.WriteLine(lista.LastIndexOf("Alex"));
            lista.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("*****");
            //ahora revertimos la lista con el metodo reverse.
            lista.Reverse();
            lista.ForEach(item => Console.WriteLine(item));
            //comprobar que existe un elemento en la coleccion,con el metodo contains. 
            Console.WriteLine(lista.Contains(328));
            Console.WriteLine(lista.Contains(32));
            //comprobar que existe un elemento en la coleccion,con el metodo Exist.
            //utilizamos la expresiones lamba
            Console.WriteLine(lista.Exists(e => e.Equals("Joel")));

            /*clase 3
             * //lista.ForEach(item => Console.WriteLine(item));
            //indexof devuelve -1 cuando no encuentra el elemento y 0 cuando lo encuentra.
            Console.WriteLine(lista.IndexOf(32,2,2));
            //Si hay mas instrucciones dentro del foreach se le ponen la llaves.
            lista.ForEach(item =>
            {
                Console.WriteLine(item);
            });
            //Si podemos simplificar mas las cosas
            //

            //for con coleccion.
            foreach(var item in lista)
            {
                Console.WriteLine(item);
            };
            //List clase 2.
            //lista.Remove('a');
            //se le debe indicar unos parametros
            //for each
            /* 
             //for normal
             for (int i = 0; i < lista.Count; i++)
             {
                 Console.WriteLine(lista[i]);
             }
             //for con condicion.
             int j = 0;
             for(; ; )
             {
                 if (j < lista.Count)
                 {
                     Console.WriteLine(lista[j]);
                     j++;
                 }
                 else
                     break;
             }*/


        }
    }
}