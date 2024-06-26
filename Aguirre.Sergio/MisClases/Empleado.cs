using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public abstract class Empleado
    {
        string nombre;
        double salario;
        string departamento;
        int Antiguedad;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public int Antiguedad1 { get => Antiguedad; set => Antiguedad = value; }

        protected Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.Nombre = nombre;
            this.Salario = salario;
            this.Departamento = departamento;
            this.Antiguedad = antiguedad;
        }

        public abstract string Trabajar();

        public virtual string MostrarInfo()
        {
            return $"Nombre: {Nombre} - Salario: {Salario} - Departamento: {Departamento} - Antiguedad: {Antiguedad}";
        }

        public virtual double CalcularBonificacion(double salario)
        {
            double bonificacion = 0 * salario;

            return bonificacion;
        }

        public abstract double SueldoTotal();
        
        


    }
}
