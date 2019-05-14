using System;
using System.Collections.Generic;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1 = new Auto("Deportivo");
            var moto1 = new Moto("Ninja");
            var retro1 = new Retroescavadora("Suprema");
            auto1.Marca = "Chevrolet";
            auto1.Modelo = "Camaro";
            auto1.Mivehiculodice();
            moto1.Mivehiculodice();
            retro1.Mivehiculodice();
            Console.ReadKey();
           

            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            Vehiculos.Add(auto1);
            Vehiculos.Add(moto1);
            Vehiculos.Add(retro1);
            Program pro = new Program();
            Mostrarvehiculo(new Retroescavadora("cat"));
            Mostrarvehiculo(new Moto("kawasaki"));
            Listar(Vehiculos);
            Console.ReadLine();

           
        }
        public static void Listar(List<Vehiculo> vehiculos)
        {
            foreach (var item in vehiculos)
            {
                Console.WriteLine($"Nombre: {item.Nombre} y su modelo es {item.Modelo}");
                
            }
        }
        public static void Mostrarvehiculo(Vehiculo miVehiculo)
        {
            miVehiculo.Mivehiculodice();
            Console.ReadLine();
        }


    }


    
}
