using Autos;
using LibreriaDeFunciones;

namespace autoForms
{
    public partial class Form1 : Form
    {
        List<Auto> listaAutos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listaAutos = new List<Auto>();
            CargarCMB(Auto.ColoresValidos());
        }

        #region BOTONES

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            string marca = this.txtMarca.Text;
            string cantidadCombustible = this.txtCombustible.Text;
            Color color = (Color)this.cbxColor.SelectedItem;

            DialogResult respuesta;

            if (this.ValidarEntradas(marca, cantidadCombustible))
            {
                Auto miAuto = new Auto(marca, cantidadCombustible, color);
                respuesta = MessageBox.Show($"Desea cargar el auto {miAuto.GetMarca()}", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    MessageBox.Show("No se cargo nada a la lista");
                }
                else
                {
                    listaAutos.Add(miAuto);
                }
            }



            this.limpiar();
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            txtLista.Clear();

            foreach (Auto auto in listaAutos)
            {
                txtLista.AppendText(auto.AutoToString() + Environment.NewLine);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtLista.Clear();
        }

        #endregion


        private void limpiar()
        {
            txtMarca.Text = string.Empty;
            txtCombustible.Text = string.Empty;
            cbxColor.Text = string.Empty;
        }

        private bool ValidarEntradas(string marca, string combustible)
        {

            bool ok = true;

            if (!MisMetodos.EsSoloLetras(marca))
            {
                MessageBox.Show("La marca debe ser solo letras");
                ok = false;
            }
            if (!MisMetodos.EsNumerica(combustible))
            {
                MessageBox.Show("El combustible debe ser solo numeros");
                ok = false;

            }


            return ok;
        }

        private void CargarCMB(List<Color> colores)
        {
            foreach (Color color in colores)
            {
                this.cbxColor.Items.Add(color);
            }

        }

        
    }
}