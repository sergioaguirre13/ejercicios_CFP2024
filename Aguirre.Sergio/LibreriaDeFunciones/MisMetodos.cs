namespace LibreriaDeFunciones
{
    public class MisMetodos
    {

        // averiguar si son numeros primos |
        //                                 |
        //                                 v
       public static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)  //use esta forma de iterar ya que covenia iterar hasta la raiz cuadrada del número.
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;

        }


        //-----------------------------------------


        // ingresar números a un array dando como parametro la cantidad de numeros que debe tener.
        static int[] IngresarEnterosArray(int cantidad)
        {
            int[] array = new int[cantidad];

            Console.WriteLine($"Por favor ingrese: {cantidad} números para su array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Ingresando array: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        //-----------------------------------------

        // idem array de arriba pero agrega la suma del array
        static int[] IngresarEnterosYSumarArray(int cantidad)
        {
            int[] array = new int[cantidad];
            int sumaArray = 0;

            Console.WriteLine($"Por favor ingrese: {cantidad} números para su array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Ingresando array: ");
                array[i] = int.Parse(Console.ReadLine());
                sumaArray += array[i];
            }

            Console.WriteLine($"La suma del array es: {sumaArray}");

            return array;
        }


    }
}
