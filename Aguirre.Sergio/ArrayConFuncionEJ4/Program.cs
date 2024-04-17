using System.Reflection.Emit;

namespace ArrayConFuncionEJ4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crear un menú de opciones que permita:
            //            a.Cargar un array de caracteres.Recomendación: utilizar el
            //método toCharArray().
            //b.Ordenar vector.
            //c.Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
            //d.Reemplazar consonantes por el carácter ‘*’ y mostrar

            bool opciones = true;
            int opcionesMenu;

            Console.WriteLine("Elija la opción que desee: ");
            opcionesMenu = int.Parse(Console.ReadLine());

            char[] palabra;
           

            switch (opcionesMenu)
            {
                case 1:
                    palabra = IngresoPalabraArray();
                    break;
                    case 2:
                    //ordenar vector
                    break;
                    case 3:
                    palabra = IngresoContadorReemplazador(opciones);

                    foreach (var letras in palabra)
                    {
                        Console.Write(letras);
                    }

                    break;
                case 4:
                    palabra = IngresoContadorReemplazador(!opciones);
                    break;
            }



        }
        
        static char[] IngresoPalabraArray() 
        {
            char[] array;
            string palabra;

            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();
            array = palabra.ToCharArray();

            foreach (var letra in palabra)
            {
                Console.Write($"{letra}  ");
            }

            return array;
        }

        static char[] IngresoContadorReemplazador(bool opciones)
        {
            char[] array;
            string palabra;
            int contarVocales = 0;
            
            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();
            array = palabra.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {

                if ((array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u') && opciones)
                {
                    contarVocales++;
                }
                else if (!(array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u') && !opciones)
                {
                    array[i] = '*';
                }

                
            }

            return array;
        }


            
        }



    }
