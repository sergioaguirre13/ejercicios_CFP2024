using System.Runtime.CompilerServices;

namespace LibreriaDeEstudiantes
{
    public class Estudiante
    {

        // atributos
        string legajo;
        string apellido;
        string nombre;
        int notaPrimerParcial;
        int notaSegundoParcial;
        Random random = new Random();

        // constructor de instancia

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        // metodos

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio = notaPrimerParcial + notaSegundoParcial;
            promedio = promedio / 2;

            return promedio;
        }

        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                double notaFinal = random.Next(6, 10);
                return notaFinal;
            }
            else
            {
                return -1;
            }
        }


        //  STRINGBUILDER
        public string Mostrar()
        {
            if (CalcularNotaFinal() == -1)
            {
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
                   ALUMNO APROBADO           ";
            }
           
        }

    }
}
