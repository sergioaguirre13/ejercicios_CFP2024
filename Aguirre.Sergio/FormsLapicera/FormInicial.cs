using LibreriaDeLapiceras;

namespace FormsLapicera
{
    public partial class Form1 : Form
    {
        private List<Lapicera> listaLapiceras;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaLapiceras = new List<Lapicera>();
            CargarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                listaLapiceras.Add(formAlta.Lapiceras);
                CargarDataGridView();
            }
        }


        private void CargarDataGridView()
        {
            dgvLapiceras.DataSource = null;
            dgvLapiceras.DataSource = listaLapiceras;
        }
    }

    
}
