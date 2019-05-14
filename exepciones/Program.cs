using System;

namespace exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine($"digite el primer numero");
                var num1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"digite el segundo numero");
                var num2 = int.Parse(Console.ReadLine());
                var operacion = num1 / num2;
                Console.WriteLine($"el resultado es:  {operacion}");
                var operacion2 = Math.Sqrt(-4);
                Console.WriteLine($"el resultado de la raiz es:  {operacion2}");
                if (double.IsNaN(operacion2))
                {
                    var NullExeption = new NullReferenceException("no existen raices negativas");
                    throw NullExeption;
                }


            }

            catch (NullReferenceException error)
            {
                Console.WriteLine($"ha ocurrido un error {error.Message}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR {e.Message}");
               
            }

            finally
            {
                Console.WriteLine($"siempre se va a ejecutar por defecto");
            }

           

            Console.ReadLine();
        }
    }
}
