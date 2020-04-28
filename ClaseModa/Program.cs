using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaseModa
{
    class Program
    {
        /*
             * Pasaje de parametros - Ejercicio
             * Implementar una funcion Moda, que reciba
             * como valores una cantidad indeterminada de enteros
             * y devuelva la Moda (estadistica), el valor minimo y el valor maximo
             * Invocar este metodo y mostrar los resultados por consola.
             * Elija los modificadores mas adecuados (in, out, ref, params)
             * 
             */
        static void Main(string[] args)
        {
            moda(1, 5, 3, 4, 3,3,2,4,0,45);

            Console.ReadKey();
        }

        static void moda(params int [] val)
        {
            int numero = 0;
            int posicion = 0;
            int[] aux = new int[val.Length];

            for (int i = 0; i < val.Length; i++)
            {
                numero = val[i];
                posicion = i;

                for(int j = i; j < val.Length;j++)
                {
                    if(val[j] == numero)
                    {
                        aux[posicion]++;
                    }
                }
            }

            int mayor = aux[0];
            int posicionmayor = 0;
            for (int i = 0; i < val.Length; i++)
            {
                if (aux[i] > mayor)
                {
                    posicionmayor = i;
                    mayor = aux[i];
                }
            }
            Console.WriteLine("La moda es: "+ val[posicionmayor]);
            Console.WriteLine("El numero menor es: " + Enumerable.Min<int>(val));
            Console.WriteLine("El numero mayor es: " + Enumerable.Max<int>(val));

        }


    }
}
