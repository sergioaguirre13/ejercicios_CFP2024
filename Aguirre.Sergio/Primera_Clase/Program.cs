namespace Primera_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            string apellido;
            string edadTexto;
            int edadNumerica;


            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();

            edadNumerica = int.Parse(edadTexto);


            //Console.WriteLine ("Bienvenido " + nombre + " " + apellido + "!");
            //Console.WriteLine("Tu edad es:  " + edadNumerica);
                       
           // Console.WriteLine("Bienvenido {0} {1} ", nombre, apellido);
           // Console.WriteLine("Tu edad es: {0}", edadNumerica);

            Console.WriteLine($"Bienvenido {nombre}  {apellido} ");
            Console.WriteLine($"Tu edad es:  {edadNumerica}");

        }
    }
}
