using System.Runtime.CompilerServices;
using System.Text;

namespace LibreriaDeEstudiantes
{
    public class Estudiante
    {


        private string legajo;
        private string apellido;
        private string nombre;
        

        public string Legajo { get => legajo; set => legajo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }



        

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Legajo = legajo;
        }


         public static List<Estudiante> ListaEstudiantes()
        {
            return new List<Estudiante>()
            {
                new Estudiante("Jose", "Marino", "1001"),
                new Estudiante("Pipo", "Cipollati", "1002"),
                new Estudiante("Mirko", "Gutierrez", "1003"),
                new Estudiante("Vera", "Alvarez", "1004"),
            };
        }

        public override string? ToString()
        {
            return $"{apellido}, {nombre}";
        }
    }
}
