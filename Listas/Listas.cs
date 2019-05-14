using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int num;
            //Defino las variables en las que se almacenara cada dato
            string nombre, apellido, cargo;

            //Definimos la lista de tipo String y que lleve un array, ademas la instanciamos
            List<String[]> persona = new List<String[]>();
            try
            {
                

                 while (opcion != 5)
                 {
                        Console.WriteLine("1. Registrar personas");
                        Console.WriteLine("2. ver lista de personas");
                        Console.WriteLine("3. Editar datos");
                        Console.WriteLine("4. Eliminar personas");
                        Console.WriteLine("5. Salir");
                        Console.WriteLine("_________________________");
                        Console.WriteLine("Ingrese una opcion");

                        string opcionCambiar = Console.ReadLine();

                        if (int.TryParse(opcionCambiar, out num))
                        {
                            opcion = int.Parse(opcionCambiar);

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine(" Ingrese Nombres");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellidos");
                                    apellido = Console.ReadLine();
                                    Console.WriteLine("Rol al que pertenece");
                                    cargo = Console.ReadLine();
                                    //En este caso uso unas funciones de c# como lo son:Trim() que borra los espacion que son igresados
                                    // y la funcion Empty que no permite que se deje vacios al momento de ingresar datos
                                    if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || cargo.Trim() == string.Empty)
                                    //if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(cargo))
                                    {
                                        Console.WriteLine("Todos los campos son obligatorios");
                                    }
                                    else
                                    {   //Se realiza un Array tipo String para obtener la informacion 
                                        //de los datos ingresados y luego alamcenarlos en la lista 
                                        string[] datoPersona = new string[3];
                                        datoPersona[0] = nombre;
                                        datoPersona[1] = apellido;
                                        datoPersona[2] = cargo;
                                    //En este caso con la opcion Add guardo los datos en la lista
                                        persona.Add(datoPersona);

                                    }
                                    break;

                                case 2:
                                    //En este caso para recorrer la lista utilizo un foreach
                                    //el cual va a recorrer el array tipo string en personas 
                                    foreach (string[] item in persona)
                                    {
                                        Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("_____ La lista de personas son:________");
                                    //ahora para poder editar cualquiera de las personas utilizo un for en para recorrer la lista y
                                    //el numero de personas que tiene por eso se utiliza el persona.countn que contiene los datos guardados hasta ahora
                                    for (int i = 0; i < persona.Count; i++)
                                    {   //despues imprimo en pantalla cada persona señalando con  persona[i] la primera posicion de la lista y 
                                        //con el subindice [0] accedo a la primera posicion del Array de tipo string
                                        Console.WriteLine(i + ". " + persona[i][0] + " " + persona[i][1] + " " + persona[i][2]);
                                    }
                                    Console.WriteLine("_______________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Ingrese el numero correspondiente segun  la persona que quiere modificar");

                                    string posicionCambiar = Console.ReadLine();
                                    //En este caso se utiliza la funcion out para guardar un variable temporal en num que ya esta definida como un int
                                    //para comprobar si se cumple el tipo de conversion es correcta o no
                                    if (int.TryParse(posicionCambiar, out num))
                                    {
                                        //para poder editar hacemos una condicion en este caso para saber so la posicion que queremos editar existe en el Array
                                        int datoPersona = int.Parse(posicionCambiar);
                                        if (persona.Count <= datoPersona || datoPersona < 0)
                                        {
                                            Console.WriteLine("El dato a modificar no existe");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" Ingrese los nuevos  Nombres ");
                                            nombre = Console.ReadLine();
                                            Console.WriteLine("Ingrese los los nuevos Apellidos");
                                            apellido = Console.ReadLine();
                                            Console.WriteLine("Ingrese el nuevo Rol");
                                            cargo = Console.ReadLine();

                                            if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || cargo.Trim() == string.Empty)
                                            {
                                                Console.WriteLine("Todos los campos son obligatorios");
                                            }
                                            else
                                            {
                                                persona[datoPersona][0] = nombre;
                                                persona[datoPersona][1] = apellido;
                                                persona[datoPersona][2] = cargo;

                                                Console.WriteLine(" La informacion fue ctualizada Correctamente");

                                            }
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("_____ La lista de personas son:________");

                                    for (int i = 0; i < persona.Count; i++)
                                    {
                                        Console.WriteLine(i + ". " + persona[i][0] + " " + persona[i][1] + " " + persona[i][2]);
                                    }
                                    Console.WriteLine("_______________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Ingrese el numero correspondiente segun  la persona que quiere Eliminar");

                                    string posicionCambiarDelete = Console.ReadLine();

                                    if (int.TryParse(posicionCambiarDelete, out num))
                                    {
                                        int datoPersona = int.Parse(posicionCambiarDelete);
                                        if (persona.Count <= datoPersona || datoPersona < 0)
                                        {
                                            Console.WriteLine("El dato a Eliminar no existe");
                                        }
                                        else
                                        {
                                            persona.RemoveAt(datoPersona);
                                            Console.WriteLine(" La Persona fue eliminada  Correctamente");

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El dato a modificar no existe");
                                    }

                                    break;
                                case 5:

                                    break;

                                default:
                                    Console.WriteLine("La opcion Ingresada no se encuentra en el menu");

                                    break;
                            }
                        }
                        else
                        {
                            opcion = 0;
                        Console.WriteLine("El valor ingresado no es correcto");
                        }
                        if (opcion != 5)
                        {
                            Console.ReadLine();
                        }
                        Console.Clear();
                 }
                
            } catch (Exception error)
            {
                Console.WriteLine("Ha ocurrido un error" + error.Message);
            }
        }
    }
}
