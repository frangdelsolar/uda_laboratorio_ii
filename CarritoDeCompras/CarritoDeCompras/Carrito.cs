using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    public class Carrito
    {
        int totalCamisas = 0;
        public void MostrarCarrito()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\t\t-\t Cantidad de camisas en el carro de compras: " + GetCantidadCamisas());
            Console.WriteLine("\t\t-\t Precio unitario: $" + GetPrecioUnitario());
            Console.WriteLine("\t\t-\t Precio total sin descuento: $" + GetPrecioSinDescuento());
            Console.WriteLine("\t\t-\t Tipo de descuento aplicado: %" + GetTipoDescuento());
            Console.WriteLine("\t\t-\t Precio final con descuento: $" + GetPrecioFinalConDescuento());
            Console.WriteLine("-----------------------------------------------------------");

        }

        private int GetCantidadCamisas()
        {
            return totalCamisas;
        }

        private int GetPrecioUnitario()
        {
            return 1000;
        }
        private int GetPrecioSinDescuento()
        {
            return totalCamisas * GetPrecioUnitario();
        }

        private int GetTipoDescuento()
        {
            int descuento = 0;

            if (totalCamisas > 3 && totalCamisas <= 5) descuento = 10;
            if (totalCamisas > 5) descuento = 20;

            return descuento;
        }

        private float GetPrecioFinalConDescuento()
        {
            float total = GetPrecioSinDescuento();
            float descuento = total * GetTipoDescuento() / 100;
            return total - descuento;
        }

        public void AgregarCamisa()
        {
            totalCamisas++;
        }

        public void EliminarCamisa()
        {
            if (totalCamisas > 0)
                totalCamisas--;
            else
            {
                Console.Clear();
                Console.WriteLine("No tienes camisas en el carro!!!");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

    }
}
