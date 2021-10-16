using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public class Rifle : Arma
    {
        public Rifle() : base("rifle")
        { }

        public override void Disparar()
        {
            Console.WriteLine("Púm púm púm...");
        }
    }
}
