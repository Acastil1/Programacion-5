using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Datos.DAL;

namespace AccesoDatos.Clases
{
    class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Password { get; set; }

    
        /// <summary>
        /// Toma los datos del Usuario y los almacena en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Agregar_Usuario()
        {
            Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter mUsuario =
             new Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter();
            mUsuario.InsertQuery(IdUsuario, Nombre, Password, Estado, Email);
            return true;

        }



        /// <summary>
        /// Carga las propiedas de la clase usuario con los datos del usuario que se encuentra almacenado en la Base de datos
        /// </summary>
        /// <returns></returns>
        public bool Get_Datos()
        {
            Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter mUsuario =
            new Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter();
            Datos.DAL.DsAdmin mds = new Datos.DAL.DsAdmin();
            mUsuario.FillByIdUsuario(mds.Usuario, IdUsuario);
            if (mds.Usuario.Rows.Count == 1)
            {
                DsAdmin.UsuarioRow mrow = (DsAdmin.UsuarioRow)mds.Usuario.Rows[0];
                Nombre = mrow.Nombre.Trim();
                Email = mrow.Email.Trim();
                Estado = mrow.Estado.Trim();
                Password = mrow.Password.Trim();
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
            Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter mUsuario =
            new Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter();
            mUsuario.DeleteQuery(IdUsuario);
            return true;
        }

        /// <summary>
        /// Actualiza los datos del usuario en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter mUsuario =
           new Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter();
//            poner instruccion pendiente
            return true;
        }


        /// <summary>
        /// Devuelve una lista de usuarios
        /// </summary>
        /// <returns></returns>
        public DsAdmin.UsuarioDataTable Get_Lista()
        {
            AccesoDatos.Datos.BL.Admin mAdmin = new AccesoDatos.Datos.BL.Admin();
            return mAdmin.GetUsuariosLista();
        }



    }
}
