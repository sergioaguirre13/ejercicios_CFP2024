namespace VectoresEJ1_con_FUNCIONES
{
    internal class VectorFuncionEJ1
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos y mostrarlo.

            int[] numeros = CargarArray(5);

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }

        static int[] CargarArray(int cantidad)
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
    }
}
