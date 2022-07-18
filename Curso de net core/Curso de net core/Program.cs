using System;

namespace Curso_de_net_core
{

    class program
    {

        static void Main(String[] args)
        {
            //variables.
            int year = 10; //tipo entero
            double doble = 2.5;
            int day = Convert.ToInt16("12");
            string nombre = "Jorge";
            String nombre2 = "Manzano";
            decimal decimals = 2.07M;
            float flotante = 8.0f;
            //float 7 digitos 32 bits
            //double 15-16digitos 64 bits
            //decimal 28-29 digitos 128bits
            //variables booleanas,tipo character.
            bool valor = false; //solo puede almacenar false o true.
            char letra = 'A'; //se debe poner con comillas simples.
            Decimal de = 28.6M;
            


            //cadena de texto con variable encadenada
            Console.WriteLine("Hola Julian desde C# " + year);

            //cadena de texto con variable exterior
            Console.WriteLine("Hola {3} {4} desde C# {0}, {1}, {2} {5} {6}", year, day, doble, nombre, nombre2, decimals, valor);

            Console.WriteLine("Hola ya esta es la 3 cadena {0} {1} ", letra, de);

            Console.WriteLine("Empezamos con los operadores aritmeticos");


            Console.ReadLine();


        }
    }
}