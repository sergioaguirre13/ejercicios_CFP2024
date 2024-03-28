namespace StringsEjercicio1
{
    internal class StringsEjercicio1
    {
        static void Main(string[] args)
        {
            // 1.Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres de no ser así informar, luego mostrar los primeros 3 caracteres.
            //ej: zapallo->zap

            string palabra;
            int verificiador = 0;

            Console.WriteLine("Ingrese una palabra para verificar que tenga 5 caracteres");
            palabra = Console.ReadLine();

            verificiador = palabra.Length;

            if (verificiador >= 5)
            {
                Console.WriteLine("Esta palabra tiene 5 o mas caracteres");
            } else
            {
                Console.WriteLine("Esta palabra no cuenta con los suficientes caracteres");
            }

            Console.WriteLine($"Los primeros 3 caracteres de la palabra {palabra} son: {palabra[0]}{palabra[1]}{palabra[2]}");
        }
    }
}
