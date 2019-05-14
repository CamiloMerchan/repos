using System;

namespace enumeraciones
{
    class Program
    {

        enum Dias
        {
            lunes,
            martes,
            miercoles,
            jueves,
            viernes,
            sabado,
            domingo
        }

        enum Meses
        {
            enero=1,
            febrero=2,
            marzo=3,
            abril,
            julio=50
        }
        static void Main(string[] args)
        {
            var diafav = Dias.lunes;
            Console.WriteLine($"mi dia favorito es el {diafav}");
            Console.ReadLine();
            Console.WriteLine($"mi dia favorito es el {(Dias)6}");
            Console.ReadLine();
            Console.WriteLine($"mi mes favorito es el {(int)Meses.abril}");
            Console.ReadLine();
            Console.WriteLine($"mi mes favorito es el {(int)Meses.julio}");
            Console.ReadLine();
        }
    }
}
