/*
 *  Laboratorio II
 *  Autor: Lic. Francisco Javier González del Solar
 */

using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            int option;
            String salir;

            do
            {
                Console.Clear();
                option = MostrarMenuPrincipal(carrito);

                switch (option)
                {
                    case 1:
                        carrito.AgregarCamisa();
                        break;

                    case 2:
                        carrito.EliminarCamisa();
                        break;

                    case 3:
                        Console.WriteLine("¿Está seguro que desea salir? S/N");
                        salir = Console.ReadLine();
                        if (salir == "S")
                            option = 3;
                        else
                            option = 5;
                        break;

                }
            } while (option != 3);

            Console.WriteLine("Gracias por utilizar el carrito de compras");
        }

        static int MostrarMenuPrincipal(Carrito carrito)
        {
            int option;
            do
            {
                Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1 - Añadir camisa al carro de compras.");
                Console.WriteLine("2 - Eliminar camisa del carro de compras.");
                Console.WriteLine("3 - Salir.");

                carrito.MostrarCarrito();

                Console.WriteLine("Ingrese una opción del menú.");


                option = Convert.ToInt32(Console.ReadLine());

            } while (option <= 0 || option > 3);

            return option;
        }
    }
}
