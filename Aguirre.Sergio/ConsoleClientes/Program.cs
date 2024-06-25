using MisClases;

namespace ConsoleClientes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Caja Ahorro","20-35363314-8");
            cliente1.Apellido = "Gutierrez";
            cliente1.Nombre = "Kero";
            cliente1.Edad = 22;

            Clienteplus clienteplus1 = new Clienteplus("Caja Ahorro", "20-15353314-8",2593);
            clienteplus1.Nombre = "Chicho";
            clienteplus1.Apellido = "Serna";
            clienteplus1.Edad = 52;

            Console.WriteLine(cliente1.GuardarEnDisco());
            Console.WriteLine(clienteplus1.GuardarEnDisco());

            Console.WriteLine(Cliente.ValidarCUIT(cliente1.Cuit));
            Console.WriteLine(Cliente.ValidarCUIT(clienteplus1.Cuit));

        }
    }
}
