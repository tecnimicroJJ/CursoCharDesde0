namespace Funciones
{
    //funciones en C#
    internal class Program
    {
        static void Main(string[] args)
        {
            int data;
            string nombre;
           // new Program().metodo(out data);
            mensaje();
            Console.WriteLine(nombre);
            void mensaje() => nombre ="Alex Joel";
            
        }
        
        private void metodo(out int valor)
        {
            valor = 50 + 20;

            funcion(valor);
            funcion2();

            void funcion(int valor)
            {
                Console.WriteLine($"Hola soy una funcion {valor}");
            }


            static int funcion2() => 50 + 20;
                

        }
    }
}