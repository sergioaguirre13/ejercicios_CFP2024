using LibreriaDeLapiceras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLapicera
{
    public partial class FormAlta : Form
    {
        private Lapicera lapiceras;

        public Lapicera Lapiceras { get => lapiceras; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            cbxColor.DataSource = new List<string>() {"red","blue","black","green" }; //pasar esto a la clase
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string marca = string.Empty;
            double precio = Double.Parse(txtPrecio.Text);

            string colorNombre = cbxColor.Text;
            Color color= Color.FromName(colorNombre);

            foreach (RadioButton radio in gbxMarcas.Controls)
            {
                if (radio.Checked)
                {
                    marca = radio.Text;
                    break;
                }
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0");
            }
            else if (!marca.Any())
            {
                MessageBox.Show("Debe seleccionar alguna marca");
            }
            else
            {
                lapiceras = new Lapicera(color, precio, marca);
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
