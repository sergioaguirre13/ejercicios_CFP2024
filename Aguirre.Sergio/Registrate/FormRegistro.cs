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

namespace Registrate
{

    public partial class FormRegistro : Form
    {
        Ingresante ingresantes;

        public Ingresante Ingresantes { get => ingresantes; }

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            lstPais.DataSource = new List<string>() {
            "Argentina","Uruguay","Brazil","Chile","Perú","Colombia"
            };
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string genero = string.Empty;
            int edad = (int)numericEdad.Value;
            string pais = lstPais.Text;
            List<string> cursos = new List<string>();

            foreach (RadioButton radio in gbxGenero.Controls)
            {
                if (radio.Checked)
                {
                    genero = radio.Text;
                    break;
                }
            }

            foreach (CheckBox box in gbxCursos.Controls)
            {
                if (box.Checked)
                {
                    cursos.Add(box.Text);
                }
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || (string.IsNullOrEmpty(txtApellido.Text)))
            {
                MessageBox.Show("Te falto cargar el nombre o el apellido.");
            }
            else if (edad < 18)
            {
                MessageBox.Show("Debe ser mayor de edad para inscribirse");

            }
            else if (!genero.Any())
            {
                MessageBox.Show("Debe seleccionar algún genero");
            }
            else if (!cursos.Any())
            {
                MessageBox.Show("Debe seleccionar algúno de los cursos para inscribirse");
            }
            else
            {
                ingresantes = new Ingresante(nombre, apellido, genero, edad, pais, cursos);
                DialogResult = DialogResult.OK;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
