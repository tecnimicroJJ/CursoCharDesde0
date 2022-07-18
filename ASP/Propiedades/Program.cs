namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Estudiante()
            {
                Nombre = "Alex",
                Edad = 33,
                Calificacion = 50.6
            };

            var s2 = new Estudiante()
            {
                Nombre = "Joel",
                Edad = 38,
                Calificacion = 80.6
            };

            var s3 = new Estudiante()
            {
                Nombre = "PDHN",
                Edad = 23,
                Calificacion = 60.6
            };

            var school = new School();
            school.addStudent(s1);
            school.addStudent(s2);
            school.addStudent(s3);
            bool valor = false;

            do
            {
                Console.WriteLine("Ingrese el nombre");
                String name = Console.ReadLine();
                valor = school.buscarPorNombre(name);

            } while (valor);
            Console.ReadKey();

        }
    }
}