using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class Boening747 : IVolador
    {
        int horasVuelo = 0;
        public void Volar()
        {
            horasVuelo += 13;
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
