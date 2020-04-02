using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIII
{
    /*/
     * Objetivo: Comprender el uso de variables, asignaciones y operaciones de forma simple en C#.
       Creación de una aplicación de consola
       Solicite el ingreso de dos valores por pantalla
       Al final muestre en forma descriptiva los resultados de aplicar las cuatro operaciones básicas
       Entregar código en pdf o cs
     */
    class Program
    {
        static void Main(string[] args)
        {
            var nro1 = 0;
            var nro2 = 0;
            var caso = 0;

            Console.WriteLine("Ingrese el operacion que desea realizar: ");
            Console.WriteLine("1- SUMA. ");
            Console.WriteLine("2- RESTA.");
            Console.WriteLine("3- DIVISION.");
            Console.WriteLine("4- MULTIPLICACION.");
            caso = int.Parse(Console.ReadLine());

            switch (caso)
            {
                case 1:

                    Console.WriteLine("Ingrese el primer nro sumando:");
                    nro1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo nro sumando:");
                    nro2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El total de la suma es : {nro1 + nro2}");
                    break;

                case 2:

                    Console.WriteLine("Ingrese el minuendo:");
                    nro1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sustraendo:");
                    nro2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El total de la resta es : {nro1 - nro2}");
                    break;

                case 3:

                    Console.WriteLine("Ingrese el dividendo:");
                    nro1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el divisor:");
                    nro2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"El resultado de la division es: {nro1 / nro2}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer factor:");
                    nro1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo factor:");
                    nro2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"El producto es: {nro1 * nro2}");
                    break;
                default:
                    Console.WriteLine("El numero ingresado no es correcto.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
