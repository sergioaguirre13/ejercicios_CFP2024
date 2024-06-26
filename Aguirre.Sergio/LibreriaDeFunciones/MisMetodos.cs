﻿namespace LibreriaDeFunciones
{
    public class MisMetodos
    {

        // averiguar si son numeros primos                                  
       public static bool EsPrimo(int numero)
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

        }


        //-----------------------------------------
        // ingreso - Suma y promedio de array --> Se pide por parametro la cantidad de numeros que llevara este array
       public static int[] IngresoSumaPromedioArray(int cantidad)
        {

            int[] array = new int[cantidad];
            int sumaArray = 0;
            int promedioArray = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"ingreses el {i + 1}° número: ");
                array[i] = int.Parse(Console.ReadLine());
                sumaArray += array[i];

            }

            promedioArray = sumaArray / cantidad;
            Console.WriteLine($"La suma de los numeros ingresados al array es de {sumaArray}");
            Console.WriteLine($"El promedio de los numeros ingresados al array es de {promedioArray}");


            return array;
        }

        //-----------------------------------------
        //Imprimir array
        public static void ImprimirArray(string mensaje, int[] array)
        {
            Console.WriteLine(mensaje);
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }
        //--------------------------------------

        public static bool EsSoloLetras(string data)
        {
            bool esSoloLetras = true;
            foreach (char letra in data)
            {
                if (!char.IsLetter(letra))
                {
                    esSoloLetras = false;
                    break;
                }
            }

            return esSoloLetras;

        }

        //-----------------------------------------------

        public static bool EsNumerica(string data)
        {
            bool esNumerica = true;
            foreach (char digito in data)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerica = false;
                    break;
                }
            }

            return esNumerica;
        }

    }
}
