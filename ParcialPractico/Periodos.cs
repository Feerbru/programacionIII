using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPractico
{
    public class Periodos
    {


        public int inicio { get; set; }
        public int duracion { get; set; }
        public int final { get; set; }

        public Periodos(int inicio, int duracion, int final )
        {
            this.inicio = inicio;
            this.duracion = duracion;
            this.final = final;
        }
    }
}
