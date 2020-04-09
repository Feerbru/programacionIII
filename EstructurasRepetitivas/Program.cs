﻿using System;
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
            arrayPersonas = new int [10];

            Console.WriteLine("Ingrese la altura de cada persona:");

            for(int i = 0; i < arrayPersonas.Length; i++)
            {
                Console.WriteLine("Ingrese la altura de la {0} persona: ", (i + 1));
                arrayPersonas[i] = int.Parse(Console.ReadLine());
            }

            foreach(int per in arrayPersonas)
            {
                Console.WriteLine("altura de {0}cm de la persona", per);
            }
            Console.ReadKey();
        }
    }
}
