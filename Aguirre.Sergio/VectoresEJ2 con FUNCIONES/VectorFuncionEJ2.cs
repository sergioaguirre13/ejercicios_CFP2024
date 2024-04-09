namespace VectoresEJ2_con_FUNCIONES
{
    internal class VectorFuncionEJ2
    {
        static void Main(string[] args)
        {


            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.

            int[] numeros = CargarArrays(4);

            int sumaArray = SumarArrays(numeros);

            foreach (int i in numeros)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine($"La suma de los números del array es: {sumaArray}");


        }
        static int[] CargarArrays(int cantidad)
        {

            int[] array = new int[cantidad];

            Console.WriteLine($"Ingrese {cantidad} números ");

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"{i + 1} de {cantidad}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static int SumarArrays(int[] array)
        {
            int sumaArrays = 0;

            foreach (var item in array)
            {
                sumaArrays += item;
            }

            return sumaArrays;
        }
    }
}
