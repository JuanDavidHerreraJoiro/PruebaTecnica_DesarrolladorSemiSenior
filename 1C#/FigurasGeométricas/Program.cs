// See https://aka.ms/new-console-template for more information
using Entidad;

namespace FigurasGeométricas 
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool segir = false;

            do
            {
                Titulo("FIGURAS GEOMETRICAS");

                Console.WriteLine("Alcular área de: ");
                Console.WriteLine("1. Circulo. ");
                Console.WriteLine("2. Triángulo. ");
                Console.WriteLine("3. Retángulo.  ");

                Console.WriteLine("");
                int opcion = (int) Validacion();

                Console.Clear();

                var area = 0.0;

                if (opcion == 1)
                {
                    Titulo("CIRCULO");
                    Console.WriteLine("Digite el radio. ");
                    double radio = Validacion();
                    var circulo = new Circulo();

                    circulo.Radio = radio;

                    area = circulo.CalcularArea();

                }
                else if (opcion == 2 || opcion == 3)
                {
                    if (opcion == 2)
                    {
                        Titulo("TRIANGULO");
                    }
                    else
                    {
                        Titulo("RECTANGULO");
                    }

                    Console.WriteLine("Digite la base. ");
                    double basee = Validacion();

                    Console.WriteLine("");
                    Console.WriteLine("Digite la altura. ");
                    double altura = Validacion();

                    Figura figura;

                    if (opcion == 2) figura = new Triangulo();
                    else figura = new Rectangulo();

                    figura.Altura = altura;
                    figura.Base = basee;
                    area = figura.CalcularArea();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Opción no válida. ");
                }

                Console.WriteLine("");
                Console.WriteLine("El área es: " + area);
                Console.WriteLine("-------------------------------------------------------");

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey(); // Espera a que el usuario presione una tecla
                Console.Clear();

            } while (!segir);
        }

        private static double Validacion()
        {
            bool error = false;
            double numero = 0;
            do
            {
                try
                {
                    numero = int.Parse(Console.ReadLine()!);
                    error = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("! Error no se permiten letras o caracteres especiales ¡");
                    Console.WriteLine("! Digite otro valor ¡");
                }

            } while (!error);
            return numero;
        }

        private static void Titulo(string tipoFigura)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("----------------------- "+tipoFigura+" -----------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");
        }
    }
}