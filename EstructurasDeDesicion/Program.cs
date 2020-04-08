using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDesicion
{
    /*
     * instrucciones

        Objetivo: Comprender la aplicación de las estructuras de decisión en C#.
        Ejercicio:
        Cree de una aplicación de consola.
        Solicite el ingreso de un texto y controle que no esté vacío.
        Despliegue un menú que muestre 3 posibilidades (Texto en mayúscula, Texto en minúscula y Texto Original).
        Capture la entrada con Console.Readkey y realice la opción solicitada.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string texto;


            Console.WriteLine("Ingrese un texto:");
            texto = Console.ReadLine();

            if (!texto.Equals(""))
            {
                Console.WriteLine("Que desea realizar:");
                Console.WriteLine("A- Pasar el texto a Mayúscula.");
                Console.WriteLine("B- Pasar el texto a Minúscula.");
                Console.WriteLine("C- Dejar el texto Original.");

                ConsoleKeyInfo input = ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("{0}", texto.ToUpper());
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("{0}", texto.ToLower());
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("{0}", texto);
                        break;
                    default:
                        Console.WriteLine("Tecla erronea");
                        break;
                }
            }
            else
                Console.WriteLine("El texto esta vacio");

            Console.ReadKey();

        }

        private static ConsoleKeyInfo ReadKey()
        {
            throw new NotImplementedException();
        }
    }
}
  
