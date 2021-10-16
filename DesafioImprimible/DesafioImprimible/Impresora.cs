using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioImprimible
{
    class Impresora
    {
        List<Iimprimible> colaImpresion = new List<Iimprimible>();

        public void ImprimirTodo()
        {
            foreach(Iimprimible imp in colaImpresion)
            {
                imp.imprimir();
            }
        }

        public void AgregarImprimible(Iimprimible imp)
        {
            colaImpresion.Add(imp);
        }

    }
}
