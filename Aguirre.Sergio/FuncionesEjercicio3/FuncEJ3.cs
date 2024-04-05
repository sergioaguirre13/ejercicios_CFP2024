using System.Runtime.ConstrainedExecution;

namespace FuncionesEjercicio3
{
    internal class FuncEJ3
    {
        static void Main(string[] args)
        {

            //Se requiere la creación de una función que cumpla con los siguientes requisitos:
            //La función debe recibir tres parámetros: 'valor'(numérico), 'porcentaje'(numérico) y 'esAumento'(booleano).
            //Si el parámetro 'esAumento' es verdadero, la función debe aumentar el 'valor' original aplicando el 'porcentaje' dado.
            //Si el parámetro 'esAumento' es falso, la función debe disminuir el 'valor' original aplicando el 'porcentaje' dado.
            //El resultado obtenido después de aplicar el porcentaje al 'valor' original debe ser retornado por la función.

            int valor;
            int porcentaje;
            string aumento;
            bool esAumento;

            Console.WriteLine("Ingrese un valor: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un porcentaje: ");
            porcentaje = int.Parse(Console.ReadLine());

            Console.WriteLine("Tiene aumento? (si - no)");
            aumento = Console.ReadLine();

            if (aumento == "si")
            {
                esAumento = true;
                Console.WriteLine($"El precio con aumento es: ${CalcularValor(valor, porcentaje, esAumento)} ");
            }
            else
            {
                esAumento = false;
                Console.WriteLine($"El precio con reducción es: ${CalcularValor(valor, porcentaje, esAumento)} ");
            }


            static double CalcularValor(int valor, double porcentaje, bool esAumento)
            {
                double porcentajeAgregar = valor * porcentaje / 100;
                double resultado = 0;

                if (esAumento)
                {
                    resultado = valor + porcentajeAgregar;
                }
                else
                {
                    resultado = valor - porcentajeAgregar;
                }

                return resultado;
            }

        }
    }
}
