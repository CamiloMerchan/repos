using System;
using System.Collections.Generic;
using System.Text;

namespace Definicion_clase
{
    class Persona
    {
        //define dos propiedades
        #region propiedades
        public int Edad { get; set; }
        public String Nombre{get; set;}
            #endregion
        public void IngresarPersona()
        {
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            Edad = Convert.ToInt32(Console.ReadLine());
           
        }
        public void ListarPersona(List<Persona> users)
        {
            foreach (var item in users)
            {
                Console.Write($"Nombre: {item.Nombre} Edad:{item.Edad}");

            }
            try
            {
                do
                {

                }


            }
    }
    }
    
        
}
