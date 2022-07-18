namespace Herencia_de_clase
{
    public class Program : Menu //Para heredar de la clase padre.
    {
        public Program(String s) : base(s) //Sirve para pasar parametro a la clase padre desde la hija.  
        {

        }

        static void Main(string[] args)
        {
            new Program("Empresa: PDHN").getProducto();
        }

    //    //override es para poder sobreescribir el metodo heredado junto a la palabra virtual.
    //    protected void getProducto()
    //    {
    //        Console.WriteLine("Curso de C# desde Cero");
    //    }
    }
}