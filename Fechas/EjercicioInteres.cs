using System;
using System.Collections.Generic;
using System.Text;

namespace Fechas3
{
    class Class1
    {
        static void Main(string[] args)
        {
            var prestamo = 17000000 / 12;
            var interes = 0.02;
            var interesAcum = prestamo * interes;
            var total = prestamo + interesAcum;


            Console.WriteLine("Introduce la fecha de consignacion");
            var fecha = Convert.ToDateTime(Console.ReadLine());
            



        }

}
}
