using System;
using System.Collections.Generic;
using System.Text;

namespace FreeFire
{
    class Rifle:ISoldado
    {
        public void Disparar(string nombre) {
            Console.WriteLine($"Es hora de disparar el Rifle y yo soy el soldado {nombre}");
        }

        public void Disparar()
        {
            Console.WriteLine($"pueba2");
        }
    }
}
