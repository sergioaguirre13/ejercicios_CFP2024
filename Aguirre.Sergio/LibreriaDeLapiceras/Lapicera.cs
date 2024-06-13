using System.Drawing;

namespace LibreriaDeLapiceras
{
    public class Lapicera
    {
        Color color;
        double precio;
        string marca;
        int nivelDeTinta;

        public Color Color { get => color; }
        public double Precio { get => precio; }
        public string Marca { get => marca; }
        public int NivelDeTinta { get => nivelDeTinta; }

        public Lapicera(Color color, double precio, string marca)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
            this.nivelDeTinta = 100;
        }

        public override string? ToString()
        {
            return $"La marca {Marca} - el precio {Precio} - color {Color} - nivel de tinta {NivelDeTinta}";
        }

        public bool Escribir(int cantLetras)
        {
            return false;
        }

        public void Recargar()
        {
            this.nivelDeTinta = 100;
        }

       

        //Sobreescribir el metodo ToString() para que muestre todos sus valores.

        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta, el metodo debe verificar si tiene tinta
        //para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.

        //El metodo public void Recargar() que colocara el nivel a 100 nuevamente.

        //Al igual que hicimos con los formularios de ingresante, crear dos forms, el principal con el datagridview y el boton agregar y
        //el fomrAlta para crear lapiceras, utilizar groupbox, combobox y la mayor variedad de componentes posibles.


    
    }
}
