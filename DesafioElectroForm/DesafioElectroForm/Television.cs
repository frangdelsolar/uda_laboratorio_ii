using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioElectroForm
{
    class Television : Electrodomestico
    {
        private int resolucion = 20;
        private bool sintonizador = false;

        public Television()
            : base()
        {
            tipo = "TV";
        }

        public Television(int precioBase, int peso)
            : base(precioBase, peso)
        {
            tipo = "TV";
            PrecioFinal();
        }

        public Television(int resolucion, bool sintonizador, int precioBase, string color, string consumoEnergetico, int peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            tipo = "TV";
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
            PrecioFinal();
        }

        public int Resolucion { get => resolucion; }
        public bool Sintonizador { get => sintonizador; }

        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if (resolucion > 40) precioBase += Convert.ToInt32(precioBase * 0.3);
            if (sintonizador == true) precioBase += Convert.ToInt32(precioBase * 0.3);
        }
    }
}
