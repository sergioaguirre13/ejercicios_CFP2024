namespace LibreriaDePeliculas
{
    public class Peliculas
    {
        public string nombre {  get; set; }
        public string director {  get; set; }
        public int anio { get; set; }
        public string genero { get; set; }
        public int entradasVendidas { get; set; }
        public int lugaresMaximos { get; set; }

          public Peliculas(string nombre, string director, int anio, string genero)
            {
            this.nombre = nombre;
            this.director = director;
            this.anio = anio;
            this.genero = genero;
            this.lugaresMaximos = 50;
            this.entradasVendidas = 0;
            }
     



        
            
        

    }

}

