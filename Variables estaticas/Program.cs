namespace Variables_estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Conversor();
            Conversor.velocidad = 3.0;
            var data1 = new Conversor();
          }

        class Conversor 
        {
            //mantiene la informacion,hasta que se le vuelva a inicializar.
            public static double velocidad;
        
        }
    }
}