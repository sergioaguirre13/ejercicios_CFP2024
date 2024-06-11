namespace Registrate
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
            dtgIngresantes = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgIngresantes).BeginInit();
            SuspendLayout();
            // 
            // dtgIngresantes
            // 
            dtgIngresantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgIngresantes.Location = new Point(37, 45);
            dtgIngresantes.Name = "dtgIngresantes";
            dtgIngresantes.Size = new Size(827, 299);
            dtgIngresantes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(354, 379);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 476);
            Controls.Add(btnAgregar);
            Controls.Add(dtgIngresantes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgIngresantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgIngresantes;
        private Button btnAgregar;
    }
}
