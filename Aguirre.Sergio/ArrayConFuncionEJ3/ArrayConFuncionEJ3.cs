namespace ArrayConFuncionEJ3
{
    internal class ArrayConFuncionEJ3
    {
        static void Main(string[] args)
        {

            // Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
            // Idem punto 2, pero calcular el promedio

            int[] numeros = IngresoSumaPromedioArray(5);

            Console.WriteLine("Los numeros ingresados al array son");
            foreach (var num in numeros)
            {
                Console.Write($"{num} / ");
            }


        }

        static int[] IngresoSumaPromedioArray(int cantidad)
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
    }
}
