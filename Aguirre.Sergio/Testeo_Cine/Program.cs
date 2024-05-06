using LibreriaDeBookStore;

namespace Testeo_Cine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool seguirComprando = true;
            int seleccion = 0;

            Cine pelicula1 = new Cine("Tiempos Violentos", "Tarantino", 1992, "Thriller");
            Cine pelicula2 = new Cine("La sirenita", "Gilian Morrison", 2015, "Animada");
            Cine pelicula3 = new Cine("El Rey Leon VI", "Pippo Cipollati", 2024, "Terror infantil");

            Console.WriteLine("Bievenido a CINEMAPOPULI!");

            do
            {
                Console.WriteLine("¿¡Que pelicula desea ver!?");

            Console.WriteLine("(1) Tiempos Violentos - (2) La sirenita - (3) El Rey Leon VI");
            seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Cuantas entradas desea para 'Tiempos Violentos' ?");
                    pelicula1.VenderEntrada(int.Parse(Console.ReadLine()));
                    Console.Write("La cantidad de entradas que quedan es: ");
                    Console.WriteLine(pelicula1.GetLugaresMaximos()); 
                    break;
                case 2:
                    Console.WriteLine("Cuantas entradas desea para 'La Sirenita' ?");
                    pelicula2.VenderEntrada(int.Parse(Console.ReadLine()));
                    Console.Write("La cantidad de entradas que quedan es: ");
                    Console.WriteLine(pelicula2.GetLugaresMaximos());
                    break;
                case 3:
                    Console.WriteLine("Cuantas entradas desea para 'El Rey Leon VI' ?");
                    pelicula3.VenderEntrada(int.Parse(Console.ReadLine()));
                    Console.Write("La cantidad de entradas que quedan es: ");
                    Console.WriteLine(pelicula3.GetLugaresMaximos());
                    break;
            }

                Console.WriteLine("¿Seguir Comprando? (APRETE 'S' PARA CONTINUAR u OTRA TECLA PARA TERMINAR)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    seguirComprando = false;
                }

            } while (seguirComprando);

            Console.Clear();    

            Console.WriteLine("Cartelera actualizada: ");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(pelicula1.PeliculaToString());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(pelicula2.PeliculaToString());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(pelicula3.PeliculaToString());
            Console.ResetColor();
        }
    }
}
