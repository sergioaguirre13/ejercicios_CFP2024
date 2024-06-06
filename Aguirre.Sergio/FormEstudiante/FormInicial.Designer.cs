namespace FormEstudiante
{
    partial class FormInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            lstEstudiantes = new ListBox();
            btnCargar = new Button();
            pictureBox1 = new PictureBox();
            btnAgregarMateria = new Button();
            lstMaterias = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.BackColor = Color.LightSteelBlue;
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 15;
            lstEstudiantes.Location = new Point(36, 221);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(217, 304);
            lstEstudiantes.TabIndex = 1;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 12F);
            btnCargar.Location = new Point(69, 553);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(159, 62);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Agregar estudiante";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(917, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(346, 569);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(153, 34);
            btnAgregarMateria.TabIndex = 6;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // lstMaterias
            // 
            lstMaterias.BackColor = Color.LightSteelBlue;
            lstMaterias.FormattingEnabled = true;
            lstMaterias.ItemHeight = 15;
            lstMaterias.Location = new Point(282, 221);
            lstMaterias.Name = "lstMaterias";
            lstMaterias.Size = new Size(217, 304);
            lstMaterias.TabIndex = 7;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1175, 667);
            Controls.Add(lstMaterias);
            Controls.Add(btnAgregarMateria);
            Controls.Add(pictureBox1);
            Controls.Add(btnCargar);
            Controls.Add(lstEstudiantes);
            Name = "FormInicial";
            Text = "Form1";
            Load += FormInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstEstudiantes;
        private Button btnCargar;
        private PictureBox pictureBox1;
        private Button btnAgregarMateria;
        private ListBox lstMaterias;
    }
}
