
//son inmutables,no se puede modificar su contenido,pero si se pueden concatenar los datos y se puede cambiar el dato.
string name1 = "Alex";
string name2 = "Joel";
string name3 = name1;

name1 += name2; 


Console.WriteLine("Name {0}", name1);

Console.WriteLine("Name {0}", name3);

