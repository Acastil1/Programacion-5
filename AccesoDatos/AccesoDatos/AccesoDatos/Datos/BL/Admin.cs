using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Datos.DAL;

namespace AccesoDatos.Datos.BL
{
    class Admin
    {
        public Datos.DAL.DsAdmin.UsuarioDataTable GetUsuariosLista()
        {
            Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter mUsuario =
                           new Datos.DAL.DsAdminTableAdapters.UsuarioTableAdapter();
            Datos.DAL.DsAdmin mds = new Datos.DAL.DsAdmin();
            mUsuario.Fill(mds.Usuario);
            return mds.Usuario;
        }

        public Datos.DAL.DsAdmin.ClienteDataTable GetClienteLista()
        {
            Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter mCliente = new Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter();
            Datos.DAL.DsAdmin mds = new Datos.DAL.DsAdmin();
            mCliente.Fill(mds.Cliente);
            return mds.Cliente;
        }

        internal DsAdmin.ProyectoDataTable GetProyecto1Lista()
        {
            throw new NotImplementedException();
        }
    }
}
