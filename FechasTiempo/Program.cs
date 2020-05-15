using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechasTiempo
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha = new DateTime(2019, 09, 01);
            DateTime fecha1 = new DateTime(2020, 01, 20);

            String diasCal = ObtenerDiasCalendario(fecha, fecha1);

            int diasLab = ObtenerDiasLaborales(fecha, fecha1);

            Console.WriteLine("los dias laborales son: " + diasLab);

            Console.WriteLine(diasCal);
            Console.ReadKey();
        }

        private static string ObtenerDiasCalendario(DateTime dato, DateTime dato1)
        {
            StringBuilder diasC = new StringBuilder();

            while (dato <= dato1)
            {
                diasC.Append(dato.ToString("dd-MM-yy") + ", ");

                dato = dato.AddDays(1);
            }

            return diasC.ToString();
        }
        private static bool FindeSemana(DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            return false;
        }

        private static int ObtenerDiasLaborales(DateTime inicio, DateTime final)
        {
            int diasLaborables = 0;

            while (inicio <= final)
            {
                if (!FindeSemana(inicio) /*&& !feriados(inicio)*/)
                {
                    diasLaborables++;
                }
                
                /*if (feriados(inicio))
                {
                    diasLaborables--;
                }*/

                inicio = inicio.AddDays(1);
            }
            return diasLaborables;
        }

        private static bool feriados(DateTime dia)
        {
            int [] feriados = new int[] {1, 25, 45, 156, 266};

            for (int i = 0; i < feriados.Length; i++)
            {
                if (dia.DayOfYear == feriados[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}