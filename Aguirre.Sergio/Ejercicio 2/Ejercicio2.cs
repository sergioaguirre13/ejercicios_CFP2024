namespace Ejercicio_2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            // 2.Ingresar el nombre, apellido y edad por consola

            string nombre;
            string apellido;
            int edad;
            

            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"Su nombre es {nombre} y su apellido es {apellido}");
            Console.WriteLine($"Su edad es: {edad} años");
        }
    }
}
