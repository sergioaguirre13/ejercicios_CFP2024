namespace Ejercicio_4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            //  Ingresar 5 números enteros, calcular y mostrar el promedio.

            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            int sumaNum;
            double cantidadNotas = 5;
            double promedio;

            Console.WriteLine("Bienvenida/o a la calculadora de promedios!");
            Console.WriteLine("Por favor, ingrese 5 números enteros para mostrar su promedio final");

            Console.WriteLine("Primer entero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo entero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tercer entero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuarto entero");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quinto entero");
            num5 = int.Parse(Console.ReadLine());

            sumaNum = num1 + num2 + num3 + num4 + num5;
            promedio = sumaNum / cantidadNotas;

            Console.WriteLine("Usted ingreso: ");
            Console.WriteLine($"{num1} - {num2} - {num3} - {num4} - {num5}");
            Console.WriteLine($"Su promedio es: {promedio}");


        }
    }
}
