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
            dtvEstudiantes = new DataGridView();
            lstEstudiantes = new ListBox();
            btnCargar = new Button();
            btnNotas = new Button();
            btnMostrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtvEstudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtvEstudiantes
            // 
            dtvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvEstudiantes.BackgroundColor = SystemColors.ActiveCaption;
            dtvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvEstudiantes.Location = new Point(320, 221);
            dtvEstudiantes.Name = "dtvEstudiantes";
            dtvEstudiantes.Size = new Size(818, 304);
            dtvEstudiantes.TabIndex = 0;
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
            btnCargar.Location = new Point(116, 570);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(84, 34);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnNotas
            // 
            btnNotas.Font = new Font("Segoe UI", 12F);
            btnNotas.Location = new Point(503, 570);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(84, 34);
            btnNotas.TabIndex = 3;
            btnNotas.Text = "Evaluar";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 12F);
            btnMostrar.Location = new Point(844, 569);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(83, 35);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
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
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1175, 667);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrar);
            Controls.Add(btnNotas);
            Controls.Add(btnCargar);
            Controls.Add(lstEstudiantes);
            Controls.Add(dtvEstudiantes);
            Name = "FormInicial";
            Text = "Form1";
            Load += FormInicial_Load;
            ((System.ComponentModel.ISupportInitialize)dtvEstudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtvEstudiantes;
        private ListBox lstEstudiantes;
        private Button btnCargar;
        private Button btnNotas;
        private Button btnMostrar;
        private PictureBox pictureBox1;
    }
}
