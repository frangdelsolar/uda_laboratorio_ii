using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioElectrodomesticos
{
    class Lavadora : Electrodomestico
    {
        private int carga = 5;

        public Lavadora()
            : base ()
        {
        }

        public Lavadora(int precioBase, int peso)
            : base(precioBase, peso)
        {
        }

        public Lavadora(int carga, int precioBase, string color, string consumoEnergetico, int peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public int Carga { get => carga; }

        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if (carga > 30) precioBase += 50;
        }
    }
}
