using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class Pato : IVolador
    {
        int energia = 100;
        public void Volar()
        {
            energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡Cuack!");
        }
    }
}
