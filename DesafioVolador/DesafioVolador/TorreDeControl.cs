using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class TorreDeControl
    {
        List<IVolador> voladores = new List<IVolador>();

        public void VuelenTodos()
        {
            foreach (IVolador volador in voladores)
            {
                volador.Volar();
            }
        }

        public void AgregarVolador(IVolador volador)
        {
            voladores.Add(volador);
        }
    }
}
