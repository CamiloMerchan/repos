using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    class Auto:Vehiculo
    {
        public String Airbag { get; set; }

        public Auto(string nombre)
        {
            Nombre = nombre;
        }

        public override void Mivehiculodice()
        {
            Console.WriteLine($"este auto es genial");
            base.Mivehiculodice();
        }
    }
}
