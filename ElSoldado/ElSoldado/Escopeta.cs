using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public class Escopeta : Arma
    {
        public Escopeta() : base("escopeta")
        { }

        public override void Disparar()
        {
            Console.WriteLine("Pááá...");
        }
    }
}
