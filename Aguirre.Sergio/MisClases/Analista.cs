using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Analista : Empleado
    {
        string especialidad;
        string proyectos;

        public Analista(string nombre, double salario, string departamento, int antiguedad, string especialidad, string proyectos)
            :base(nombre,salario,departamento,antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Proyectos { get => proyectos; set => proyectos = value; }



        public override string Trabajar()
        {
            return "El analista está analizando los datos.";
        }

        public override double CalcularBonificacion(double salario)
        {
            // los analistas reciben una bonificacion del 10% del salario.

            double bonificacion = 0.10 * salario;

            return bonificacion;
        }

        public string PrepararInforme()
        {
            return $"Analista {base.Nombre} esta preparando los informes de {Proyectos}."; // -->  CONTINUAR ACA UPDATEARLO
        }

        public override double SueldoTotal()
        {
            double sueldoTotalCalculado = CalcularBonificacion(Salario) + Salario;

            return sueldoTotalCalculado;
        }
    }


}
