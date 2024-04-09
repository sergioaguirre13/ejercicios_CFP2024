namespace VectoresEJ3_con_FUNCIONES
{
    internal class VectorFuncionEJ3
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo. (<-- punto 2)

            //Idem punto 2, pero calcular el promedio.

            int[] numeros = CargarArraysYPromedios(5);

            foreach (var item in numeros)
            {
                Console.Write($"{item} ");
            }

        }

        static int[] CargarArraysYPromedios(int cantidad)
        {
            int[] array = new int[cantidad];
            int sumaArray = 0;
            int promedioArray = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i + 1} de {cantidad}");
                array[i] = int.Parse(Console.ReadLine());
                sumaArray += array[i];
            }

            promedioArray = sumaArray / cantidad;
            Console.WriteLine($"La suma de los numeros del array ingresado es: {sumaArray} ");
            Console.WriteLine($"El promedio de los numeros del array ingresado es: {promedioArray}");

            return array;
        }
    }
}
