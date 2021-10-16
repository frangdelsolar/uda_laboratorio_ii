using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public class Soldado
    {
        public Arma _arma;

        public Soldado() { }

        public bool TieneArma()
        {
            return !(_arma == null);
        }

        public void RecogerArma(Arma arma)
        {
            _arma = arma;
        }

        public void DejarArma()
        {
            _arma = null;
        }

        public void JalarGatillo()
        {
            _arma.Disparar();
        }

        public void VerArmaEnUso()
        {
            Console.WriteLine("Portas un/a " + _arma.GetNombre());
        }

    }
}
