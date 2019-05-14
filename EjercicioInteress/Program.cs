using System;

namespace EjercicioInteress
{
    class Program
    {
         static void Main(string[] args)
        {
            //Defino las variables necesarias para desarrollar el ejercicio

            var prestamo = 17000000;
            var interes = 0.02;
            var interesAcum = prestamo * interes;
            //var total = prestamo + interesAcum;
            var ValorFuturo = Math.Pow(interes + 1, 12);
            var total = prestamo * interes * ValorFuturo;
            var dd = 0;
            var MM = 0;
            var yyyy = 0;
            

            Console.Write("Ingrese dia: ");
            dd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese mes: ");
            MM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese año: ");
            yyyy = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"La fecha Ingresada es:{dd/MM/yyyy}");
            
            //Console.WriteLine("Introduce la fecha de consignacion");
            //var fecha = Convert.ToDateTime(Console.ReadLine());


            //Realizo la condicion para que el numero de meses se cumplan y no exceda a 12
            if (MM >= 1 && MM <= 12)
            {      
                switch (MM)  //Utilizo el switch para saber los dias que hay en cada mes 
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        //hago las condiciones para saber si ah pagado a tiempo o si sobrepaso la fecha acordada
                        if (dd >= 1 && dd <= 5)

                            Console.WriteLine($"El valor que debe consignar es:{interesAcum}");
                           
                        else if (dd > 5 && dd <= 31)
                        {

                            Console.WriteLine($"El valor que debe consignar es:{total} ya que se paso de la fecha acordada");
                            Console.ReadLine();
                          
                        }
                        break;
                        //Eligo los mese en donde ella pago a tiempo
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dd >= 1 && dd <= 30)

                            Console.WriteLine("La fecha es Correcta");

                        else if (dd >= 1 && dd <= 5)
                        {

                            Console.WriteLine($"El valor que debe consignar es:{total}");
                            Console.ReadLine();

                        }
                        break;

                    case 2:
                        //Realizo la condicion para saber si el año ingresado es valido, 
                        //deje de ultimo este mes ya que es el que menos dias tiene

                        if (yyyy % 4 == 0 && yyyy % 100 != 0 || yyyy % 400 == 0)
                            if (dd >= 1 && dd <= 29)

                                Console.WriteLine($"El valor que debe consignar es:{interesAcum}");

                        else if (dd > 5 && dd <= 28)
                        {

                            Console.WriteLine($"El valor que debe consignar es:{total} ya que se paso de la fecha acordada");
                            Console.ReadLine();

                        }
                        break;
                }
            }        //Por ultimo imprimo el valor total a pagar durante los 12 meses
                     else
                           Console.WriteLine($"El valor total a pagar durante los 12 meses es:{total} ");
                           Console.ReadLine();

        }
    }
}
