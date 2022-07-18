using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeGolosinasHerenciaPoli
{
    public class Menu : IMenu
    {
        Almacen al = new Golosinas();

        public void golosinas()
        {
            var des = "";
            var valor = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Venta de Golosinas");
                if (al.GetProductos("").Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Desea agregar golosinas? presione la tecla s/n");
                    des = Console.ReadLine();

                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuantas golosinas vas a agregar");
                        int cant = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva golosinas");
                            Console.WriteLine("Ingrese la id");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            al.addProducto(new Producto
                            {
                                ID = id,
                                Nombre = nombre,
                                Precio = precio
                            }) ;
                            
                        }
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }

                    }
                    else 
                    {
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de golosinas y frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach (var item in al.GetProductos(""))
                    {
                        Console.WriteLine($"Codigo {item.ID} Golosina {item.Nombre} Precio {item.Precio}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        ventas();
                    }
                    else
                    {
                        valor = false;
                    }

                }

            } while (valor);
        }

        public double solicitarPago()
        {
            bool pagoCorrecto = false;
            double res = 0;
            while (!pagoCorrecto)
            {
                Console.WriteLine("Como desea pagar con: 10 o  con 5");
                res = double.Parse(Console.ReadLine());
                if(res !=5 && res !=10)
                {
                    Console.WriteLine("Pago no valido");
                }
                else
                {
                    pagoCorrecto = true;
                }
            }
            return res;
        }

        public void ventas()
        {
            double total = 0;
            string des = "";
            do
            {
                Console.WriteLine("Ingrese el producto");
                string producto = Console.ReadLine();
                var productos = al.GetProductos(producto);
                while (productos.Count.Equals(0))
                {
                    Console.WriteLine("Golosinas no disponibles, por favor seleccione otro.");
                    producto = Console.ReadLine();
                    productos = al.GetProductos(producto);

                }
                Console.WriteLine($"Su monto a pagar es : {productos[0].Precio} € euros");
                double pago = solicitarPago();
                while (pago < productos[0].Precio)
                {
                    Console.WriteLine("Faltan " + (productos[0].Precio - pago).ToString()+ "€ Euro");
                    pago += solicitarPago(); 
                }
                Console.WriteLine("Su cambio: " + (pago - productos[0].Precio).ToString());
                total += productos[0].Precio;
                Console.WriteLine("Su pago fue de: "+ total.ToString() + "€ Euro");
                Console.WriteLine("¿Desea realizar otra compra? s/n");
                des = Console.ReadLine();
            } while (des.Equals("s"));
        }
    }
}

