using System.Drawing;
using System.Numerics;
using System;

namespace VectoresEjercicio7
{
    internal class VectoresEJ7
    {
        static void Main(string[] args)
        {

            //            Crear 3 vectores.En los primeros dos pedirle al usuario que cargue valores. El
            //            tercer vector deberá guardar el valor más grande como resultado de la
            //comparación de los otros dos

            int[] vectorUno = new int[5];
            int[] vectorDos = new int[5];
            int[] vectorTres = new int[5];


            Console.WriteLine("ingrese 5 numeros para el primer vector");

            for (int i = 0; i < vectorUno.Length; i++)
            {
                vectorUno[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("ingrese 5 numeros para el segundo vector");

            for (int i = 0; i < vectorDos.Length; i++)
            {
                vectorDos[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 0; i < vectorUno.Length; i++)
            {
                if (vectorUno[i] >= vectorDos[i])
                {
                    vectorTres[i] = vectorUno[i];
                }
                else
                {
                    vectorTres[i] = vectorDos[i];

                }
            }

            Console.Write("El primer vector ingresado es: ");

            foreach (var i in vectorUno)
            {
                Console.Write($"{i} ");
            }

            Console.Write("El segundo vector ingresado es: ");

            foreach (var i in vectorDos)
            {
                Console.Write($"{i} ");
            }

            Console.Write("El tercer vector ingresado es: ");

            foreach (var i in vectorTres)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
