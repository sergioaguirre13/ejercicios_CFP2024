using System;

namespace Ejercicio_1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {

            // 1. Ingresar el nombre y apellido por consola.

            string nombre;
            string apellido;

            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su nombre: ");
            apellido = Console.ReadLine();

            Console.WriteLine($"Su nombre es {nombre} y su apellido es {apellido}");
        }
    }
}
