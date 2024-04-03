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

            do
            {

                Console.WriteLine("Ingrese una palabra para verificar que tenga 5 caracteres");
                palabra = Console.ReadLine();

                verificiador = palabra.Length;

                if (palabra.Length < 5)
                {
                    Console.WriteLine("La palabra es muy corta");
                }


            } while (palabra.Length < 5);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(palabra[i]);
            }

           
        }
    }
}
