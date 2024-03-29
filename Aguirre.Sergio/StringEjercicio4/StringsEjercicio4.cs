namespace StringsEjercicio4
{
    internal class StringsEjercicio4
    {
        static void Main(string[] args)
        {
            //            4.Del string 0000001234500000000 conseguir quedarse con el string 12345 y
            //mostrarlo por pantalla.

            string numeros = "0000001234500000000";
            string numeroSinCeros = "";

            foreach (char numero in numeros)
            {
                if (numero != '0')
                {
                    numeroSinCeros += numero;
                }
            }

            Console.WriteLine(numeroSinCeros);
        }
    }
}
