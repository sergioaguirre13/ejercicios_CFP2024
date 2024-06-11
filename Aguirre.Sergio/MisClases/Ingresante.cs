using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Ingresante
    {
        string nombre;
        string apellido;
        string genero;
        int edad;
        string pais;
        List<string> cursos;

        public Ingresante(string nombre, string apellido, string genero, int edad, string pais, List<string> cursos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.edad = edad;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;  }
        public string Genero { get => genero; }
        public int Edad { get => edad;  }
        public string Pais { get => pais;  }
        public string Cursos
        {
            get
            {
                StringBuilder sb = new StringBuilder();


                return sb.ToString(); 
            }
        }
    }
}
