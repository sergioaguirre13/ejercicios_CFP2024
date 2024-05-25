namespace autoForms
{
    partial class Form1
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
            txtMarca = new TextBox();
            txtCombustible = new TextBox();
            txtLista = new TextBox();
            lblMarca = new Label();
            lblCombustible = new Label();
            lblColor = new Label();
            btnCargar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            cbxColor = new ComboBox();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(143, 64);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(123, 23);
            txtMarca.TabIndex = 0;
            // 
            // txtCombustible
            // 
            txtCombustible.Location = new Point(143, 113);
            txtCombustible.Name = "txtCombustible";
            txtCombustible.Size = new Size(123, 23);
            txtCombustible.TabIndex = 1;
            // 
            // txtLista
            // 
            txtLista.Location = new Point(317, 64);
            txtLista.Multiline = true;
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(418, 131);
            txtLista.TabIndex = 3;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(45, 72);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Location = new Point(1, 116);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(124, 15);
            lblCombustible.TabIndex = 5;
            lblCombustible.Text = "Cantidad combustible";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(49, 172);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 6;
            lblColor.Text = "Color";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(143, 236);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(100, 41);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click_1;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(381, 236);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(100, 41);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(543, 236);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 41);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // cbxColor
            // 
            cbxColor.FormattingEnabled = true;
            cbxColor.Location = new Point(145, 169);
            cbxColor.Name = "cbxColor";
            cbxColor.Size = new Size(121, 23);
            cbxColor.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 324);
            Controls.Add(cbxColor);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCargar);
            Controls.Add(lblColor);
            Controls.Add(lblCombustible);
            Controls.Add(lblMarca);
            Controls.Add(txtLista);
            Controls.Add(txtCombustible);
            Controls.Add(txtMarca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtCombustible;
        private TextBox txtLista;
        private Label lblMarca;
        private Label lblCombustible;
        private Label lblColor;
        private Button btnCargar;
        private Button btnMostrar;
        private Button btnLimpiar;
        private ComboBox cbxColor;
    }
}
