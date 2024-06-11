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
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string genero = string.Empty;
            int edad = (int)numericEdad.Value;
            string pais;
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



            Ingresantes = new Ingresante(nombre, apellido, genero, edad) ;

             DialogResult = DialogResult.OK;
        }

       
    }
}
