using System.Diagnostics;

namespace Ejercicio_8_Switch
{
    internal class Ejercicio8Switch
    {
        static void Main(string[] args)
        {

            //            (SWITCH)Pedir una opción al usuario(1,2,3,4,5,6)
            //1.Fondo azul y letras rojo
            //2.Fondo verde y letras amarillas
            //3.Fondo amarillo y letras azules
            //4.Fondo blanco y letras negras
            //5.Fondo magenta oscuro y letras amarillas
            //6.Fondo blanco y letras azules
            //Mostrar un mensaje que introdujo el usuario con la combinación deseada.
            //Utilizar las propiedades de la clase Console:
            //            ForegroundColor
            //            BackGroundColor
            //Y los enumerados de: ConsoleColor(black, grey, green, etc)

            string texto;
            int opcion;

            Console.Write("Ingrese un texto para colorear: ");
            texto = Console.ReadLine();
            Console.WriteLine("ingrese una opción  para elegir el formato");
            Console.WriteLine("ingrese una opción ( 1 - 6) para elegir el formato");
            Console.WriteLine("1.\tFondo azul y letras rojo");
            Console.WriteLine("2.\tFondo verde y letras amarillas");
            Console.WriteLine("3.\tFondo amarillo y letras azules");
            Console.WriteLine("4.\tFondo blanco y letras negras");
            Console.WriteLine("5.\tFondo magenta oscuro y letras amarillas");
            Console.WriteLine("6.\tFondo blanco y letras azules");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Su texto sin formato es: {texto}");
                    Console.Write("Su texto con formato es: ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.WriteLine($"Su texto sin formato es: {texto}");
                    Console.Write("Su texto con formato es: ");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.WriteLine($"Su texto sin formato es: {texto}");
                    Console.Write("Su texto con formato es: ");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.WriteLine($"Su texto sin formato es: {texto}");
                    Console.Write("Su texto con formato es: ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case 5:
                    Console.WriteLine($"Su texto sin formato es: {texto}");
                    Console.Write("Su texto con formato es: ");
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case 6:
                    Console.WriteLine($"Su texto sin formato es: {texto}");
                    Console.Write("Su texto con formato es: ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
            }
        }
    }
}
