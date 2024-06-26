using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Desarrollador : Empleado
    {
        string LenguajeProgramacion;
        int Experiencia;

        public Desarrollador(string nombre, double salario, string departamento, int antiguedad, string lenguajeProgramacion, int experiencia)
            :base(nombre,salario,departamento,antiguedad)
        {
            LenguajeProgramacion = lenguajeProgramacion;
            Experiencia = experiencia;
        }

        public string LenguajeProgramacion1 { get => LenguajeProgramacion; set => LenguajeProgramacion = value; }
        public int Experiencia1 { get => Experiencia; set => Experiencia = value; }

        public override string Trabajar()
        {
            return "El desarrollador está escribiendo código.";
        }

        public override double CalcularBonificacion(double salario)
        {
            //los desarrolladores reciben una bonificacion del 15% del salario.

            double bonificacion = 0.15 * salario;

            return bonificacion;
        }

        public string DepurarCodigo()
        {
            return $"Desarrollador/a {base.Nombre} esta depurando el codigo escrito en lenguaje {LenguajeProgramacion}."; 
        }

        public override double SueldoTotal()
        {
            double sueldoTotalCalculado = CalcularBonificacion(Salario) + Salario;

            return sueldoTotalCalculado;
        }

    }
}
