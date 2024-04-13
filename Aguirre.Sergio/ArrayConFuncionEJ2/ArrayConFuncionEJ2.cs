namespace ArrayConFuncionEJ2
{
    internal class ArrayConFuncionEJ2
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.


            int[] numeros = IngresarEnterosYSumarArray(5);

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

            static int[] IngresarEnterosYSumarArray(int cantidad)
            {
                int[] array = new int[cantidad];
                int sumaArray = 0;

                Console.WriteLine($"Por favor ingrese: {cantidad} números para su array");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Ingresando array: ");
                    array[i] = int.Parse(Console.ReadLine());
                    sumaArray += array[i];
                }

                Console.WriteLine($"La suma del array es: {sumaArray}");

                return array;
            }



        }
    }
}
