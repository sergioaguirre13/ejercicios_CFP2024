namespace StringsEjercicio5
{
    internal class StringsEjercicio5
    {
        static void Main(string[] args)
        {
            //            5.Pedir el ingreso de nombre y apellido separado por un espacio, guardar
            //cada dato en una variable diferente y asegurarse de que respete el formato de
            //la primera letra en mayúscula y el resto en minúsculas, mostrar el apellido y el
            //nombre por separado.
            //ej: juAN ROBles(primero nombre luego apelido)
            //imprimir:
            //        Apellido: Robles.
            //        Nombre: Juan


            string ingresoUsuario;
            string apellido;
            string nombre;

            Console.WriteLine("Ingrese su apellido y nombre, separado por un espcacio");
            ingresoUsuario = Console.ReadLine();

            string[] separacion = ingresoUsuario.Split(' ');
            apellido = separacion[0];
            nombre = separacion[1];

            nombre = nombre.ToLower();
            nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);
            apellido = apellido.ToLower();
            apellido = char.ToUpper(apellido[0]) + apellido.Substring(1);

          
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Nombre: " + nombre);
        }
    }
}
