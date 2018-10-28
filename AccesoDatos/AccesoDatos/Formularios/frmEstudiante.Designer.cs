namespace AccesoDatos.Formularios
{
    partial class frmEstudiante
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridEstudiante = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GridEstudiante
            // 
            this.GridEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEstudiante.Location = new System.Drawing.Point(0, 67);
            this.GridEstudiante.Name = "GridEstudiante";
            this.GridEstudiante.Size = new System.Drawing.Size(835, 301);
            this.GridEstudiante.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(41, 23);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(159, 23);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(256, 23);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 368);
            this.Controls.Add(this.GridEstudiante);
            this.Controls.Add(this.panel1);
            this.Name = "frmEstudiante";
            this.Text = "frmEstudiantes";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridEstudiante;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}