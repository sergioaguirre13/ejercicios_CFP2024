namespace Ejercicio_3
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            // 3.Ingresar 2 números y mostrar la suma de los mismos.

            int num1;
            int num2;
            int totalSuma;

            Console.WriteLine("Por favor ingrese 2 números para sumar");
            Console.WriteLine("Primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número");
            num2 = int.Parse(Console.ReadLine());

            totalSuma = num1 + num2;

            Console.WriteLine($"El resultado de la suma de {num1} y {num2} es {totalSuma}");
        }
    }
}