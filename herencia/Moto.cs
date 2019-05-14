using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    class Moto:Vehiculo
    {
        public int Cascos { get; set; }
        public int Chalecos { get; set; }

        public Moto(String nombre)
        {
            Nombre = nombre;
        }

        public override void Mivehiculodice()
        {
            Console.WriteLine($"Es mejor tener una moto");
        }
    }

    
}
