namespace Clase_funcion___metodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*
             una función para pedir el ingreso de una cadena y retornarla 
             */

            string nombre;
            string apellido;
            string direccion;

            nombre = PedirCadena("Ingrese su nombre: ");
            apellido = PedirCadena("Ingrese su apellido: ");
            direccion = PedirCadena("Ingrese su direccion: ");


            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(direccion);

            int unNumero = 8;
            int otroNumero = 5;
            int resultado;

            resultado = SumarEnteros(unNumero,otroNumero);
            Console.WriteLine(resultado);




            // que no devuelven nada y que reciben parametros

           

            // que no devuelven nada y reciben nada
        }


        // que devuelven algo y que reciben parametro
        static string PedirCadena(string mensaje)
        {
            string lectura;
            Console.Write(mensaje);
            lectura = Console.ReadLine();
            return lectura;
        }
        // que devuelvan algo y que no reciben parametros
        static string PedirNombre()
        {
            string lectura;
            Console.WriteLine("ingrese un nombre");
            lectura = Console.ReadLine();
            return lectura;
        }

        // que devuelven algo y que reciben parametro
        static int SumarEnteros(int numeroUno, int numeroDos)
        {
            int resultado;

            resultado = numeroUno + numeroDos;

            return resultado;
        }
    }
}
