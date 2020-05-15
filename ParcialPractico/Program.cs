using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] periodo1 = obtenerPeriodos(3, 5, 9);
            int [] periodo2 = obtenerPeriodos(4, 6, 10);
            int [] periodo3 = obtenerPeriodos(7, 4, 20);

        }

        private static int[] obtenerPeriodos(params int [] periodo)
        {
            int[] per = periodo;

            return periodo;
        }

        private static int[] intersepcion( int [] per1, int [] per2)
        {
            int[] inter = new int[per1.Length];

            for (int i = 0; i < per1.Length; i++)
            {
                for (int j = 0; j < per2.Length; j++)
                {
                    if (per1[i] == per2[j])
                    {
                        inter[i] = per1[i];
                    }
                }
            }
            return inter;
        }
     }
}
