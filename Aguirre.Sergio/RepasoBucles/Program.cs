namespace RepasoBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int control = 0;
            int repeticiones = 5;
            int contadorPares = 0;

            //mientras
            //para
            //repetir

            // limite de repeticiones
            // variable de control
            // condicion de corte

            // WHILE
            // DO WHILE
            // FOR
            // FOREACH

            //while (control <= 5)
            //{
            //    Console.WriteLine(control);
            //    control++;
            //}

            //do
            //{
            //    Console.WriteLine(control);
            //    control++;
            //} while (control < repeticiones);

            for (int i = 0; i < repeticiones; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} es un número par");
                    contadorPares++;
                }

                if (i > 0)
                {
                    Console.WriteLine($"{i} es un numerop positivo");
                }
            }


        }
    }
}
