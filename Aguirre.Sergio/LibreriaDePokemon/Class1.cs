namespace LibreriaDePokemon
{
    public class Pokemon
    {
        int numero;
        string nombre;
        string tipo;
        string genero;
        int dificultadDeCaptura; // Se puede pensar un metodo para capturar pokemon segun su dificultad

        public Pokemon(int numero, string nombre, string tipo, string genero, int dificultad)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.dificultadDeCaptura = dificultad;
        }

        public int getNumero()
        {
            return numero;
        }

        public string getTipo()
        {
            return tipo;
        }

        public string getGenero()
        {
            return genero;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        // un metodo que genere un numero aleatorio y ese numero designe a los pokemones creados (y que aparescan para capturar)

    }
}
