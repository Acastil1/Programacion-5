using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Datos.DAL;
namespace AccesoDatos.Clases
{
    class Proyecto
    {
        public int IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public string Proyecto1 { get; set; }
        public string Estado { get; set; }
        


        /// <summary>
        /// Toma los datos del Usuario y los almacena en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Agregar_Usuario()
        {
            Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter mProyecto =
             new Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter();
            mProyecto.InsertQuery(IdCliente, IdProyecto, Proyecto1, Estado);
            return true;

        }



        /// <summary>
        /// Carga las propiedas de la clase usuario con los datos del usuario que se encuentra almacenado en la Base de datos
        /// </summary>
        /// <returns></returns>
        public bool Get_Datos()
        {
            Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter mProyecto =
            new Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter();
            Datos.DAL.DsAdmin mds = new Datos.DAL.DsAdmin();
            mProyecto.FillByProyecto(mds.Proyecto, IdProyecto);
            if (mds.Proyecto.Rows.Count == 1)
            {
                Datos.DAL.DsAdmin.ProyectoRow mrow = (Datos.DAL.DsAdmin.ProyectoRow)mds.Proyecto.Rows[0];
                IdCliente = mrow.IdCliente;
                IdProyecto = mrow.IdProyecto;
                Estado = mrow.Estado.Trim();
                Proyecto1 = mrow.Proyecto;
                return true;
            }
            else { return false; }
        }


        /// <summary>
        /// Borrar el usuario de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Borrar_Datos()
        {
            Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter mProyecto =
            new Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter();
            mProyecto.DeleteQuery(IdProyecto);
            return true;
        }

        /// <summary>
        /// Actualiza los datos del usuario en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter mUsuario =
           new Datos.DAL.DsAdminTableAdapters.ProyectoTableAdapter();
            //            poner instruccion pendiente
            return true;
        }


        /// <summary>
        /// Devuelve una lista de usuarios
        /// </summary>
        /// <returns></returns>
        public Datos.DAL.DsAdmin.ProyectoDataTable Get_Lista()
        {
            AccesoDatos.Datos.BL.Admin mAdmin = new AccesoDatos.Datos.BL.Admin();
            return mAdmin.GetProyecto1Lista();
        }



    }
}