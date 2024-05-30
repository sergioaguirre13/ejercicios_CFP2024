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

        public string Legajo
        {
            set
            {
                this.legajo = value;
            }
            get
            {
                return this.legajo;
            }
        }



        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

       

        public void SetNotaPrimerParcial(int primerNota)
        {
            this.notaPrimerParcial = primerNota;
        }

        public void SetNotaSegundoParcial(int segundaNota)
        {
            this.notaSegundoParcial = segundaNota;
        }

        private double CalcularPromedio()
        {
            return ((double)notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }
            

            return notaFinal;
        }


        public string Mostrar()
        {
            if (CalcularNotaFinal() == -1)
            {
                //StringBuilder sb = new StringBuilder();

                //sb.AppendLine($"Nombre {this.nombre} - Apellido: {this.apellido}");


                return @$"  
                Nombre: {nombre}
                Apellido: {apellido}
                Legajo: {legajo}       
                Nota 1° parcial {notaPrimerParcial}
                Nota 2° parcial {notaSegundoParcial}
                promedio: {CalcularPromedio()}
                   ALUMNO DESAPROBADO          ";
            }
            else
            {
                return @$"
                Nombre: {nombre}
                Apellido: {apellido}
                Legajo: {legajo}       
                Nota 1° parcial {notaPrimerParcial}
                Nota 2° parcial {notaSegundoParcial}
                promedio: {CalcularPromedio()}
                Nota FINAL {CalcularNotaFinal()}
                   ALUMNO APROBADO           ";
            }
           
        }

    }
}
