using System;
using System.Linq;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<double, double, double> raiz = CalcularRaiz;
            //Func<double, double, double> potencia = (x, y) => { return Math.Pow(x, y); };

            //Console.WriteLine($"la raiz es: { potencia(6, 3)}");
            //Console.WriteLine($"la raiz es: {raiz(6, 3)}");
            Proyecto pro = new Proyecto();
            //pro.AgregarProyecto();
            var proy = pro.AgregarProyecto2();
            var listar = pro.proyectos;

            //pro.Listar();

            Console.WriteLine("//**********duracion sea mayor a 6 y menores a 12***********//");
            var proyMayor = pro.proyectos.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            Console.WriteLine($"los proyectos cuya duracion sea mayor a 6 y menores a 12 son ");
            pro.Listar(proyMayor);

            Console.WriteLine("//**********Proyectos que empiecen por  b ***********//");

            var proyectosB = from p in pro.proyectos
                             where (p.Nombre.StartsWith("B"))
                             select p;
            pro.Listar(proyectosB.ToList());

            Console.WriteLine("//**********obtener todos los proyectos cuyo codigo sea multiplo de 7 ***********//");
            var proyPrimo = pro.proyectos.Where(x => x.Codigo % 7 == 0).ToList();
            pro.Listar(proyPrimo);


            Console.WriteLine("//**********obtener todos los proyectos que tengan una duracion inferior a 6 entre 6 y 10 y mayor a 10 ***********//");
            var proyDuracion = pro.proyectos.GroupBy(x =>
           {
               if (x.Duracion < 6)
                   return "son menores que 6";
               else if (x.Duracion >= 6 && x.Duracion < 10)
               {
                   return "Entre 6 y menores de 10";
               }
               else
               {
                   return "Son mayores a 10";
               }
           });
            foreach (var grupoProy in proyDuracion)
            {
                Console.WriteLine("Grupo de proyectos" + grupoProy.Key + "___Cantidad______" + proyDuracion.Count());
                foreach (var item in grupoProy)
                {
                    Console.WriteLine("El nombre del Proyecto:" + item.Nombre + "\r\n" + "El Codigo es :" + item.Nombre);
                }
            }
           

            Console.WriteLine("//**********obtener el promedio de la duracion de todos los proyectos***********//");
            var proyAVG = pro.proyectos.Average(x => x.Duracion);
            Console.WriteLine("El promedio de los proyectos es:" + proyAVG);
         
            Console.WriteLine("//**********obtener el nombre del proyecto con mas duracion ***********//");
            var dato = pro.proyectos.Max(y => y.Duracion);
            var proyMaxx = pro.proyectos.Where(x => x.Duracion == dato).Select(x => x.Nombre).FirstOrDefault();
            Console.WriteLine($"el proyecto con mas duracion es {proyMaxx} ");
            Console.WriteLine();
     
            //Console.WriteLine("//**********seleccionar el nombre y el area del proyecto con duracion mayor a 6 ***********//");
            //var area = pro.proyectos.Select(y => y.Area);
            //var proyArea = pro.proyectos.Where(x => x.Duracion>6).Select(x => x.Nombre).FirstOrDefault();
            //Console.WriteLine($"el proyecto con mas duracion es {proyArea} ");
            //Console.ReadLine();
        }
    }
          
}

        
        
        //    static double CalcularRaiz(double num1, double num2)
        //    {
        //        var operacion = Math.Pow(num1, num2);
        //        return operacion;
        //    }
        //}
    

//obtener todos los proyectos cuya duracion sea mayor a 6 y menores a 12
//obttener todos los proyectos que empiecen por b
//obtener todos los proyectos cuyo codigo sea multiplo de 7 
//agrupar los proyectos que dengan una duracion inferior a 6 entre 6 y 10 y mayor a 10
//obtener el promedio de la duracion de todos los proyectos
//obtener el nombre del proyecto con mas duracion
//seleccionar el nombre y el area del proyecto con duracion mayor a 6
//verificar si existe un proyecto con una duracion superior a 24
//Sumar las duraciones de los proyectos cuypo codigo sea superior a 20
//tomar los primeros proyectos cuyo codigo sea superior a 30