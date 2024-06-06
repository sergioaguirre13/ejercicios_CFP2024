using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisClases;

namespace FormEstudiante
{
    public partial class FormAltaMateria : Form
    {
        public Materia miMateria;
        public FormAltaMateria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtNombreMateria.Text))
            //{
            //    this.miMateria = new Materia(txtNombreMateria.Text);
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    MessageBox.Show("Debe ingresar un nombre");
            //}
            this.miMateria = new Materia(txtNombreMateria.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Materia MiMateria
        {
            get
            {
                return miMateria;
            }
        }
    }
}
