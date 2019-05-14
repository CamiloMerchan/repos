using System;
using System.Collections.Generic;
using System.Text;

namespace Fechas2
{
    class Class2
    {
        static void Main(string[] args)
        {

            int dia=0;
            int mes=0;
            int anio=0;

            Console.WriteLine("Ingrese el dia");
            Console.ReadLine();

            Console.WriteLine("Ingrese el Mes");
            Console.ReadLine(); 

            Console.WriteLine("Ingrese el Año");
            Console.ReadLine(); 

            if ( mes >= 1 && mes <= 12)
            {
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia >= 1 && dia <= 31)

                            Console.WriteLine(" FECHA CORRECTA");
                            
                        else 

                            Console.WriteLine(" FECHA INCORRECTA");
                            Console.ReadLine();
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia >= 1 && dia <= 30)

                            Console.WriteLine("\n   FECHA CORRECTA");
                       
                        else

                            Console.WriteLine("\n   FECHA INCORRECTA");
                            Console.ReadLine();
                        break;

                    case 2:
                           if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
                            if (dia >= 1 && dia <= 29)

                                Console.WriteLine("\n   FECHA CORRECTA");
                            
                            else

                                Console.WriteLine("\n   FECHA INCORRECTA");
                              
                        else
                            if (dia >= 1 && dia <= 28)

                            Console.WriteLine("\n   FECHA CORRECTA");
                        
                        else

                            Console.WriteLine("\n   FECHA INCORRECTA");
                            Console.ReadLine();
                        break;
                }
            }
            else

                            Console.WriteLine( "FECHA INCORRECTA");
                            Console.ReadLine();

        }
    }
    
}
  