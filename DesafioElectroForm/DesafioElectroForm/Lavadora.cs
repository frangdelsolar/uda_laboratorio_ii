using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioElectroForm
{
    class Lavadora : Electrodomestico
    {
        private int carga = 5;

        public Lavadora()
            : base()
        {
            tipo = "Lavadora";
        }

        public Lavadora(int precioBase, int peso)
            : base(precioBase, peso)
        {
            tipo = "Lavadora";
            PrecioFinal();
        }

        public Lavadora(int carga, int precioBase, string color, string consumoEnergetico, int peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            tipo = "Lavadora";
            this.carga = carga;
            PrecioFinal();
        }

        public int Carga { get => carga; }

        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if (carga > 30) precioBase += 50;
        }
    }
}
