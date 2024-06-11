using LibreriaDeEstudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class EstadoAcademico
    {
        private Estudiante estudiante;
        private string carrera;
        private List<Materia> materias;

        private EstadoAcademico()
        {
            materias = new List<Materia>();
        }

        public EstadoAcademico(Estudiante estudiante, string carrera) 
            : this()
        {
            this.estudiante = estudiante;
            this.carrera = carrera;
        }

        

        

        public Materia SetMateria
        {
            set
            {
                this.materias.Add(value);
            }
        }
        public List<Materia> Materias
        { 
            get
            { 
                return this.materias;
            } 
        }
        public Estudiante Estudiante
        {
            get
            {
                return this.estudiante;
            }
        }

        public string Carrera { get => carrera; set => carrera = value; }
    }
}
