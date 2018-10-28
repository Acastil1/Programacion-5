namespace AccesoDatos.Formularios
{
    partial class frmEstudianteAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEstudiante = new System.Windows.Forms.TextBox();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtNota = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdEstudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota";
            // 
            // TxtEstudiante
            // 
            this.TxtEstudiante.Location = new System.Drawing.Point(126, 28);
            this.TxtEstudiante.Name = "TxtEstudiante";
            this.TxtEstudiante.Size = new System.Drawing.Size(100, 20);
            this.TxtEstudiante.TabIndex = 4;
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(126, 96);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(273, 20);
            this.TxtMateria.TabIndex = 7;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(126, 62);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(273, 20);
            this.TxtNombre.TabIndex = 8;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(114, 257);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(255, 257);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(126, 134);
            this.TxtNota.Mask = "99999";
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(81, 20);
            this.TxtNota.TabIndex = 11;
            this.TxtNota.ValidatingType = typeof(int);
            // 
            // frmEstudianteAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 351);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.TxtEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstudianteAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstudianteAgregar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEstudianteAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtEstudiante;
        public System.Windows.Forms.TextBox TxtMateria;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.MaskedTextBox TxtNota;
    }
}