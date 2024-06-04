using LibreriaDeEstudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEstudiante
{
    public partial class FormCargar : Form
    {
        private Estudiante cargaEstudiante;
        public Estudiante CargaEstudiante
        {
            get
            {
                return cargaEstudiante;
            }
        }


        public FormCargar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargaEstudiante = new Estudiante(txtNombre.Text,txtApellido.Text,txtLegajo.Text);

            DialogResult = DialogResult.OK;

        }
    }

}
