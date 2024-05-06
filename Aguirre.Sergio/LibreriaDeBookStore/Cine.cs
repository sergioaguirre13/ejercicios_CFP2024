namespace LibreriaDeBookStore
{
    public class Cine
    {
        string pelicula;
        string director;
        int anio;
        string genero;
        int entradasVendidas;
        int lugaresMaximos;

        public Cine(string pelicula, string director,int anio, string genero)
        {
            this.pelicula = pelicula;
            this.director = director;
            this.anio = anio;
            this.genero = genero;
            this.entradasVendidas = 0;
            this.lugaresMaximos = 50;
        }
     
        #region setters - getters
        public void SetPelicula(string nombre)
        {
            pelicula = nombre;
        }

        public void SetDirector (string nombre)
        {
            director = nombre;
        }

        public void SetAnio (int fecha)
        {
            anio = fecha;
        }

        public void SetGenero (string nombre)
        {
            genero = nombre;
        }

        public void SetEntradasVendidas(int entradas)
        {
            entradasVendidas = entradas;
        }

        public string GetPeliculas()
        {
            return pelicula;
        }

        public string GetDirector() 
        { 
            return director;
        }

        public int GetAnio()
        { 
            return anio;
        }

        public string GetGenero()
        {
            return genero;
        }

        public int GetEntradasVendidas()
        {
            return entradasVendidas;
        }

        public int GetLugaresMaximos()
        {
            return lugaresMaximos;
        }

        #endregion

        public string PeliculaToString()
        {
            return $"Pelicula: {pelicula} - Director: {director} - Año: {anio} - Genero: {genero} - Entradas Vendidas: {entradasVendidas}";
        }

        public bool VenderEntrada(int cantidad)
        {
            Console.WriteLine($"Usted desea comprar {cantidad} de entrada/s");

            if (cantidad > lugaresMaximos)
            {
                Console.WriteLine("No hay disponibilidad para esa cantidad de entradas");
                Console.WriteLine($"Disponibilidad en este momento: {lugaresMaximos}");
                if (lugaresMaximos == 0)
                {
                    Console.WriteLine("ENTRADAS AGOTADAS");
                }
                return false;
            }
            else
            {
                entradasVendidas += cantidad;
                lugaresMaximos -= cantidad;
                Console.WriteLine("La compra se realizo con exito");
                return true;
            }

            
        }


        

    }

}
