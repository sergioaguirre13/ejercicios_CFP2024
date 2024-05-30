using LibreriaDeEstudiantes;

namespace Estudiantes
{
    internal class Estudiantes
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            {
                new Estudiante("Chicho", "Serna", "A01");
                new Estudiante("Pipo", "Gorosito", "A02");
                new Estudiante("Gustavo", "Barrios", "A03");

            }

            foreach (Estudiante a in listaEstudiantes)
            {
                a.SetNotaPrimerParcial(rand.Next(1, 10));
                a.SetNotaSegundoParcial(rand.Next(1, 10));
            }


            foreach (Estudiante item in listaEstudiantes)
            {
                Console.WriteLine(item.Mostrar());
            }

            //Estudiante estudiante1 = new Estudiante("Chicho","Serna","A01");
            //Estudiante estudiante2 = new Estudiante("Pipo", "Gorosito", "A02");
            //Estudiante estudiante3 = new Estudiante("Gustavo", "Barrios", "A03");



            // estudiante1.SetNotaPrimerParcial(8);
            // estudiante1.SetNotaSegundoParcial(9);

            // estudiante2.SetNotaPrimerParcial(6);
            // estudiante2.SetNotaSegundoParcial(4);

            // estudiante3.SetNotaPrimerParcial(3);
            // estudiante3.SetNotaSegundoParcial(2);

            // Console.WriteLine(estudiante1.Mostrar());
            // Console.WriteLine(estudiante2.Mostrar());
            // Console.WriteLine(estudiante3.Mostrar());

        }
    }
}
