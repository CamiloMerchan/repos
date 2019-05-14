using System;

namespace enumeraciones2
{
    class Program
    {
        enum Fidelidad
        {
            vip=30,
            platino=50,
            general=5
        }
        static void Main(string[] args)
        {



            Console.WriteLine($"Digite el valor de la compra");
            var valorcompra = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite el tipo de usuario ");
            var tipousu =Console.ReadLine();
           
            if (tipousu==Fidelidad.vip.ToString())
            {
                var operacion=valorcompra* (int)Fidelidad.vip/100;
                Console.WriteLine($"el valor de su compra es: {operacion}");
            }

            else if (tipousu == Fidelidad.platino.ToString())
            {
                var operacion2 = valorcompra * (int)Fidelidad.platino / 100;
                Console.WriteLine($"el valor de su compra es: {operacion2}");
            }

            else if (tipousu == Fidelidad.general.ToString())
            {
                var operacion3 = valorcompra * (int)Fidelidad.general / 100;
                Console.WriteLine($"el valor de su compra es: {operacion3}");

            }
        }

        public static int devolver(int valor)
        {
            
            return 0;
        }
    }
}
