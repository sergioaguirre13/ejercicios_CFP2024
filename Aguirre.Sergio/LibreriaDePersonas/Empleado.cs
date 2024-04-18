namespace LibreriaDePersonas
{
    public class Empleado
    {

        // atributos --> son los campos que definen mim objeto

        int legajo;
        string nombre;
        string apellido;
        double sueldo;
        string areaDeTrabajo;

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
            this.areaDeTrabajo = string.Empty;
        }

       
        // metodos --> son los comportamientos de mi clase(por lo gral se usan para comunicar info)
        // visibilidad
        // comportamiento
        // retorno
        // nombre
        // parametros

        //Para mostrar todos o algunos valores

    }
}
