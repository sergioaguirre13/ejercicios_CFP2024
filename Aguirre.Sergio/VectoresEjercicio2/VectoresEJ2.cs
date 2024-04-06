using System.Numerics;

namespace VectoresEjercicio2
{
    internal class VectoresEJ2
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.


            int sumaNumeros = 0;
            int[] numeros = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Los numeros del vector son: ");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
                sumaNumeros = sumaNumeros + i;
            }

            Console.Write("La suma de todos esos numeros es: ");
            Console.WriteLine(sumaNumeros);
        }
    }
}
