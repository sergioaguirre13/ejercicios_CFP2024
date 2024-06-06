namespace FormEstudiante
{
    partial class FormAltaMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreMateria = new TextBox();
            lblNombreMateria = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(109, 62);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(141, 23);
            txtNombreMateria.TabIndex = 0;
            // 
            // lblNombreMateria
            // 
            lblNombreMateria.AutoSize = true;
            lblNombreMateria.Location = new Point(109, 31);
            lblNombreMateria.Name = "lblNombreMateria";
            lblNombreMateria.Size = new Size(141, 15);
            lblNombreMateria.TabIndex = 1;
            lblNombreMateria.Text = "NOMBRE DE LA MATERIA";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(76, 104);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(202, 104);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 150);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblNombreMateria);
            Controls.Add(txtNombreMateria);
            Name = "FormAltaMateria";
            Text = "FormAltaMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreMateria;
        private Label lblNombreMateria;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}