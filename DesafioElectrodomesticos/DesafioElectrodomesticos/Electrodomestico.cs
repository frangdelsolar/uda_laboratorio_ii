using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioElectrodomesticos
{
    abstract class Electrodomestico
    {
        public int precioBase = 100;
        private String color = "blanco";
        private String consumoEnergetico = "F";
        private int peso = 5;

        protected Electrodomestico()
        {
        }

        protected Electrodomestico(int precioBase, string color, string consumoEnergetico, int peso)
        {
            this.precioBase = precioBase;
            this.color = color.ToLower();
            this.consumoEnergetico = consumoEnergetico.ToUpper();
            this.peso = peso;
            
            ComprobarConsumoEnergetico(this.consumoEnergetico);
            ComprobarColor(this.color);
        }

        protected Electrodomestico(int precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public int PrecioBase { get => precioBase; }
        public string Color { get => color; }
        public string ConsumoEnergetico { get => consumoEnergetico; }
        public int Peso { get => peso; }

        protected void ComprobarConsumoEnergetico(string letra)
        {
            String letrasValidas = "ABCDEF";
            bool isValid = letrasValidas.Contains(letra);
            if (isValid == true)
            {
                return;
            } else
            {
                this.consumoEnergetico = "F";
            }
        }

        protected void ComprobarColor(string color)
        {
            List<String> colores = new List<String>();
            colores.Add("blanco");
            colores.Add("negro");
            colores.Add("rojo");
            colores.Add("azul");
            colores.Add("gris");

            bool isValid = colores.Contains(color);
            if (isValid == true)
            {
                return;
            }
            else
            {
                this.color = "blanco";
            }
        }

        public virtual void PrecioFinal()
        {
            switch (consumoEnergetico)
            {
                case "A":
                    precioBase = 100;
                    break;

                case "B":
                    precioBase = 80;
                    break;

                case "C":
                    precioBase = 60;
                    break;
                
                case "D":
                    precioBase = 50;
                    break;
                
                case "E":
                    precioBase = 30;
                    break;

                case "F":
                    precioBase = 10;
                    break;

            }

            if (peso >= 0 && peso < 20) precioBase += 10;
            else if (peso >= 20 && peso < 50) precioBase += 50;
            else if (peso >= 50 && peso < 80) precioBase += 80;
            else if (peso >= 80) precioBase += 100;

        }

    }
}
