namespace FormsLapicera
{
    partial class FormAlta
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            gpbValor = new GroupBox();
            txtPrecio = new TextBox();
            cbxColor = new ComboBox();
            gbxMarcas = new GroupBox();
            rdbMiguel = new RadioButton();
            rdbChiche = new RadioButton();
            rdbJapan = new RadioButton();
            rdbMario = new RadioButton();
            groupBox1 = new GroupBox();
            gpbValor.SuspendLayout();
            gbxMarcas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(429, 367);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(92, 39);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(157, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 39);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gpbValor
            // 
            gpbValor.Controls.Add(txtPrecio);
            gpbValor.Location = new Point(346, 79);
            gpbValor.Name = "gpbValor";
            gpbValor.Size = new Size(250, 105);
            gpbValor.TabIndex = 8;
            gpbValor.TabStop = false;
            gpbValor.Text = "VALOR";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(41, 43);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "ingrese precio";
            txtPrecio.Size = new Size(171, 29);
            txtPrecio.TabIndex = 5;
            // 
            // cbxColor
            // 
            cbxColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxColor.FormattingEnabled = true;
            cbxColor.Location = new Point(41, 32);
            cbxColor.Name = "cbxColor";
            cbxColor.Size = new Size(185, 29);
            cbxColor.TabIndex = 3;
            // 
            // gbxMarcas
            // 
            gbxMarcas.Controls.Add(rdbMiguel);
            gbxMarcas.Controls.Add(rdbChiche);
            gbxMarcas.Controls.Add(rdbJapan);
            gbxMarcas.Controls.Add(rdbMario);
            gbxMarcas.Location = new Point(88, 73);
            gbxMarcas.Name = "gbxMarcas";
            gbxMarcas.Size = new Size(206, 234);
            gbxMarcas.TabIndex = 9;
            gbxMarcas.TabStop = false;
            gbxMarcas.Text = "Marcas";
            // 
            // rdbMiguel
            // 
            rdbMiguel.AutoSize = true;
            rdbMiguel.Font = new Font("Segoe UI", 12F);
            rdbMiguel.Location = new Point(44, 176);
            rdbMiguel.Name = "rdbMiguel";
            rdbMiguel.Size = new Size(108, 25);
            rdbMiguel.TabIndex = 3;
            rdbMiguel.TabStop = true;
            rdbMiguel.Text = "Miguel inks";
            rdbMiguel.UseVisualStyleBackColor = true;
            // 
            // rdbChiche
            // 
            rdbChiche.AutoSize = true;
            rdbChiche.Font = new Font("Segoe UI", 12F);
            rdbChiche.Location = new Point(44, 133);
            rdbChiche.Name = "rdbChiche";
            rdbChiche.Size = new Size(96, 25);
            rdbChiche.TabIndex = 2;
            rdbChiche.TabStop = true;
            rdbChiche.Text = "Chiche oil";
            rdbChiche.UseVisualStyleBackColor = true;
            // 
            // rdbJapan
            // 
            rdbJapan.AutoSize = true;
            rdbJapan.Font = new Font("Segoe UI", 12F);
            rdbJapan.Location = new Point(44, 86);
            rdbJapan.Name = "rdbJapan";
            rdbJapan.Size = new Size(97, 25);
            rdbJapan.TabIndex = 1;
            rdbJapan.TabStop = true;
            rdbJapan.Text = "Japan Pen";
            rdbJapan.UseVisualStyleBackColor = true;
            // 
            // rdbMario
            // 
            rdbMario.AutoSize = true;
            rdbMario.Font = new Font("Segoe UI", 12F);
            rdbMario.Location = new Point(44, 39);
            rdbMario.Name = "rdbMario";
            rdbMario.Size = new Size(98, 25);
            rdbMario.TabIndex = 0;
            rdbMario.TabStop = true;
            rdbMario.Text = "Mario Pen";
            rdbMario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxColor);
            groupBox1.Location = new Point(346, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selector de color";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 444);
            Controls.Add(groupBox1);
            Controls.Add(gbxMarcas);
            Controls.Add(gpbValor);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            gpbValor.ResumeLayout(false);
            gpbValor.PerformLayout();
            gbxMarcas.ResumeLayout(false);
            gbxMarcas.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMarca;
        private Label lblPrecio;
        private Label lblColor;
        private Button btnAceptar;
        private Button btnCancelar;
        private GroupBox gpbValor;
        private ComboBox cbxColor;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private GroupBox gbxMarcas;
        private RadioButton rdbMiguel;
        private RadioButton rdbChiche;
        private RadioButton rdbJapan;
        private RadioButton rdbMario;
        private GroupBox groupBox1;
    }
}