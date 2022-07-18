namespace PasarArregloObjectoParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Puede almacenar cualquier tipo de datos.
            Object[] parametros = {"Alex", 25, true};
            new Program().metodo(parametros);
            new Program().metodo2("Alex", 25, true, 'A');
            //se crea una variable llamada data y tiene que ser inicializada para utilziar en el metodo 3 con la palabra clave ref
            int data = 67;
            new Program().metodo3(ref data);
            Console.WriteLine(data);

            //metodo4
            int data2 ;
            new Program().metodo4(out data2);
            Console.WriteLine(data2);


        }
        
        
        //Crear un metodo con una coleccion de datos,para no sobrecarga el metodo.
        private void metodo(object[] parametros)
        { 
            String nombre = (String)parametros[0];
            int edad = (int)parametros[1];
            bool opcion = (bool)parametros[2];
        
        }

        private void metodo2(params object[] parametros)
        {
            String nombre = (String)parametros[0];
            int edad = (int)parametros[1];
            bool opcion = (bool)parametros[2];
            char letra = (char)parametros[3];

        }

        //la palabra in es para proteger el valor que viene por el parametro y que no se pueda modificar,se convierte en inmutable.
        private void metodo(in int valor)
        {
            Console.WriteLine(valor);

        }

        //Se utiliza la palabra clave ref para hacer una valor que se modifica dentro del metodo y se actualiza en el llamada.
        private void metodo3(ref int valor) 
        {

            valor = 50 + 20;
        
        }

        private void metodo4(out int valor)
        {

            valor = 50 + 20;

        }







    }
}