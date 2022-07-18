namespace ClasesGenericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Books<Book>();
            //Asignamos los datos de tipo string al nuevo libro.
            book.Add(new Book
            {
                Id = 1,
                Title = "Asp.net desde cero"
            });
            book.Add(new Book
            {
                Id = 2,
                Title = "C# desde cero"
            });
            Console.WriteLine(book.Get(0).Id + " " + book.Get(0).Title);   
        }
    }
}