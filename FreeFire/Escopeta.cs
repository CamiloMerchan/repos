using System;
using System.Collections.Generic;
using System.Text;

namespace FreeFire
{
    class Escopeta:ISoldado
    {
        public void Disparar(string nombre) {
            Console.WriteLine($"Es hora de disparar la Escopeta y yo soy el soldado {nombre}");
        }

        public void Disparar()
        {
            Console.WriteLine($"pueba");
        }
    }
}
