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
    public partial class frmEstudiante : Form
    {
        List<Clases.Estudiante> mListaEstudiantes = new List<Clases.Estudiante>();
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
           
        }
        protected void CargarDatos()
        {
            GridEstudiante.DataSource = null;
            GridEstudiante.DataSource = mListaEstudiantes;
            GridEstudiante.Refresh();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmEstudianteAgregar fagregar = new frmEstudianteAgregar();
            fagregar.ShowDialog();
            if (fagregar.mControl == true)
            {
                Clases.Estudiante mEstudiante = new Clases.Estudiante();
               
                mEstudiante.IdEstudiante = int.Parse(fagregar.TxtEstudiante.Text.ToString());
                mEstudiante.Nombre = fagregar.TxtNombre.Text.ToString();
                mEstudiante.Materia = fagregar.TxtMateria.Text.ToString();
                mEstudiante.Nota = decimal.Parse(fagregar.TxtNota.Text.ToString());
                mListaEstudiantes.Add(mEstudiante);

                CargarDatos();

            }
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
