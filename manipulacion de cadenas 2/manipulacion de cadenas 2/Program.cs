
//son inmutables,no se puede modificar su contenido,pero si se pueden concatenar los datos y se puede cambiar el dato.
var nombres = (nombre1: "Alex", age1:23, nombre2: "Joel");


//formateamos a tipo string,el simbolo $ es para indicar que se va a formatear un dato.
//se puede llamar a todos los elementos que componen a nombre.
Console.WriteLine($"{nombres.nombre1} edad {nombres.age1}");

