namespace ClasesAbstractasMetodos
{
    internal class Program : Menu
    {
        public Program(String s) : base(s)
        {

        }

        static void Main(string[] args)
        {
            new Program("Empresa: PDHN").getProducto();
        }

    //    protected override void getProducto()
    //    {
    //        Console.WriteLine("Curso de C# desde cero");
    //    }
    }
}