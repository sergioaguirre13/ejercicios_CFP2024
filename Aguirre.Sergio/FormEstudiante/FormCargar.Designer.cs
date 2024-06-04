namespace FormEstudiante
{
    partial class FormCargar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargar));
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblLegajo = new Label();
            lblApellido = new Label();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            bxCatLeft = new PictureBox();
            bxCatRight = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bxCatLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bxCatRight).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(171, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 32);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(321, 262);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 32);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLegajo.Location = new Point(247, 79);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(56, 21);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "Legajo";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(246, 133);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(68, 21);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Nombre";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(236, 103);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(236, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(236, 210);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 186);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 8;
            label1.Text = "Apellido";
            // 
            // bxCatLeft
            // 
            bxCatLeft.BorderStyle = BorderStyle.FixedSingle;
            bxCatLeft.Image = (Image)resources.GetObject("bxCatLeft.Image");
            bxCatLeft.Location = new Point(48, 85);
            bxCatLeft.Name = "bxCatLeft";
            bxCatLeft.Size = new Size(151, 141);
            bxCatLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            bxCatLeft.TabIndex = 9;
            bxCatLeft.TabStop = false;
            // 
            // bxCatRight
            // 
            bxCatRight.BorderStyle = BorderStyle.FixedSingle;
            bxCatRight.Image = (Image)resources.GetObject("bxCatRight.Image");
            bxCatRight.Location = new Point(384, 85);
            bxCatRight.Name = "bxCatRight";
            bxCatRight.Size = new Size(151, 141);
            bxCatRight.SizeMode = PictureBoxSizeMode.StretchImage;
            bxCatRight.TabIndex = 10;
            bxCatRight.TabStop = false;
            // 
            // FormCargar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(607, 329);
            Controls.Add(bxCatRight);
            Controls.Add(bxCatLeft);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtLegajo);
            Controls.Add(lblApellido);
            Controls.Add(lblLegajo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormCargar";
            Text = "FormCargar";
            ((System.ComponentModel.ISupportInitialize)bxCatLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)bxCatRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblLegajo;
        private Label lblApellido;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label1;
        private PictureBox bxCatLeft;
        private PictureBox bxCatRight;
    }
}