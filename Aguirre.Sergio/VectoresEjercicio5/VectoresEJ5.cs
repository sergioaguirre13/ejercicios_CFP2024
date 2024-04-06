using System.Numerics;

namespace VectoresEjercicio5
{
    internal class VectoresEJ5
    {
        static void Main(string[] args)
        {

            //Ingresar datos en un vector y mostrarlos al revés.

            string palabra;
            
            Console.WriteLine("Ingrese la palabra que quiere pasar a array");
            palabra = Console.ReadLine();

            Char[] palabraArray = palabra.ToCharArray();

            for (int i = palabraArray.Length - 1; i >= 0; i--)
            {
                Console.Write(palabraArray[i]);
            }

        }
    }
}
