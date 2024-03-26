using System.Runtime.ConstrainedExecution;

namespace Ejercicio_7__repetitivas_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ingresar 15 números y determinar:
            //Suma de los negativos. --
            //Suma de los positivos.        --
            //Cantidad de positivos.       --
            //Cantidad de negativos.    --
            //Cantidad de ceros.        --
            //Cantidad de números pares.    --
            //Promedio de positivos.    --
            //Promedio de negativos.      --
            //Diferencia entre positivos y negativos, (positivos - negativos). --
            //El número máximo --
            //De los negativos el mínimo --

            int repeticiones = 15;   
            int numerosIngresados = 0;
            int sumaNegativos = 0;
            int sumaPositivos = 0;
            int contadorPares = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;
            int promedioPositivos = 0;
            int promedioNegativos = 0;
            int diferencia = 0;
            int numeroMax = 0;
            int numeroMin = 0;
            int minNegativo = 0;
            int maxPositivo = 0;



            for (int i = 0; i < repeticiones; i++)
            {

                Console.WriteLine($"Ingrese un número ({i + 1} - 15)");
                numerosIngresados = int.Parse(Console.ReadLine());

                if (numerosIngresados < 0)
                {
                    sumaNegativos += numerosIngresados;
                    contadorNegativos++;

                    if (numerosIngresados < minNegativo)
                    {
                        minNegativo = numerosIngresados;
                    }

                } else
                {
                    sumaPositivos += numerosIngresados;
                    contadorPositivos++;

                    if (numerosIngresados > maxPositivo)
                    {
                        maxPositivo = numerosIngresados;
                    }
                }

                if (numerosIngresados == 0)
                {
                    contadorCeros++;
                }

                if (numerosIngresados % 2 == 0)
                {
                    contadorPares++;
                }

            }

            promedioPositivos = sumaPositivos / repeticiones;
            promedioNegativos = sumaNegativos / repeticiones;

            diferencia = sumaPositivos - sumaNegativos;

            Console.WriteLine($"La suma de positivos es {sumaPositivos}");
            Console.WriteLine($"La suma de negativos es {sumaNegativos}");

            Console.WriteLine($"La cantidad de positivos: {contadorPositivos}");
            Console.WriteLine($"La cantidad de negativos: {contadorNegativos}");
            Console.WriteLine($"La cantidad de ceros : {contadorCeros}");
            Console.WriteLine($"La cantidad de pares : {contadorPares}");

            Console.WriteLine($"El promedio de los positivos es: {promedioPositivos}");
            Console.WriteLine($"El promedio de los negativos es: {promedioNegativos}");

            Console.WriteLine($"La diferencia que hay entre positivos y negativos es de: {diferencia}");

            Console.WriteLine($"El número maximo positivo ingresado es: {maxPositivo}");
            Console.WriteLine($"El número minimo negativo ingresado es: {minNegativo}");


        }
    }
}

