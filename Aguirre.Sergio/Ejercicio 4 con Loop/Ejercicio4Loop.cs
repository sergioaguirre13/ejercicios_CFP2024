namespace Ejercicio_4_con_Loop
{
    internal class Ejercicio4Loop
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números enteros, calcular y mostrar el promedio. (EJERCICIO 4 CON REPETITIVAS)

            int cantidadEnteros = 5;
            int numeros = 0;
            int sumaNumeros = 0;
            int promedio = 0;

            for (int i = 0; i < cantidadEnteros; i++)
            {
                Console.Write("Por favor, ingrese un número entero: ");
                numeros = int.Parse(Console.ReadLine());
                sumaNumeros += numeros;
            }

            promedio = sumaNumeros / cantidadEnteros;

            Console.WriteLine($"La suma de los números ingresados es: {sumaNumeros}");
            Console.WriteLine($"El promedio de los números enteros ingresados es: {promedio}");
        }
    }
}
