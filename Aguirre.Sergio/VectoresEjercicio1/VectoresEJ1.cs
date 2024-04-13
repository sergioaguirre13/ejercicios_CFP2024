using System.Numerics;

namespace VectoresEjercicio1
{
    internal class VectoresEJ1
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos y mostrarlo.


            Console.WriteLine("Ingrese 5 numeros para el array");

            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i + 1}° numero: ");
                numeros[i] = int.Parse( Console.ReadLine());
            }


            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


        }
    }
}
