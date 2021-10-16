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

namespace DesafioVolador
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boening747 avion = new Boening747();
            Superman sman = new Superman();

            TorreDeControl torre = new TorreDeControl();

            torre.AgregarVolador(pato);
            torre.AgregarVolador(avion);
            torre.AgregarVolador(sman);

            torre.VuelenTodos();
        }
    }
}
