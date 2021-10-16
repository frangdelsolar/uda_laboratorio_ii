using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class Superman : IVolador
    {
        int experiencia = 0;
        public void Volar()
        {
            experiencia += 3;
            Console.WriteLine("Estoy volando como un campeón...");
        }
    }
}
