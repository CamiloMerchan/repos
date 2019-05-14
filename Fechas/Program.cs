using System;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha);

           
            Console.WriteLine($"La fecha es:{fecha}");
            var fecha2 = new DateTime(2015,12,31,0,30,30);
            Console.WriteLine($"La fecha es:{fecha2}");
            Console.WriteLine($"el valor de la fechahora es:{fecha2.ToString()}");

            Console.WriteLine($"el valor de la fechahora es:{fecha2.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"el valor de la fechahora es:{fecha2.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"el valor de la fechahora es:{fecha2.ToString("MM/dd/yyyy")}");

        }
    }
}
