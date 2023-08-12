using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaración de variables
            string nombre;
            int edad;
            string dirección;
            int telefono;
            string Univercidad;
            string carrera;
            string facultad;
            int ciclo;

            Console.WriteLine("\n******************Practica 1 - Programación Estructurada******************\n")
            Console.WriteLine("Ingresa tu nombre completo:")//Obtener Datos
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n")

            Console.WriteLine("Ingresa tu edad:")//Obtener Datos
            edad = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("\n")

            Console.WriteLine("Ingresa tu dirección:")//Obtener Datos
            dirección = Convert.ToString(Console.ReadLine());
             Console.WriteLine("\n")

            Console.WriteLine("Ingresa tu telefo:")//Obtener Datos
            telefono = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("\n")

            Console.WriteLine("Ingresa a la Universidad que vas:")//Obtener Datos
            Universidad = Convert.ToString(Console.ReadLine());
             Console.WriteLine("\n")

            Console.WriteLine("Ingresa tu carrera:")//Obtener Datos
            carrera = Convert.ToString(Console.ReadLine());
             Console.WriteLine("\n")

            Console.WriteLine("Ingresa tu facultad:")//Obtener Datos
            facultad = Convert.ToString(Console.ReadLine());
             Console.WriteLine("\n")

            Console.WriteLine("Ingresa tu ciclo:") //Obtener Datos
            ciclo = Convert.ToInto32(Console.ReadLine());
            Console.WriteLine("\n")

            Console.WriteLine("Su nombre es: "+ nombre)
            Console.WriteLine("Su edad es: "+ edad)
            Console.WriteLine("Su ndirección es: "+ dirección)
            Console.WriteLine("Su telefono es: "+ telefono)
            Console.WriteLine("Universidad que estudia: "+ Universidad)
            Console.WriteLine("Su carrera es: "+ carrera)
            Console.WriteLine("Su facultad es: "+ facultad)
            Console.WriteLine("Su ciclo es: "+ nombre)


        }
    }
}