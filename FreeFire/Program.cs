using System;

namespace FreeFire
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soldier sol = new Soldier();
            //sol.DispararEscopeta();
            //sol.DispararMetralleta();
            //sol.DispararRifle();
            //Console.ReadLine();

            Soldier sol = new Soldier(new Escopeta());
            sol.Disparar();
            Console.ReadLine();

            Soldier sol1 = new Soldier(new Rifle());
            sol1.Disparar();
            Console.ReadLine();

        }
    }
}
