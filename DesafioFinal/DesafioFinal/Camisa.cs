using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    class Camisa : Prenda
    {
        bool esMangaCorta;

        public Camisa(bool esMangaCorta, bool esPremium, float precioBase)
            : base(esPremium, precioBase)
        {
            this.esMangaCorta = esMangaCorta;
        }
        public override float CalcularPrecioFinal(int cantPrendas) {
            float precioFinal = this.PrecioBase;
            Console.WriteLine(precioFinal);
            
            if (this.esMangaCorta == true) precioFinal -= (this.PrecioBase * 0.1f);
            Console.WriteLine(precioFinal);

            if (this.EsPremium == true) precioFinal += (this.PrecioBase * 0.3f);
            Console.WriteLine(precioFinal);

            precioFinal *= cantPrendas;
            Console.WriteLine(precioFinal);


            return precioFinal;
        }


    }
}
