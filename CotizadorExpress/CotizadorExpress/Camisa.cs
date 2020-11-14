using System;

namespace CotizadorExpress
{
    public class Camisa : Prenda
    {
        private bool esMangaCorta; //F es manga larga
        private bool cuelloMao; //F es convencional

        public Camisa()
        {
            MenuManga();
            MenuCuello();
            if (esMangaCorta)
            {
                if (cuelloMao)
                {
                    CantidadEnStock = 200;
                }
                else
                {
                    CantidadEnStock = 300;
                }
            }
            else
            {
                if (cuelloMao)
                {
                    CantidadEnStock = 150;
                }
                else
                {
                    CantidadEnStock = 350;
                }
            }

            do
            {
                Console.WriteLine();
                try
                {
                    Console.Write("Ingrese el precio base de la camisa: ");
                    PrecioPrenda = double.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Precio invalido. Intente nuevamente");
                }

            } while (PrecioPrenda == 0);
        }

        public override double calcularPrecio()
        {
            double variacion, variacion2 = 0, variacion3 = 0, variacion4 = 0;
            variacion = base.calcularPrecio();
            if (esMangaCorta)
            {
                if (cuelloMao)
                {
                    variacion2 = PrecioPrenda * 0.1;
                    var temporal = PrecioPrenda - variacion2;
                    variacion3 = temporal * 0.03;

                }
                else
                {
                    variacion2=PrecioPrenda*0.1;
                }
            }
            else
            {
                if (cuelloMao)
                {
                    variacion4 = PrecioPrenda * 0.03;
                }
            }


            return (PrecioPrenda+variacion-variacion2+variacion3+variacion4);
        }

        private void MenuManga()
        {
            char entrada = '0';
            var exit = false;
            do
            {
                Console.Write(@"
                Elija el tipo de manga de la camisa:
                1- Manga corta
                2- Manga Larga
                Respuesta: ");
                try
                {
                    entrada = char.Parse(Console.ReadLine());
                    switch (entrada)
                    {
                        case '1':
                            esMangaCorta = true;
                            exit = true;
                            break;
                        case '2':
                            esMangaCorta = false;
                            exit = true;
                            break;
                        default :
                            Console.WriteLine("La orden no existe, intente nuevamente");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Intente nuevamente");
                }
            } while (!exit);
        }

        private void MenuCuello()
        {
            char entrada = '0';
            var exit = false;
            do
            {
                Console.Write(@"
                Elija el tipo de cuello de la camisa:
                1- Cuello mao
                2- Cuello Convencional
                Respuesta: ");
                try
                {
                    entrada = char.Parse(Console.ReadLine());
                    switch (entrada)
                    {
                        case '1':
                            cuelloMao = true;
                            exit = true;
                            break;
                        case '2':
                            cuelloMao = false;
                            exit = true;
                            break;
                        default :
                            Console.WriteLine("La orden no existe, intente nuevamente");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Intente nuevamente");
                }
            } while (!exit);
            
        }
    }
}