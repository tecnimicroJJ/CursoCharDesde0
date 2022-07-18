
int pisos = 0;
int[] arreglo = new int[1];
//Mostramos un mensaje por consola
Console.WriteLine("Ingrese el numero de pisos");
//obtenemos el valor y lo convertimos en un entero.
pisos = Convert.ToInt16(Console.ReadLine());

for (int i = 1; i <= pisos; i++)
{
    /*Creamos un arreglo y le indicamos el valor de la i del ciclo for
     que sera el tamaño que tendra el arreglo cada vez que el ciclo for
    se ejecute*/

    int[] pascal = new int[i];
    //Ciclo for que se decrementa para forma el triangulo
    for (int j = pisos; j < i; j--)
    {
        Console.WriteLine("");
    }
    //Ciclo for que genera la suma de las cifras.
    for (int k = 0; k < i; k++)
    {
        //Condicion que evalua la variable del ciclo for
        if (k == 0 || k == (i - 1))
        {
            pascal[k] = 1;
        }
        else 
        {
            //sumamos los numeros que estan en cada posicion
            //triangulo que forma el triangulo.
            pascal[k] = arreglo[k] + arreglo[k - 1];
        }
        Console.Write("[" + pascal[k] + "]");
    }
    arreglo = pascal;
    Console.WriteLine(" ");

}
