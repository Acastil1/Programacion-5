using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.Formularios
{
    public partial class frmUsuarios : Form
    {
        public int mIndex = 0;
        public int mControl = 0;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Inactivar();
        }

        protected void CargarDatos()
        {
            Clases.Usuario mUsuario = new Clases.Usuario();
            GridUsuario.DataSource = null;
            GridUsuario.DataSource = mUsuario.Get_Lista();
            GridUsuario.Refresh();

        }

       /// <summary>
       /// Esta funcion  desactiva la edicion de los controles
       /// </summary>
        protected void Inactivar()
        {
            TxtIdUsuario.Enabled = false;
            TxtNombre.Enabled = false;
            CbEstado.Enabled = false;
            TxtEmail.Enabled = false;
            TxtPassword.Enabled = false;

            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnAGregar.Enabled = true;
            BtnEditar.Enabled = true;
            BtnBorrar.Enabled = true;
            GridUsuario.Enabled = true;
        }

        /// <summary>
        /// Esta funcion Activa los controles de edicion de datos
        /// </summary>
        protected void Activar()
        {
            TxtIdUsuario.Enabled = true;
            TxtNombre.Enabled = true;
            CbEstado.Enabled = true;
            TxtEmail.Enabled = true;
            TxtPassword.Enabled = true;

            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnAGregar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnBorrar.Enabled = false;
            GridUsuario.Enabled = false;
        }


        /// <summary>
        /// Inicializa los valores de los controles
        /// </summary>
        protected void Inicializa()
        {
            TxtIdUsuario.Text = "";
            TxtNombre.Text = "";
            TxtPassword.Text = "";
            CbEstado.Text = "Activo";
            TxtEmail.Text = "";
        }


        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Usuario mUsuario = new Clases.Usuario();
            mUsuario.IdUsuario = TxtIdUsuario.Text.ToString().Trim();
            mUsuario.Nombre = TxtNombre.Text.ToString().Trim();
            mUsuario.Email = TxtEmail.Text.ToString();
            mUsuario.Password = TxtPassword.Text.ToString().Trim();
            mUsuario.Estado = CbEstado.Text.ToString().Trim();
            if (mControl == 1)
            {
                mUsuario.Agregar_Usuario();
            }
            else
            {
                mUsuario.Actualizar();
            }
            GridUsuario.DataSource = null;
            GridUsuario.DataSource = mUsuario.Get_Lista();
            GridUsuario.Refresh();
        }

       

        private void GridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mIndex = e.RowIndex;
                DataGridViewRow mselectRow = GridUsuario.Rows[mIndex];
                TxtIdUsuario.Text = mselectRow.Cells[0].Value.ToString().Trim();
                TxtNombre.Text = mselectRow.Cells[1].Value.ToString().Trim();
                TxtPassword.Text= mselectRow.Cells[2].Value.ToString().Trim();
                CbEstado.Text = mselectRow.Cells[3].Value.ToString().Trim();
                TxtEmail.Text = mselectRow.Cells[0].Value.ToString().Trim();
            }
            catch { }
        }

        private void BtnAGregar_Click(object sender, EventArgs e)
        {
            mControl = 1;
            Inicializa();
            Activar();
            TxtIdUsuario.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            mControl = 2;
            Activar();
            TxtIdUsuario.Focus();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de borrar el usuario ?", "Borra Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clases.Usuario mUsuario = new Clases.Usuario();
                mUsuario.IdUsuario = TxtIdUsuario.Text.Trim();
                mUsuario.Borrar_Datos();
                GridUsuario.DataSource = null;
                GridUsuario.DataSource = mUsuario.Get_Lista();
                GridUsuario.Refresh();

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Inactivar();
        }
    }
}
