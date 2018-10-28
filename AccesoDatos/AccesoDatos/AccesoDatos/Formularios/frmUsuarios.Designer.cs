namespace AccesoDatos.Formularios
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.GridUsuario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAGregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridUsuario
            // 
            this.GridUsuario.AllowUserToAddRows = false;
            this.GridUsuario.AllowUserToDeleteRows = false;
            this.GridUsuario.AllowUserToOrderColumns = true;
            this.GridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuario.Location = new System.Drawing.Point(27, 57);
            this.GridUsuario.Name = "GridUsuario";
            this.GridUsuario.ReadOnly = true;
            this.GridUsuario.Size = new System.Drawing.Size(606, 323);
            this.GridUsuario.TabIndex = 0;
            this.GridUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuario_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbEstado);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.TxtIdUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(639, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 323);
            this.panel1.TabIndex = 1;
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbEstado.Location = new System.Drawing.Point(94, 99);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(196, 21);
            this.CbEstado.TabIndex = 3;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(169, 161);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 35);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Location = new System.Drawing.Point(58, 161);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 35);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(93, 125);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(197, 20);
            this.TxtEmail.TabIndex = 4;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(94, 76);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(196, 20);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(94, 50);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(196, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(94, 24);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(196, 20);
            this.TxtIdUsuario.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Usuario :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBorrar);
            this.panel2.Controls.Add(this.BtnEditar);
            this.panel2.Controls.Add(this.BtnAGregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 51);
            this.panel2.TabIndex = 2;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Image")));
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrar.Location = new System.Drawing.Point(190, 0);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(95, 51);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(95, 0);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(95, 51);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAGregar
            // 
            this.BtnAGregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAGregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAGregar.Image")));
            this.BtnAGregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAGregar.Location = new System.Drawing.Point(0, 0);
            this.BtnAGregar.Name = "BtnAGregar";
            this.BtnAGregar.Size = new System.Drawing.Size(95, 51);
            this.BtnAGregar.TabIndex = 0;
            this.BtnAGregar.Text = "Agregar";
            this.BtnAGregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAGregar.UseVisualStyleBackColor = true;
            this.BtnAGregar.Click += new System.EventHandler(this.BtnAGregar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridUsuario);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAGregar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.ComboBox CbEstado;
    }
}