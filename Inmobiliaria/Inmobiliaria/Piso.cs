using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public class Piso : Inmueble
    {

        public int nivel;

        public Piso(int nivel, String direccion, int superficie, int precioBase, int antiguedad)
        : base(direccion, superficie, precioBase, antiguedad)
        {
            this.nivel = nivel;
        }

    
        public override float calcPrecio()
        {
            int PISO_LIMITE = 3;
            float precioBase = this.getPrecioBase();
            float precio = base.calcPrecio();

            if (this.getSuperficie() >= PISO_LIMITE)
            {
                precio += precioBase * 0.03f;
            }

            return precio;
        }
    }
}
