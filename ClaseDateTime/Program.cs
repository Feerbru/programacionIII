using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClaseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos objeto de fecha
            DateTime fecha = new DateTime(2005, 5, 1, 12, 30, 00);

            //representa una fecha en formato 01/05/2005
            WriteLine(fecha.ToShortDateString());

            //retorna tiempo sin segundo
            WriteLine(fecha.ToShortTimeString());

            //retorna fecha en formato largo
            WriteLine(fecha.ToLongDateString());

            //retorna tiempo completo
            WriteLine(fecha.ToLongTimeString());

            //fin de la semana => daysOfWeek es un enum
            if (fecha.DayOfWeek != DayOfWeek.Saturday &&
                fecha.DayOfWeek != DayOfWeek.Sunday)
            { 
            }

            //Horario de verano o invierno
            if (fecha.IsDaylightSavingTime())
            {
                WriteLine("horario de verano");
            }

            //saber si es un año bisiesto => metodo static y pasarle un parametro
            if (DateTime.IsLeapYear(2005))
            {
                WriteLine("Es bisiesto");
            }

            //añadirle dias
            //fecha.AddDays(15);

            //añadirle hours
            //fecha.AddHours(72);

            //si queres que se modifique hay que guardarlo en un objeto nuevo

            DateTime fecha2 = fecha.AddDays(10);
            WriteLine(fecha2.Day);

            //se puede agregar intervalos
            DateTime fecha3 = new DateTime(2005, 5, 1, 12, 50, 00); //creamos otro objeto

            //cuanto tiempo a pasado entre fecha1 y fecha2
            //si restamos o sumamos 2 fechas no devuelve DateTime, sino que devuelve TimeSpan
            TimeSpan diferencia = fecha3 - fecha; //da una diferencia de tiempo, no de fecha

            WriteLine( diferencia.Hours); // cuantas horas de diferencias han pasado
            WriteLine(diferencia.Minutes); // cuantos minutos de diferencias

            //sacar la diferencia total de minutos o horas o segundos
            WriteLine(diferencia.TotalMinutes);

            //se le puede sumar\restar diferencias
            fecha = fecha + TimeSpan.FromMinutes(30);
            WriteLine(fecha.ToShortTimeString());

            //sacar cuantos dias han pasado desde que yo naci
            DateTime fecha4 = DateTime.Now; // creamos un obejto de la fecha actual

            TimeSpan diferencia1 = fecha4 - fecha;
            WriteLine(diferencia1.TotalDays);

            //poner una fecha en motodo personalizado

            WriteLine(fecha.ToString("dddd,dd \\de MMMM \\de yyyy"));

            ReadKey();
        }
    }
}
