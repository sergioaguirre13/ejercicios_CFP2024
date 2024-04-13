namespace Automoviles
{
    public class Autos
    {

        // dos tipos de clases --> Static --> no requiere una instancia.
        //                     --> DE INSTANCIA

        // atributos
        //marca, modelo, motor, puertas, rodado, color, transmision, patente

        string marca;
        string patente;
        int modelo;
        double precio;

        // constructor

        public Autos(string marca, string patente, int modelo, double precio)
        {
            this.marca = marca;
            this.patente = patente;
            this.modelo = modelo;
            this.precio = precio;
        }

        //comportamientos --> metodos
        public string TocarBocina()
        {
            return "tuuuuuum";
        }

    }
}
