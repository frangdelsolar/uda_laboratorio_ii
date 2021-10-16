using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public class Revolver : Arma
    {
        public Revolver() : base("revolver")
        { }

        public override void Disparar()
        {
            Console.WriteLine("Púm...");
        }
    }
}
