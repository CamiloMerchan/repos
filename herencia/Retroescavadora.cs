using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    class Retroescavadora:Vehiculo
    {
        public int Numpalas { get; set; }

        public Retroescavadora(String nombre)
        {
           Nombre = nombre;

    }

        public override void Mivehiculodice()
        {
            base.Mivehiculodice();
        }
    }
}
