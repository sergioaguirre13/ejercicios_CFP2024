using LibreriaDeEstudiantes;

namespace FormEstudiante
{

    public partial class FormInicial : Form
    {

        private List<Estudiante> estudiantes;
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

            this.estudiantes = new List<Estudiante>();
            this.estudiantes = Estudiante.ListaEstudiantes();

            this.lstEstudiantes.DataSource = estudiantes;

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            FormCargar Cargar = new FormCargar();

            Cargar.ShowDialog();

            if (Cargar.DialogResult == DialogResult.OK && Cargar.CargaEstudiante is not null)
            {
                estudiantes.Add(Cargar.CargaEstudiante);
                CargarEstudiantes();
            }


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarEstudiantes()
        {
            lstEstudiantes.DataSource = null;
            lstEstudiantes.DataSource = estudiantes;
        }

        private void CargarDataGrid()
        {
            dtvEstudiantes.DataSource = null;
            dtvEstudiantes.DataSource = estudiantes;
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (Estudiante item in estudiantes)
            {
                item.NotaPrimerParcial = rnd.Next(1, 10);
                item.NotaSegundoParcial = rnd.Next(1, 10);

            }
        }
    }
}
