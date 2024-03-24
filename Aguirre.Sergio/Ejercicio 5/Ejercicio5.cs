namespace Ejercicio_5
{
    internal class Ejercicio5
    {
        static void Main(string[] args)
        {
            // 5 . En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología. El
            //   presupuesto anual del hospital se reparte conforme a la siguiente tabla:
            // Área Porcentaje del presupuesto:
            //Cardiología 40 %
            //Pediatría 45 %
            //Traumatología 15 %

            int presupuestoTotal;
            double porcentajeCardio = 0.4;
            double porcentajePediatria = 0.45;
            double porcentajeTrauma = 0.15;
            double presupuestoCardio;
            double presupuestoPediatria;
            double presupuestoTrauma;
            

            Console.WriteLine("Bienvenido al sistema de distribución presupuestaria.");
            Console.Write("Por favor ingrese el presupuesto anual para el hospital: $");
            presupuestoTotal = int.Parse(Console.ReadLine());

            presupuestoCardio = presupuestoTotal * porcentajeCardio;
            presupuestoPediatria = presupuestoTotal * porcentajePediatria;
            presupuestoTrauma = presupuestoTotal * porcentajeTrauma;

            Console.WriteLine($"El presupuesto total es de: ${presupuestoTotal}");
            Console.WriteLine("El presupuesto se repartiria entonces: ");
            Console.WriteLine($"Cardiología (40% del presupuesto) se queda con: ${presupuestoCardio}");
            Console.WriteLine($"Pediatría (45% del presupuesto) se queda con: ${presupuestoPediatria}");
            Console.WriteLine($"Traumatología (15% del presupuesto) se queda con: ${presupuestoTrauma}");




        }
    }
}
