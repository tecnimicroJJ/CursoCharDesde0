namespace Tipos_de_Metodos_en_Cchar
{
    internal class Program
    {
        //variable global;
        private String cadena;
        private String verMayusculas = "";
        private String verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMy;
        private string[] tempMn;

        public Program(String cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new String[n];
            Minusculas = new String[n];
            tempMy = new String[n]; 
            tempMn = new String[n]; 

    }

        static void Main(string[] args)
        {
            //para poder invocar cualquier metodo dentro del main.
            var cadena = Console.ReadLine();
            var data = new Program(cadena);
            Console.WriteLine("Las letras Maysuculas son: " +data.mayusculas()
                + "\n\n" + "Las letras Minusculas son: "+ data.minusculas());

            //data.metodoPrivado();
            //string retorno = data.metodoPrivadoString();
            //Console.WriteLine(retorno);
            //int numero = data.metodoPrivadoInt();
            //Console.WriteLine(numero);

            //variable local tipo string,para utilizar la global hay que eliminar la local.
            //String names; 

        }


        public String mayusculas() 
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]);
                }


            }

            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null) 
                {
                    Mayusculas[i] = tempMy[i];
                    verMayusculas = $"{verMayusculas} , {Mayusculas[i]}";

                }
            }

            return verMayusculas;
        }

        public String minusculas() 
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsLower(cadena[i]))
                {
                    tempMn[i] = Convert.ToString(cadena[i]);
                }
            }

            for (int i = 0; i < tempMn.Length; i++)
            {
                if (tempMn[i] != null)
                {
                    Minusculas[i] = tempMn[i];
                    verMinusculas = $"{verMinusculas} , {Minusculas[i]}";

                }
            }
            return verMinusculas;
        }

       
        /*private void metodoPrivado() 
        {
            Console.WriteLine("Hola mi primer metodo privado");
        }

        private string metodoPrivadoString()
        {
            names = "Jose";
            return ("Hola mi primer metodo privado tipo string");
        }

        private int metodoPrivadoInt()
        {
            return Convert.ToInt16("56");
        }


        public void metodoPublico() 
         {
             Console.WriteLine("Hola mi primer metodo publico");
         }*/





    }
}