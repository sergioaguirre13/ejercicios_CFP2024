using System.Reflection.Emit;

namespace VectoresEjercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Crear un menú de opciones que permita:
            //            a.Cargar un array de caracteres.Recomendación: utilizar el
            //método toCharArray().
            //b.Ordenar vector.
            //c.Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
            //d.Reemplazar consonantes por el carácter ‘*’ y mostrar

            string palabra = "";
            int opcion;
            bool seguir = true;
            int contadorVocales = 0;
            

            Console.WriteLine("Bienvenido al sistema de cargas de Array");
            Console.WriteLine("Ingrese la palabra que quiere pasar a array");
            palabra = Console.ReadLine();

            Char[] palabraArray = palabra.ToCharArray();

            Console.WriteLine(@"¿Que desea hacer ?
            1.Ordenar vector.
            2.Contar vocales dentro del vector. (Cuantas a, e, i, o y u) 
            3.Reemplazar consonantes por el carácter ‘*’ y mostrar 
            4.Salir del programa. "); 
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Array.Sort(palabraArray);
                    Console.Write("El vector ordenado (alfabeticamente) quedaria: ");
                    Console.Write(palabraArray);

                    break;
                case 2:

                    foreach (var letra in palabraArray)
                    {
                        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                        {
                            contadorVocales++;
                        }
                    }
                    Console.WriteLine($"la cantidad de vocales es: {contadorVocales}");
                    break;

                case 3:

                    for (int i = 0; i < palabraArray.Length; i++)
                    {
                        if (palabraArray[i] != 'a' && palabraArray[i] != 'e' && palabraArray[i] != 'i' && palabraArray[i] != 'o' && palabraArray[i] != 'u')
                        {
                            palabraArray[i] = '*';
                        }
                        
                    }
                    Console.Write("La palabra con las consonantes reemplazadas es: ");
                    Console.Write(palabraArray);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
