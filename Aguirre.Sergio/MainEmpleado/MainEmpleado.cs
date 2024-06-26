using MisClases;

namespace MainEmpleado
{
    public class MainEmpleado
    {
        static void Main(string[] args)
        {
            Empleado gerente1 = new Gerente("Richard",2000,"Turismo",10,50);
            Empleado desarrollador1 = new Desarrollador("Pipo", 300, "Turismo", 1, "C#",3);
            Empleado analista1 = new Analista("Miguela", 500, "Turismo", 3, "Javascript", "nueva Web 2.0");

            List<Empleado> listaEmpleados = new List<Empleado>() 
            {  gerente1, desarrollador1, analista1 };

            foreach (Empleado item in listaEmpleados)
            {
                Console.WriteLine(item.MostrarInfo());
                Console.WriteLine(item.Trabajar());

                Console.WriteLine($"Su salario es de: ${item.Salario}");
                Console.WriteLine($"La bonificación es de: ${item.CalcularBonificacion(item.Salario)}");
                Console.WriteLine($"Su ganancia total es de: ${item.SueldoTotal()}");
                Console.WriteLine("--------");
            }

            foreach (Empleado item in listaEmpleados)
            {
                if (item.GetType() == typeof(Gerente))
                {
                    Console.WriteLine(((Gerente)item).Planificar());
                }
                else if (item.GetType() == typeof(Desarrollador))
                {
                    Console.WriteLine(((Desarrollador)item).DepurarCodigo());
                }
                else if (item.GetType() == typeof(Analista))
                {
                    Console.WriteLine(((Analista)item).PrepararInforme());
                }
            }

           




        }
    }
}
