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
            lstEstudiantes = new ListBox();
            btnCargar = new Button();
            btnAgregarMateria = new Button();
            btnCrearEstadoAcademico = new Button();
            lstMaterias = new ListBox();
            SuspendLayout();
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.BackColor = Color.LightSteelBlue;
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 15;
            lstEstudiantes.Location = new Point(67, 97);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(159, 319);
            lstEstudiantes.TabIndex = 1;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 12F);
            btnCargar.Location = new Point(67, 463);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(159, 62);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Agregar estudiante";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarMateria.Location = new Point(296, 463);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(159, 62);
            btnAgregarMateria.TabIndex = 6;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // btnCrearEstadoAcademico
            // 
            btnCrearEstadoAcademico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearEstadoAcademico.Location = new Point(528, 234);
            btnCrearEstadoAcademico.Name = "btnCrearEstadoAcademico";
            btnCrearEstadoAcademico.Size = new Size(190, 62);
            btnCrearEstadoAcademico.TabIndex = 8;
            btnCrearEstadoAcademico.Text = "crear estado academico";
            btnCrearEstadoAcademico.UseVisualStyleBackColor = true;
            btnCrearEstadoAcademico.Click += btnCrearEstadoAcademico_Click;
            // 
            // lstMaterias
            // 
            lstMaterias.FormattingEnabled = true;
            lstMaterias.ItemHeight = 15;
            lstMaterias.Location = new Point(296, 97);
            lstMaterias.Name = "lstMaterias";
            lstMaterias.Size = new Size(159, 319);
            lstMaterias.TabIndex = 9;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(772, 541);
            Controls.Add(lstMaterias);
            Controls.Add(btnCrearEstadoAcademico);
            Controls.Add(btnAgregarMateria);
            Controls.Add(btnCargar);
            Controls.Add(lstEstudiantes);
            Name = "FormInicial";
            Text = "Form1";
            Load += FormInicial_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstEstudiantes;
        private Button btnCargar;
        private Button btnAgregarMateria;
        private Button btnCrearEstadoAcademico;
        private ListBox lstMaterias;
    }
}
