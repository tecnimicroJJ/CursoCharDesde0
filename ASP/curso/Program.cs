namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { };

                int data = array[0];
            }
            catch (FormatException e)
            {

                String m = e.Message;

                Console.WriteLine(m);
            }
            catch (IndexOutOfRangeException i)
            {

               throw new CursoException("Se ha generado una excepcion " + i);

               
            }finally
            {
                //sirve para mostrar un mensaje o liberar recursos del servidor.
                Console.WriteLine("Hello Wold");
            }
         }
    }
}