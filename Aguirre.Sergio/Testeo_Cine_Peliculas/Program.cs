using LibreriaDePeliculas;

namespace LibreriaDePeliculas
{
    internal class Program
    {
        static Peliculas pelicula1;
        static Peliculas pelicula2;
        static Peliculas pelicula3;
        static Peliculas pelicula4;
        static Peliculas pelicula5;
        
        static void Main(string[] args)
        {
            int seleccion = 0;
            int cantidadEntradas = 0;

            Cine cine = new Cine();
            Peliculas pelicula1 = new Peliculas("Tiempos Violentos", "Tarantino", 1992, "Thriller");
            Peliculas pelicula2 = new Peliculas("La sisternita", "Gilian Morrison", 2015, "Animada");
            Peliculas pelicula3 = new Peliculas("El Rey Leon VI", "Pippo Cipollati", 2024, "Comedia infantil");
            Peliculas pelicula4 = new Peliculas("DUNA", "Miguel Del Sol", 2023, "Ciencia Ficción");
            Peliculas pelicula5 = new Peliculas("Esperando la carroña", "Adrian Suar", 2020, "Comedia costumbrista");

            cine.AgregarPelicula(pelicula1);
            cine.AgregarPelicula(pelicula2);
            cine.AgregarPelicula(pelicula3);
            cine.AgregarPelicula(pelicula4);
            cine.AgregarPelicula(pelicula5);


            Console.WriteLine("Bienvenido a CINEMAPOPULI!");
            Console.WriteLine("aqui la cartelera: ");
            cine.MostrarPeliculas();

            Console.WriteLine("Seleccione que pelicula desea ver?");
            Console.WriteLine($"(1) {pelicula1.nombre} (2) {pelicula2.nombre} (3) {pelicula3.nombre} (4) {pelicula4.nombre} (5) {pelicula5.nombre}");
            seleccion = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas entradas desea ?");
            cantidadEntradas = int.Parse(Console.ReadLine());

            ComprarEntradas(cantidadEntradas,seleccion);

           
        }

        //ARREGLAR INSTANCIAS DE LOS OBJETOS EN EL METODO
        public static void ComprarEntradas(int cantidad, int seleccionPelicula)
        {
            switch (seleccionPelicula)
            {
                case 1:
                    Console.WriteLine($"compro {cantidad} de entrada/s para {pelicula1.nombre}");
                    break;
                case 2:
                    Console.WriteLine($"compro {cantidad} de entrada/s para {pelicula2.nombre}");
                    break;
                case 3:
                    Console.WriteLine($"compro {cantidad} de entrada/s para {pelicula3.nombre}");
                    break;
                case 4:
                    Console.WriteLine($"compro {cantidad} de entrada/s para {pelicula4.nombre}");
                    break;
                case 5:
                    Console.WriteLine($"compro {cantidad} de entrada/s para {pelicula5.nombre}");
                    break;
            }
        }
    }
}
