namespace LibreriaDePersonas
{
    public class Empleado
    {

        // atributos --> son los campos que definen mim objeto

        public int legajo;
        string nombre;
        string apellido;
        double sueldo;
        string areaDeTrabajo;

        // metodos SET y GET

        public double GetSueldo()
        {
            return sueldo;
        }

        public void SetSueldo(double sueldo)
        {
            if (sueldo > 0 && sueldo < 100000000)
            {
                this.sueldo = sueldo;

            }
        }

        // propiedades --> son una mezcla entre los atributos y/o metodos (get y set)   

        // constructor --> es un metodo que permite crear (instanciar o crear una nueva instancia) objetos de mi clase
        // visibilidad
        // comportamiento --> estatico o de instancia -- para ser static debe decirlo explicitamente, de lo contrario es de INSTANCIA.
        // NUNCA TIENEN RETORNO
        // nombre
        public Empleado(int legajo, string nombre, string apellido, double sueldo, string area)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.areaDeTrabajo = area;
        }

        public Empleado(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = 0;
            this.areaDeTrabajo = "Sin puesto";
        }

       
        // metodos --> son los comportamientos de mi clase(por lo gral se usan para comunicar info)
        // visibilidad
        // comportamiento
        // retorno
        // nombre
        // parametros

        //Para mostrar todos o algunos valores

        public string InformarDatos()
        {



            return  $"Legajo: {legajo} - Nombre: {apellido}, {nombre} - Puesto:{areaDeTrabajo} - Sueldo: {sueldo}";
        }

    }
}









