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
    public partial class frmEstudianteAgregar : Form
    {
        public Boolean mControl = false;
        public frmEstudianteAgregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEstudianteAgregar_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            mControl = true;
            this.Close();
        }
    }
}
