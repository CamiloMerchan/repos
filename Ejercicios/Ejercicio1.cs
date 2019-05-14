using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=0;
            int B=0;
            int aux;
            int suma;

            Console.Write("Introduce un número: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            B = Convert.ToInt32(Console.ReadLine());

            if ((A > -1) && (B > -1))
            {
                Console.Write("los dos numeros son  positivos");
                Console.ReadLine();
            }
            else if (A > -1)
            {
                Console.Write("el primer numero es positivo");
                Console.ReadLine();
            }
            else if (B > -1)
            {
                Console.Write("el segundo numero es positivo");
                Console.ReadLine();
            }
            else if ((A < -1) && (B < -1))
            {
                Console.Write("ninguno de los dos numeros son positivos");
                Console.ReadLine();
            }


            if (A < B) {
                aux = B;               // antes de cambiarle el valor a B lo guardo antes de perderlo
                B = A;                 // le asigno el valor de A 
                A = aux;                // le asigno el valor que tenia B 
            }
            suma = 0;

            for (int i=A; A <= B;i++){
                if (i%5== 0)
                {
                    suma = suma + A;                 // empiezo a sumar los multiplos
                 }
            }

            Console.Write($"La suma de los multiplos de 5 entre A y B es :{suma} ");
            Console.ReadLine();
        }
    }
}
