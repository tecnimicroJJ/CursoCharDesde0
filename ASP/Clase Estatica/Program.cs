namespace Clase_Estatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, repetir = 0;
            var con = new Conversor();

            do
            {
                Console.WriteLine("Escoja una de las opciones");
                Console.WriteLine("1. - Convetir ms/s km/s");
                Console.WriteLine("2. - Convetir km/h a m/s ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        con.Conversor1();
                        break;
                    case 2:
                        con.Conversor2();
                        break;
                    default:
                        Console.WriteLine("Opcion Erronea");
                        break;
                }

                Console.WriteLine("Si desea repetir coloque el valor 1 o cualquier tecla para salir");
                repetir = Convert.ToInt32(Console.ReadLine());

            } while (repetir == 1);
        }

        //No se puede Instanciar las clases estaticas.
        //No se le puede crear un metodo constructor.
        //puede tener metodo constructor estatico.
        //no puede tener el metodo constructor no puede tener modificador public, ni estatico. ,
        class Conversor
        {
 
            private double velocidad;

            public void Conversor1()
            {
                Console.WriteLine("Introduzca una velocidad en m/s");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{velocidad} m/s = {velocidad * 3600/1000} km/h");

            }

            public void Conversor2()
            {
                Console.WriteLine("Introduzca una velocidad en m/s");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{velocidad} km/h = {velocidad * 1000/ 3600 } m/h");
            }

        }


    }



}