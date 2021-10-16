/*
 *  Laboratorio II
 *  Autor: Lic. Francisco Javier González del Solar
 */

using System;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Arma arma;

            Soldado soldado = new Soldado();

            do {
                option = MostrarBienvenida();

                switch (option)
                {
                    case 1:
                        if (soldado.TieneArma())
                        {
                            Console.WriteLine("Debes dejar el arma antes de recojer una nueva");
                        } else
                        {
                            arma = ElegirArma();

                            if (arma != null)
                            {
                                soldado.RecogerArma(arma);
                            }
                        }
                        break;

                    case 2:
                        if (soldado.TieneArma())
                        {
                            soldado.DejarArma(); ;
                        }
                        else
                        {
                            Console.WriteLine("No tienes ningún arma en la mano.");
                        }
                        break;

                    case 3:
                        if (soldado.TieneArma())
                        {
                            soldado.JalarGatillo(); ;
                        }
                        else
                        {
                            Console.WriteLine("No tienes ningún arma en la mano.");
                        }
                        break;

                    case 4:
                        if (soldado.TieneArma())
                        {
                            soldado.VerArmaEnUso(); ;
                        }
                        else
                        {
                            Console.WriteLine("No tienes ningún arma en la mano.");
                        }
                        break;
                }
                

            } while (option != 5);

            Console.WriteLine("Gracias por jugar a El Soldado!!!");
        }

        static int MostrarBienvenida()
        {
            int option;
            do
            {
                Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado ==-");
                Console.WriteLine("");
                Console.WriteLine("¿Qué desea hacer ?");
                Console.WriteLine("(presione el número correspondiente a la opción del menú)");
                Console.WriteLine("");
                Console.WriteLine("1 - Recoger arma.");
                Console.WriteLine("2 - Dejar arma.");
                Console.WriteLine("3 - Disparar.");
                Console.WriteLine("4 - Ver arma en uso.");
                Console.WriteLine("5 - Salir.");

                option = Convert.ToInt32(Console.ReadLine());

            } while (option <= 0 || option > 5);

            return option;
        }

        static Arma ElegirArma()
        {
            int option;
            Arma arma = null;
            do
            {
                Console.WriteLine("Por favor, escoja el arma que desea utilizar:");
                Console.WriteLine("");
                Console.WriteLine("1 - Revolver.");
                Console.WriteLine("2 - Rifle.");
                Console.WriteLine("3 - Escopeta.");
                Console.WriteLine("4 - Volver atrás.");

                option = Convert.ToInt32(Console.ReadLine());

            } while (option <= 0 || option > 4);

            switch(option)
            {
                case 1:
                    arma = new Revolver();
                    break;
                
                case 2:
                    arma = new Rifle();
                    break;

                case 3:
                    arma = new Escopeta();
                    break;

            }

            return arma;
        }
    }
}
