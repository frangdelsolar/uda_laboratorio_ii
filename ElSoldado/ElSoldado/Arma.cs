using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public abstract class Arma 
    {
        String _nombre;

        public Arma(String nombre)
        {
            _nombre = nombre;
        }

        public abstract void Disparar();

        public String GetNombre() 
        {
            return _nombre;
        }
    }
}
