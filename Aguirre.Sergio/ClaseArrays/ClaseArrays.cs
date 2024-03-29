namespace ClaseArrays
{
    internal class ClaseArrays
    {
        static void Main(string[] args)

        {
            string[] miCadena = new string[5];

            char[] cadenaLetras = new char[5];

            int[] arrayNumerico = new int[5];

            int largo;

            string[] arrayPalabras = { "milanesa", "lechuga", "rojo", "laura" };


            miCadena[0] = "20/12/2022";
            miCadena[1] = "pedro";
            miCadena[2] = "1564561";
            miCadena[3] = "es un día soleado";
            miCadena[4] = "23/#$/#$";

            largo = arrayPalabras.Length;

            //for (int i = 0; i < largo; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        miCadena[i] = "Este numero es par";
            //    }

            //    Console.WriteLine(miCadena[i]);

            //}

            //for (int i = 0; i < largo; i++)
            //{
            //    if (miCadena[i] != "pedro")
            //    {
            //        miCadena[i] = "Ustedes no son pedro" ;
            //        Console.WriteLine(miCadena[i]);
            //    }
            //}

            foreach (string dato in arrayPalabras)
            {
                Console.WriteLine(dato);
            }

            cadenaLetras[0] = 'h';


        }
    }
}