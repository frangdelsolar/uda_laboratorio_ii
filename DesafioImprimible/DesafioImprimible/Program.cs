using System;

/*
 *  Laboratorio II
 *  Prof. Jesús Arce
 *  
 *  Desafío de interfaces
 *  
 *  Autor: Lic. Francisco Javier González del Solar
 * 
 */

namespace DesafioImprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento doc = new Documento();

            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(doc);

            impresora.ImprimirTodo();
        }
    }
}
