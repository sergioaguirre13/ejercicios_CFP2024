using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LibreriaDeFunciones;

namespace FucionesEjercicio2
{
    internal class FuncionesEJ2
    {
        static void Main(string[] args)
        {

            //Crear una función que determine si el número recibido por parámetro es primo o no.
            
            int numero;

            Console.WriteLine("Ingrese un número, para verificar si es primo");
            numero = int.Parse(Console.ReadLine());

            if (MisMetodos.EsPrimo(numero)) 
            {
                Console.WriteLine($"{numero} es un número primo");
            }
            else
            {
                Console.WriteLine($"{numero} NO es un número primo");
            }
        }
            
       /* static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)  //use esta forma de iterar ya que covenia iterar hasta la raiz cuadrada del número.
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
                       
            return true;

        }*/
    }
}
