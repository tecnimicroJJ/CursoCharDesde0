

var curso = "Curso de C# desde cero";


//Se le puede indicar la subcadena desde una posicion.
//Se le puede indicar que extraiga los caracteres entre en dos posiciones de la cadena
Console.WriteLine("Cadena {0}", curso.Substring(9));
Console.WriteLine("Cadena {0}", curso.Substring(9,11));

//Metodo Replace.
var sub = curso.Replace("desde cero", ".net core");
Console.WriteLine(sub);

var sub2 = curso.Replace("c", "C");
Console.WriteLine(sub2);

//para quitar una posicion de texto de la cadena.
var sub3 = curso.Remove(5);
Console.WriteLine(sub3);

//para quitar una posicion de texto de la cadena.
var sub4 = curso.Remove(5,11);
Console.WriteLine(sub4);


