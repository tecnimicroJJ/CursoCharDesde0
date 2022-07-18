//importamos la libreria que nos hace falta para utilizar StringBuilder.
using System;
using System.Text;


//Crea un buffer para utilizar la cadena de texto y modificarla
var names = new StringBuilder("Alex Pagoada");
//[0] = 'a';
names.Append(" Joel").Append(" ").Append("Suazo");
// darle la capacidad a nuestro objeto names.Capacity = 2;
names.AppendFormat(" Age: {0}", 50);

//Se llama al metodo toString para que se vuelva una representacion de la cadena
Console.WriteLine(names.ToString());
//Console.WriteLine(names.Length);


