namespace FormEstudiante
{
    partial class FormEstadoAcademico
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
            lstEstadoAcademico = new ListBox();
            SuspendLayout();
            // 
            // lstEstadoAcademico
            // 
            lstEstadoAcademico.FormattingEnabled = true;
            lstEstadoAcademico.ItemHeight = 15;
            lstEstadoAcademico.Location = new Point(42, 43);
            lstEstadoAcademico.Name = "lstEstadoAcademico";
            lstEstadoAcademico.Size = new Size(329, 304);
            lstEstadoAcademico.TabIndex = 0;
            // 
            // FormEstadoAcademico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 381);
            Controls.Add(lstEstadoAcademico);
            Name = "FormEstadoAcademico";
            Text = "FormEstadoAcademico";
            Load += FormEstadoAcademico_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstEstadoAcademico;
    }
}