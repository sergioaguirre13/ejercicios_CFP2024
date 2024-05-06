namespace LibreriaDeBookStore
{
    public class Libreria
    {
        string libro;
        string autor;
        int anio;
        int cantidadDisponible;

        public Libreria (string libro, string autor, int anio, int cantidadDisponible)
        {
            this.libro = libro;
            this.autor = autor;
            this.anio = anio;
            this.cantidadDisponible = cantidadDisponible;
        }
        #region set & get
        public string GetLibro()
        {
            return libro;
        }

        public string GetAutor()
        {
            return autor;
        }

        public int GetAnio()
        {
            return anio;
        }

        public int GetCantidadDisponible()
        {
            return cantidadDisponible;
        }

        public void SetLibro(string nombre)
        {
            libro = nombre;
        }

        public void SetAutor(string nombre)
        {
            autor = nombre;
        }

        public void SetAnio(int anioDeEdicion)
        {
            anio = anioDeEdicion;
        }

        public void SetCantidadDisponible (int cantidad)
        {
            cantidadDisponible = cantidad;
        }
        #endregion

        public string LibreriaToString()
        {
            return $"Libro: {libro} - Autor {autor} - Año: {anio} - Cantidad disponible {cantidadDisponible}";
        }
    }
}
