namespace Registrate
{
    partial class FormRegistro
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
            RadioButton rdbtnMasculino;
            gbxDatosIngresante = new GroupBox();
            lblEdad = new Label();
            lblApellido = new Label();
            lblNobre = new Label();
            numericEdad = new NumericUpDown();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            gbxGenero = new GroupBox();
            rdbtnNoBinario = new RadioButton();
            rdbtnFemenino = new RadioButton();
            gbxCursos = new GroupBox();
            cbxJavaScript = new CheckBox();
            cbxNodeJs = new CheckBox();
            cbxPython = new CheckBox();
            cbxAngular = new CheckBox();
            cbxCsharp = new CheckBox();
            lstPais = new ListBox();
            lblPais = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            rdbtnMasculino = new RadioButton();
            gbxDatosIngresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).BeginInit();
            gbxGenero.SuspendLayout();
            gbxCursos.SuspendLayout();
            SuspendLayout();
            // 
            // rdbtnMasculino
            // 
            rdbtnMasculino.AutoSize = true;
            rdbtnMasculino.Location = new Point(35, 42);
            rdbtnMasculino.Name = "rdbtnMasculino";
            rdbtnMasculino.Size = new Size(80, 19);
            rdbtnMasculino.TabIndex = 0;
            rdbtnMasculino.TabStop = true;
            rdbtnMasculino.Text = "Masculino";
            rdbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // gbxDatosIngresante
            // 
            gbxDatosIngresante.Controls.Add(lblEdad);
            gbxDatosIngresante.Controls.Add(lblApellido);
            gbxDatosIngresante.Controls.Add(lblNobre);
            gbxDatosIngresante.Controls.Add(numericEdad);
            gbxDatosIngresante.Controls.Add(txtApellido);
            gbxDatosIngresante.Controls.Add(txtNombre);
            gbxDatosIngresante.Location = new Point(24, 33);
            gbxDatosIngresante.Name = "gbxDatosIngresante";
            gbxDatosIngresante.Size = new Size(303, 198);
            gbxDatosIngresante.TabIndex = 0;
            gbxDatosIngresante.TabStop = false;
            gbxDatosIngresante.Text = "Datos del Ingresante";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(17, 150);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(17, 94);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblNobre
            // 
            lblNobre.AutoSize = true;
            lblNobre.Location = new Point(17, 46);
            lblNobre.Name = "lblNobre";
            lblNobre.Size = new Size(51, 15);
            lblNobre.TabIndex = 2;
            lblNobre.Text = "Nombre";
            // 
            // numericEdad
            // 
            numericEdad.Location = new Point(85, 150);
            numericEdad.Name = "numericEdad";
            numericEdad.Size = new Size(192, 23);
            numericEdad.TabIndex = 1;
            numericEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(85, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(192, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 0;
            // 
            // gbxGenero
            // 
            gbxGenero.Controls.Add(rdbtnNoBinario);
            gbxGenero.Controls.Add(rdbtnFemenino);
            gbxGenero.Controls.Add(rdbtnMasculino);
            gbxGenero.Location = new Point(362, 33);
            gbxGenero.Name = "gbxGenero";
            gbxGenero.Size = new Size(160, 198);
            gbxGenero.TabIndex = 1;
            gbxGenero.TabStop = false;
            gbxGenero.Text = "Genero";
            // 
            // rdbtnNoBinario
            // 
            rdbtnNoBinario.AutoSize = true;
            rdbtnNoBinario.Location = new Point(35, 146);
            rdbtnNoBinario.Name = "rdbtnNoBinario";
            rdbtnNoBinario.Size = new Size(81, 19);
            rdbtnNoBinario.TabIndex = 2;
            rdbtnNoBinario.TabStop = true;
            rdbtnNoBinario.Text = "No binario";
            rdbtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemenino
            // 
            rdbtnFemenino.AutoSize = true;
            rdbtnFemenino.Location = new Point(35, 90);
            rdbtnFemenino.Name = "rdbtnFemenino";
            rdbtnFemenino.Size = new Size(78, 19);
            rdbtnFemenino.TabIndex = 1;
            rdbtnFemenino.TabStop = true;
            rdbtnFemenino.Text = "Femenino";
            rdbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // gbxCursos
            // 
            gbxCursos.Controls.Add(cbxJavaScript);
            gbxCursos.Controls.Add(cbxNodeJs);
            gbxCursos.Controls.Add(cbxPython);
            gbxCursos.Controls.Add(cbxAngular);
            gbxCursos.Controls.Add(cbxCsharp);
            gbxCursos.Location = new Point(363, 246);
            gbxCursos.Name = "gbxCursos";
            gbxCursos.Size = new Size(159, 169);
            gbxCursos.TabIndex = 2;
            gbxCursos.TabStop = false;
            gbxCursos.Text = "Cursos";
            // 
            // cbxJavaScript
            // 
            cbxJavaScript.AutoSize = true;
            cbxJavaScript.Location = new Point(40, 122);
            cbxJavaScript.Name = "cbxJavaScript";
            cbxJavaScript.Size = new Size(78, 19);
            cbxJavaScript.TabIndex = 4;
            cbxJavaScript.Text = "JavaScript";
            cbxJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbxNodeJs
            // 
            cbxNodeJs.AutoSize = true;
            cbxNodeJs.Location = new Point(40, 97);
            cbxNodeJs.Name = "cbxNodeJs";
            cbxNodeJs.Size = new Size(68, 19);
            cbxNodeJs.TabIndex = 3;
            cbxNodeJs.Text = "Node JS";
            cbxNodeJs.UseVisualStyleBackColor = true;
            // 
            // cbxPython
            // 
            cbxPython.AutoSize = true;
            cbxPython.Location = new Point(40, 72);
            cbxPython.Name = "cbxPython";
            cbxPython.Size = new Size(64, 19);
            cbxPython.TabIndex = 2;
            cbxPython.Text = "Python";
            cbxPython.UseVisualStyleBackColor = true;
            // 
            // cbxAngular
            // 
            cbxAngular.AutoSize = true;
            cbxAngular.Location = new Point(40, 47);
            cbxAngular.Name = "cbxAngular";
            cbxAngular.Size = new Size(68, 19);
            cbxAngular.TabIndex = 1;
            cbxAngular.Text = "Angular";
            cbxAngular.UseVisualStyleBackColor = true;
            // 
            // cbxCsharp
            // 
            cbxCsharp.AutoSize = true;
            cbxCsharp.Location = new Point(40, 22);
            cbxCsharp.Name = "cbxCsharp";
            cbxCsharp.Size = new Size(41, 19);
            cbxCsharp.TabIndex = 0;
            cbxCsharp.Text = "C#";
            cbxCsharp.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            lstPais.FormattingEnabled = true;
            lstPais.ItemHeight = 15;
            lstPais.Location = new Point(24, 262);
            lstPais.Name = "lstPais";
            lstPais.Size = new Size(303, 169);
            lstPais.TabIndex = 3;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(24, 234);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 4;
            lblPais.Text = "Pais";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 439);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(546, 439);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 474);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPais);
            Controls.Add(lstPais);
            Controls.Add(gbxCursos);
            Controls.Add(gbxGenero);
            Controls.Add(gbxDatosIngresante);
            Name = "FormRegistro";
            Text = "Registro";
            Load += FormRegistro_Load;
            gbxDatosIngresante.ResumeLayout(false);
            gbxDatosIngresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).EndInit();
            gbxGenero.ResumeLayout(false);
            gbxGenero.PerformLayout();
            gbxCursos.ResumeLayout(false);
            gbxCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosIngresante;
        private Label lblEdad;
        private Label lblApellido;
        private Label lblNobre;
        private NumericUpDown numericEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private GroupBox gbxGenero;
        private GroupBox gbxCursos;
        private ListBox lstPais;
        private Label lblPais;
        private RadioButton rdbtnNoBinario;
        private RadioButton rdbtnFemenino;
        private RadioButton rdbtnMasculino;
        private CheckBox cbxJavaScript;
        private CheckBox cbxNodeJs;
        private CheckBox cbxPython;
        private CheckBox cbxAngular;
        private CheckBox cbxCsharp;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}