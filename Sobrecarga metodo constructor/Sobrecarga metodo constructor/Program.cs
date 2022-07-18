namespace Sobrecarga_metodo_constructor
{
    namespace Program
    {

        class Program {

            public Program()
            {

            }

            public Program(String name)
            {

            }

            public Program(String name, int age)
            {

            }


            static void Main(string[] args)
            {
                var data = new Program();
                Console.WriteLine("Hello, World!");
            }

        }
    }
}