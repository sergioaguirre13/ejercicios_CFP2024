using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeEstudiantes;
using MisClases;

namespace FormEstudiante
{

    public partial class FormEstadoAcademico : Form
    {
        private Estudiante estudiante;
        private List<Materia> materias;
        private string carrera;

        public FormEstadoAcademico()
        {
            InitializeComponent();
        }
        public FormEstadoAcademico(Estudiante estudiante, List<Materia> materias, string carrera)
           : this()
        {
            this.estudiante = estudiante;
            this.materias = materias;
            this.carrera = carrera;
        }
        private void FormEstadoAcademico_Load(object sender, EventArgs e)
        {
            CargarLsb();
        }

        private void CargarLsb()
        {
            lstEstadoAcademico.Items.Add(estudiante);
            lstEstadoAcademico.Items.Add($"Carrera: {carrera}");
            lstEstadoAcademico.Items.Add($"Listado de Materias:");

            foreach (Materia item in materias)
            {
                lstEstadoAcademico.Items.Add(item.Nombre);
            }

        }




    }
}
