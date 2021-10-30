using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    abstract class Prenda
    {
        bool esPremium;
        float precioBase;

        protected Prenda(bool esPremium, float precioBase)
        {
            this.esPremium = esPremium;
            this.PrecioBase = precioBase;
        }

        public float PrecioBase { get => precioBase; set => precioBase = value; }
        public bool EsPremium { get => esPremium; }

        public abstract float CalcularPrecioFinal(int cantPrendas);
    }
}
