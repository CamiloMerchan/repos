using System;
using System.Collections.Generic;

namespace Definicion_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Persona per = new Persona();
            //Persona per2 = new Persona();
            //Persona per3 = new Persona();
            List <Persona> personas = new List<Persona>();
            //per.Nombre = "camilo";
            //per.Edad = 18;
            //Console.WriteLine($"Nombre: {per.Nombre} Edad:{ per.Edad}");
            //Console.WriteLine("Ingrese su nombre");
            //per2.Nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese su edad");
            //per2.Edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Nombre: {per2.Nombre} Edad:{ per2.Edad}");
            //per3.IngresarPersona();
            //personas.Add(per);
            //personas.Add(per2);
            //personas.Add(per3);

            //foreach ( var item in personas)
            //{
            //    Console.Write($"Nombre: {item.Nombre} Edad:{item.Edad}");
           
            //}
            Console.WriteLine("Desea ingresar personas si/no");
            var res = Console.ReadLine();
            while (res=="si")
            {
                Persona per4 = new Persona();
                per4.IngresarPersona();
                personas.Add(per4); 
                Console.WriteLine("Dese ingresar persona si/no");
                res = Console.ReadLine();

            }
            Persona per = new Persona();
            per.ListarPersona(personas);
            Console.ReadKey();

        }
    }
}
