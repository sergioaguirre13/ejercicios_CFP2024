namespace LibreriaDeCelulares
{
    public class Celular
    {
        //Atributos:(van a ser privados en este caso -si no le pongo nada asume que son privados)

        private string marca;
        private string modelo;
        private int almacenamiento;
        private string color;
        private string tipo;
        private int precio;
        private int cantidadStock;

        //Constructor:el unico metodo que no tenia retorno (void)
        //constructor va a ser de instancia
        //no tiene retorno y lleva siempre el nombre de la clase
        //puedo tener varios constructores pero respetando los parametros
        public Celular(string marca, string modelo, int capacidad, string color, string tipo, int precio, int cantidadStock)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.almacenamiento = almacenamiento;
            this.color = color;
            this.tipo = tipo;
            this.precio = precio;
            this.cantidadStock = cantidadStock;
        }
        //MetodosGetters y Setters-> Permitir consultar(get)
        //y/o modificar atributos(set insertar o agregar)
        //tienen que hacer referencia al atributo con el q estan trabajando
        public string GetMarca()
        {
            return marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public int GetAlmacenamiento()
        {
            return almacenamiento;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public int GetPrecio()
        {
            return precio;
        }
        public int GetCantidadStock()
        {
            return cantidadStock;
        }
        // los set no tienen retorno;
        public void SetPrecio(string CantidadStock)
        {
            precio = cantidadStock;
        }
        public void SetCantidadStock(string CantidadStock)
        {
            cantidadStock = cantidadStock;
        }
        //Comportamientos:
        public string CelularToString()
        {
            return $"Marca:{marca}- Modelo:{modelo}- Almacenamiento:{almacenamiento}- Color:{color}- Tipo:{tipo}- Precio:{precio}- CantidadStock:{cantidadStock}";

        }

        public bool SubirPasajeros(int cantidad)
        {
            bool puedenSubir = false;
            if ((this.capacidad > this.cantidadDePasajeros) && (this.cantidadDePasajeros + cantidad <= capacidad))
            {
                this.cantidadDePasajeros += cantidad;
                puedenSubir = true;
            }
            return puedenSubir;
        }
    }
}

