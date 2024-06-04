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

            if (Cargar.DialogResult == DialogResult.OK)
            {
                estudiantes.Add(Cargar.CargaEstudiante);
                lstEstudiantes.DataSource = null;
                lstEstudiantes.DataSource = estudiantes;
            }


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.dtvEstudiantes.DataSource = string.Empty;
            this.dtvEstudiantes.DataSource = estudiantes;


        }

        
    }
}
