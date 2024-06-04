using System.Runtime.CompilerServices;
using System.Text;

namespace LibreriaDeEstudiantes
{
    public class Estudiante
    {


        private string legajo;
        private string apellido;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public string Legajo { get => legajo; set => legajo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NotaPrimerParcial {

            get => notaPrimerParcial;

            set
            {
                if (value >= 0 && value <= 10)
                {
                    notaPrimerParcial = value;
                }
                else
                {
                    notaPrimerParcial = 0;
                }
            }
        }
        public int NotaSegundoParcial {

            get => notaSegundoParcial;

            set
            {
                if (value >= 0 && value <= 10)
                {
                    notaSegundoParcial = value;
                }
                else
                {
                    notaSegundoParcial = 0;
                }
            }
        }
        public double NotaFinal
        {
            get
            {
                return CalcularNotaFinal();
            }
        }
        public double Promedio
        {
            get
            {
                return CalcularPromedio();
            }
        }



        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Legajo = legajo;
        }



        public void SetNotaPrimerParcial(int primerNota)
        {
            this.NotaPrimerParcial = primerNota;
        }

        public void SetNotaSegundoParcial(int segundaNota)
        {
            this.NotaSegundoParcial = segundaNota;
        }

        private double CalcularPromedio()
        {
            return ((double)NotaPrimerParcial + NotaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if (NotaPrimerParcial >= 4 && NotaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }


            return notaFinal;
        }


        public string Mostrar()
        {
           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {this.apellido}, {this.nombre} - Leg N° {this.legajo} ");
            sb.AppendLine($"1° Parcial: {this.notaPrimerParcial} - 2° Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio}");
            double notaFinal = this.CalcularNotaFinal();

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno DESAPROVADO");
            }

            return sb.ToString();


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
