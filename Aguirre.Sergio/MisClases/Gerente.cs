using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Gerente : Empleado
    {
         int numeroEmpleados;

        public Gerente(string nombre, double salario, string departamento, int antiguedad, int numeroEmpleados)
           : base(nombre, salario, departamento, antiguedad)
        {
            this.numeroEmpleados = numeroEmpleados;
        }





        public int NumeroEmpleados { get => numeroEmpleados; set => numeroEmpleados = value; }




        public override string Trabajar()
        {
            return "El gerente está gestionando el departamento.";
        }

        public override double CalcularBonificacion(double salario)
        {
            //los gerentes reciben una bonificacion del 25% del salario.

            double bonificacion = 0.25 * salario;

            return bonificacion;
        }

        public string Planificar()
        {
            return $"Gerente {base.Nombre} esta creando una planificacion para {NumeroEmpleados} empleados que tiene a cargo."; 
        }



        public override double SueldoTotal()
        {
            double sueldoTotalCalculado = CalcularBonificacion(Salario) + Salario;

            return sueldoTotalCalculado;
        }

       

    }
}
