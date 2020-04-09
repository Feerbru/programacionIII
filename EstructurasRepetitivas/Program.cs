using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasRepetitivas
{
    /*
     * Objetivo: Comprender el uso básico de estructuras repetitivas.
       Ejercicio:
       Calcular la media y la desviación estándar de un conjunto de 10 personas.
       Tome por teclado la altura en cm de cada persona y cárguela en un arreglo.
       Presente los resultados obtenidos.
       Muestre que alturas se encuentran por encima de la media y por debajo de ella.
       Muestre que alturas se encuentran dentro del rango definido por la desviación estándar.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int [] arrayPersonas;
            arrayPersonas = new int [5];

            //Cargamos el arreglo
            for(int i = 0; i < arrayPersonas.Length; i++)
            {
                Console.WriteLine("Ingrese la altura de la {0} persona: ", (i + 1));
                arrayPersonas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("{0}", Environment.NewLine);

            //imprimimos por consola el arreglo
            for (int i = 0; i < arrayPersonas.Length; ++i)
                Console.WriteLine("La {0} persona mide {1} cm", (i + 1), arrayPersonas[i]);

            Console.WriteLine("{0}", Environment.NewLine);

            //Calcular media
            int datosM = 0;

            for (int i = 0; i < arrayPersonas.Length; ++i)
                datosM += arrayPersonas[i];

            var media = datosM / arrayPersonas.Length;

            Console.WriteLine("La altura media es: {0} cm{1}", media, Environment.NewLine);

            for(int i = 0; i < arrayPersonas.Length; ++ i)
                if (media < arrayPersonas[i])
                    Console.WriteLine("La {0} persona esta por encima de la altura media", (i+1));
                else
                    Console.WriteLine("La {0} persona esta por debajo de la altura media", (i+ 1));

            Console.WriteLine("{0}", Environment.NewLine);

            //Calcular Varianza

            double datosV = 0;

            for (int i = 0; i < arrayPersonas.Length; ++i)
                //Conversion explicita a double para emplear el metodo Pow
                datosV += Math.Pow(Convert.ToDouble(arrayPersonas[i]) - Convert.ToDouble(media), 2);

            var totalV = datosV / (arrayPersonas.Length - 1);

            Console.WriteLine("Desviacion estandar {0}{1}", Math.Sqrt(totalV), Environment.NewLine);


            Console.ReadKey();
        }
    }
}
