namespace VectoresEjercicio3
{
    internal class VectoresEJ3
    {
        static void Main(string[] args)
        {
                //Idem punto 2, pero calcular el promedio.


            int sumaNumeros = 0;
            int promedio = 0;
            int[] numeros = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Los numeros del vector son: ");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
                sumaNumeros = sumaNumeros + i;
            }

            Console.Write("La suma de todos esos numeros es: ");
            Console.WriteLine(sumaNumeros);

            Console.WriteLine($"La cantidad de numeros en el vector es: {numeros.Length}");
            promedio = sumaNumeros / numeros.Length;
            Console.WriteLine($"El promedio de los numeros en el vector es: {promedio}");



        }
    }
}
