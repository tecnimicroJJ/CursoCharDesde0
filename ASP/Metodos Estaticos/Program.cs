namespace Metodos_Estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Conversor();
            Conversor.velocidad = 3.0;
            var data1 = new Conversor();
            //Para invocar el metodo de la clase estatica debemos poner el nombre
            Conversor.Conversor1();
            Conversor.Conversor2();


        }

        class Conversor
        {
            public static double velocidad;


            public static void Conversor1()
            {
                velocidad += 20;
                int datos = 20;

            }

            public static void Conversor2()
            {
                velocidad += 78;

            }


        }

    }
}