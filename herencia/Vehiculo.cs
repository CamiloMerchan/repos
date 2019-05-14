using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    class Vehiculo
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Nombre { get; set; }
        public int Ruedas { get; set; }

        public virtual void Mivehiculodice()
        {
            Console.WriteLine($"Mi vehiculo es: {Nombre}");
        }
    }
}
