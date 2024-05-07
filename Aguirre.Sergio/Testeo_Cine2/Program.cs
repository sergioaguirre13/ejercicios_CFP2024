using LibreriaDePeliculas;

namespace Testeo_Cine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool seguirComprando = true;
            int seleccion = 0;

            Peliculas pelicula1 = new Peliculas("Tiempos Violentos", "Tarantino", 1992, "Thriller");
            Peliculas pelicula2 = new Peliculas("La sirenita", "Gilian Morrison", 2015, "Animada");
            Peliculas pelicula3 = new Peliculas("El Rey Leon VI", "Pippo Cipollati", 2024, "Terror infantil");
            Peliculas pelicula4 = new Peliculas("DUNA", "Miguel Del Sol", 2023, "Ciencia Ficción");
            Peliculas pelicula5 = new Peliculas("Esperando la carroña", "Adrian Suar", 2020, "Comedia costumbrista");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Bievenido a CINEMAPOPULI!");

            do
            {
                Console.WriteLine("¿¡Que pelicula desea ver!?");

                Console.WriteLine("(1) Tiempos Violentos - (2) La sirenita - (3) El Rey Leon VI - (4) DUNA - (5) ESPERANDO LA CARROÑA");
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
                    case 4:
                        Console.WriteLine("Cuantas entradas desea para 'DUNA' ?");
                        pelicula4.VenderEntrada(int.Parse(Console.ReadLine()));
                        Console.Write("La cantidad de entradas que quedan es: ");
                        Console.WriteLine(pelicula4.GetLugaresMaximos());
                        break;
                    case 5:
                        Console.WriteLine("Cuantas entradas desea para 'Esperando la carroña' ?");
                        pelicula5.VenderEntrada(int.Parse(Console.ReadLine()));
                        Console.Write("La cantidad de entradas que quedan es: ");
                        Console.WriteLine(pelicula5.GetLugaresMaximos());
                        break;
                }

                Console.WriteLine("¿Seguir Comprando? (APRETE 'S' PARA CONTINUAR u OTRA TECLA PARA TERMINAR)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    seguirComprando = false;
                }

            } while (seguirComprando);



            Console.WriteLine("---------------------------------");

            List<Peliculas> listaPeliculas = new List<Peliculas>();

            listaPeliculas.Add(pelicula1);
            listaPeliculas.Add(pelicula2);
            listaPeliculas.Add(pelicula3);
            listaPeliculas.Add(pelicula4);
            listaPeliculas.Add(pelicula5);


            foreach (var item in listaPeliculas)
            {
                Console.WriteLine(item.PeliculaToString());
            }

        }
    }
}
