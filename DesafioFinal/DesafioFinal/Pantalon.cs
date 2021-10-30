using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    class Pantalon : Prenda
    {
        bool esBermuda;

        public Pantalon(bool esBermuda, bool esPremium, float precioBase)
            : base(esPremium, precioBase)
        {
            this.esBermuda = esBermuda;
        }
        public override float CalcularPrecioFinal(int cantPrendas)
        {
            float precioFinal = this.PrecioBase;

            if (this.esBermuda == true) precioFinal -= this.PrecioBase * 0.2f;
            if (this.EsPremium == true) precioFinal += this.PrecioBase * 0.3f;
            precioFinal *= cantPrendas;

            return precioFinal;
        }
    }
}
