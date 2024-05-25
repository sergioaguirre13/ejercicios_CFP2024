namespace PrimerFormulario
{
    public partial class FormInicial : Form
    {

        string nombre;
        string especie;
        string edad;
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btn_ingresarDatos_Click(object sender, EventArgs e)
        {
            nombre = txt_nombre.Text;
            especie = txt_especie.Text;
            edad = txt_edad.Text;

            lst_salida.Items.Add($"El nombre de la mascota es: {this.nombre}");
            lst_salida.Items.Add($" La especie es: {this.especie}");
            lst_salida.Items.Add($" Su edad es: {this.edad}");


        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            lst_salida.Items.Clear();
        }

        private void btn_limpiartxtbox_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = string.Empty;
            txt_especie.Text = string.Empty;
            txt_edad.Text = string.Empty;
        }
    }
}
