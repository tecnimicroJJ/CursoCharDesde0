namespace Argumentos_opcionales
{
    internal class Program
    {
         readonly int valor = 23;
         const int VALOR = 98; //se debe inicializar la constante siempre 

        static void Main(string[] args)
        {
            
            var data = new Program();
            data.metodo("C#",cantidad:32);
            //data.valor = 56; no se puede modificar el valor de una variable readonly.
        }

        //los parametros opcionales van al final de los parametros.
        //no se puede tener 2 datos opcionales con nombres juntos.
        //?para mandar a los argumentos valores nulos.
        private void metodo(String curso, int? cantidad, String nombre="Joel")
        {
           Console.WriteLine($"{cantidad} {curso} {nombre}");
        }

        //Ejemplo con las palabras claves readonly para crear variables de solo lectura.

    }
}