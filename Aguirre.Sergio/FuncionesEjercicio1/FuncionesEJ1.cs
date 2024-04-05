using System.Runtime.ConstrainedExecution;

namespace FuncionesEjercicio1
{
    internal class FuncionesEJ1
    {
        static void Main(string[] args)
        {
            //Crear una función que evalúe si una palabra es corta o larga. Se considera larga si tiene más de 8 caracteres.
            //La función debe recibir un parámetro de tipo cadena(string) y su retorno debe ser booleano.

            string palabra;
            bool esLarga;
           
            Console.WriteLine("Escriba una palabra: ");
            palabra = Console.ReadLine();

           esLarga = WordLength(palabra);

            if (esLarga)
            {
                Console.WriteLine($"La palabra '{palabra}' tiene mas de 8 caracteres, osea es larga");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' tiene menos de 8 caracteres, osea es corta");
            }
        }

        static bool WordLength(string palabra)
        {
            bool isLong = false;

            if (palabra.Length > 8)
            {
                isLong = true;
            }

            return isLong; 
        }
    }
}
