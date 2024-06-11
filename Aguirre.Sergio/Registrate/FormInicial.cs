using MisClases;

namespace Registrate
{
    public partial class Form1 : Form
    {

        List<Ingresante> ingresanteList;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ingresanteList= new List<Ingresante>();
            ActualizarDtgIngresantes();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();

            if (formRegistro.DialogResult == DialogResult.OK)
            {
                ingresanteList.Add(formRegistro.Ingresantes);
                ActualizarDtgIngresantes();
            }

        }


        private void ActualizarDtgIngresantes()
        {
            dtgIngresantes.DataSource = null;
            dtgIngresantes.DataSource = ingresanteList;
        }

        
    }
}
