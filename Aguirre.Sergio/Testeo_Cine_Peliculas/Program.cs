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
            

            Cine cine = new Cine();
            pelicula1 = new Peliculas("Tiempos Violentos", "Tarantino", 1992, "Thriller");
            pelicula2 = new Peliculas("La sisternita", "Gilian Morrison", 2015, "Animada");
            pelicula3 = new Peliculas("El Rey Leon VI", "Pippo Cipollati", 2024, "Comedia infantil");
            pelicula4 = new Peliculas("DUNA", "Miguel Del Sol", 2023, "Ciencia Ficción");
            pelicula5 = new Peliculas("Esperando la carroña", "Adrian Suar", 2020, "Comedia costumbrista");

            cine.AgregarPelicula(pelicula1);
            cine.AgregarPelicula(pelicula2);
            cine.AgregarPelicula(pelicula3);
            cine.AgregarPelicula(pelicula4);
            cine.AgregarPelicula(pelicula5);


            Console.WriteLine("Bienvenido a CINEMAPOPULI!");
            Console.WriteLine("-----CARTELERA-----");
            cine.MostrarPeliculas();
            Console.WriteLine("-------------------");

            ComprarEntradas();

            Console.Clear();
            Console.WriteLine("Ventas: ");
            cine.MostrarVentas();
        }

        public static void ComprarEntradas()
        {
            string seguirComprando = string.Empty;
            int seleccion = 0;
            int cantidadEntradas = 0;

            do
            {

             Console.WriteLine("Seleccione que pelicula desea ver?");
            Console.WriteLine($"(1) {pelicula1.nombre} (2) {pelicula2.nombre} (3) {pelicula3.nombre} (4) {pelicula4.nombre} (5) {pelicula5.nombre}");
            seleccion = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas entradas desea ?");
            cantidadEntradas = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:

                        if (cantidadEntradas > pelicula1.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                        Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {pelicula1.nombre}");
                        pelicula1.entradasVendidas += cantidadEntradas;
                        pelicula1.lugaresMaximos -= cantidadEntradas;
                        
                        }
                        break;

                    case 2:
                        if (cantidadEntradas > pelicula2.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {pelicula2.nombre}");
                            pelicula2.entradasVendidas += cantidadEntradas;
                            pelicula2.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 3:
                        if (cantidadEntradas > pelicula3.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {pelicula3.nombre}");
                            pelicula3.entradasVendidas += cantidadEntradas;
                            pelicula3.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 4:
                        if (cantidadEntradas > pelicula4.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {pelicula4.nombre}");
                            pelicula4.entradasVendidas += cantidadEntradas;
                            pelicula4.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 5:
                        if (cantidadEntradas > pelicula5.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {pelicula5.nombre}");
                            pelicula5.entradasVendidas += cantidadEntradas;
                            pelicula5.lugaresMaximos -= cantidadEntradas;

                        }
                        break;
                }

                Console.WriteLine("Seguir comprando?");
                seguirComprando = Console.ReadLine();

            } while (seguirComprando == "s") ;

         }
     }
    
        
}   
