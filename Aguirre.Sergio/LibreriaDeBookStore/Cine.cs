using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDePeliculas
{
    public class Cine
    {
        
        private List<Peliculas> listaPeliculas;

        public Cine()
        {
            listaPeliculas = new List<Peliculas>();
        }

        public void AgregarPelicula(Peliculas peliculas)
        {
            listaPeliculas.Add(peliculas);
        }


        public void MostrarPeliculas()
        {
            foreach (var peliculas in listaPeliculas)
            {
                Console.WriteLine($"nombre: {peliculas.nombre} - director: {peliculas.director} - Año: {peliculas.anio} - Genero: {peliculas.genero} ");
            }
        }

        
        
    }
}
