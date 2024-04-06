using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace VectoresEjercicio6
{
    internal class VectoresEJ6
    {
        static void Main(string[] args)
        {
            //            Ingresar números en un vector, pueden ser positivos o negativos.Mostrar los
            //negativos de forma creciente y los positivos de forma decreciente.
            //Ejemplo:
            //            Vector ingresado: { 5, 1, -9, -1, 9, 3, -2, 2}
            //            Vector ordenado: { -9, -2, -1, 9, 5, 3, 2, 1}

            int[] numeros = new int [8];

            Console.WriteLine("ingrese 8 numeros para el array");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Vector ingresado: ");

            foreach (var i in numeros)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("");
            Array.Sort(numeros);
            Console.Write("Vector ordenado: ");

            foreach (var i in numeros)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
