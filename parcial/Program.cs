using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            ordenDescendente(-1, 0, -2, 3, 5);
        }
      
        public static void ordenDescendente(params int[] values)
        {
            int cont = 0;
            int[] valores = new int[values.Length];

            Array.Sort(values);

            for (int i = values.Length - 1; i >= 0; i--)
            {
                if (values[i] > 0)
                {
                    valores[cont] = values[i];
                    cont++;
                }

            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 0)
                {
                    valores[cont] = values[i];
                    cont++;
                }

            }

            foreach (var VARIABLE in valores)
            {
                Console.Write(VARIABLE + ",");
            }
            Console.ReadKey();

        }
    }
}
