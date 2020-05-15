using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosConApuestas
{
    class Program
    {
        /*
             *   Instrucciones
                Objetivo: implementar varias clases y sus asociaciones. Usar propiedades, enumeraciones o constantes donde se necesite
                Modifique el juego anterior 
                -Dos jugadores, Dos dados y Apuestas
                -Tres modos de apuesta {conservador -1/2, arriesgado -2/5, desesperado -4/15}
                -Cada jugador cuenta con $100 iniciales y un pozo de $10000.
                -El juego termina cuando el pozo o el saldo de algún jugador llega a cero.
                 -Hasta 5 clases

                 Ejemplo:
                Pozo empieza con 10000, el jugador 1 $100 y el jugador 2 $100
                Jugador 1 apuesta $10 (conservador) al nro 6
                Jugador 2 apuesta $20 (arriesgado) al nro 10
                Se corrobora que haya suficiente dinero en el pozo para pagar en el caso que gane la apuesta más elevada y que cada jugador pueda pagar lo apostado si pierde
    ‌
                Una posibilidad
                Se arrojan los dados y se obtiene 11
                Ambos pierden el jugador 1 se queda con $90, el jugador 2 se queda con $60
                El pozo acumula 10050
                ‌
                Otra posibilidad
                Se arrojan los dados y se obtiene 10
                El jugador 1 pierde, se queda con $90, el jugador 2 gana, se queda con $200 (100 + 5*20)
                El pozo acumula 10000 + 10 -100 = 9910
         */
        static void Main(string[] args)
        {
        }
    }
}
