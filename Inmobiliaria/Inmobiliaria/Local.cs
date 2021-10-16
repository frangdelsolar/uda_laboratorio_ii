using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public class Local : Inmueble
    {
        private int ventanas;

        public Local(int ventanas, String direccion, int superficie, int precioBase, int antiguedad)
        : base(direccion, superficie, precioBase, antiguedad)
        {
            this.ventanas = ventanas;
        }


        public override float calcPrecio()
        {
            int SUPERFICIE_LIMITE = 50;
            float precioBase = this.getPrecioBase();
            float precio = base.calcPrecio();

            if (this.getSuperficie() > SUPERFICIE_LIMITE)
            {
                precio += precioBase * 0.01f;
            }

            if (this.ventanas <= 1)
            {
                precio -= precioBase * 0.02f;
            }
            else if (this.ventanas >= 4)
            {
                precio += precioBase * 0.02f;
            }

            return precio;
        }
    }
}
