using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    public abstract class Inmueble
    {
        private String direccion;
        private int superficie;
        private int precioBase;
        private int antiguedad;

        public Inmueble(String direccion, int superficie, int precioBase, int antiguedad)
        {
            this.direccion = direccion;
            this.superficie = superficie;
            this.precioBase = precioBase;
            this.antiguedad = antiguedad;
        }

        public int getEdad()
        {
            return antiguedad;
        }

        public int getSuperficie()
        {
            return superficie;
        }

        public float getPrecioBase()
        {
            return precioBase;
        }

        public virtual float calcPrecio()
        {
            int EDAD_LIMITE = 15;
            float precio = precioBase;

            if (antiguedad <= EDAD_LIMITE)
            {
                precio -= precioBase * 0.01f;
            }
            else
            {
                precio -= precioBase * 0.02f;
            }
            return precio;
        }
    }
}
