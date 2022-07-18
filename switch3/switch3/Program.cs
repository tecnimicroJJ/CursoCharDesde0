

//ejemplo de switch con multiple opciones,de esta forma se puede realizar diferente operaciones.

var (a, b, opcion) = (2, 6, "*"); //creacion y asginacion de los objetos,la ultima indica la opcion de switch que se ejecutara
//debe retornar el mismo tipo de datos que recibe.
var result = opcion switch
{
    "+" => a + b,
    "-" => a - b,
    "*" => a * b,

};

Console.WriteLine(result);

var (c, d, opcion2) = (2, 6, "*"); //creacion y asginacion de los objetos,la ultima indica la opcion de switch que se ejecutara
//debe retornar el mismo tipo de datos que recibe,esta devolvera un valor booleano,solo retorna un tipo de dato.
var result2 = opcion switch
{
    "+" => a == b,
    "-" => a < b,
    "*" => b > a,

};

Console.WriteLine(result2);
