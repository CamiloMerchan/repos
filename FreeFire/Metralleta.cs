using System;
using System.Collections.Generic;
using System.Text;

namespace FreeFire
{
    class Metralleta:ISoldado
    {
        public void Disparar(string nombre) {
            Console.WriteLine($"Es hora de disparar la Metralleta y yo soy el soldado {nombre}");
        }

        public void Disparar()
        {
            Console.WriteLine($"pueba3");
        }
    }
}
