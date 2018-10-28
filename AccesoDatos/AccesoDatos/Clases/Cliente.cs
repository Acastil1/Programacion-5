using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Datos.DAL;

namespace AccesoDatos.Clases
{
    class Cliente
    {

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }


        public bool Agregar_Cliente()
        {
            Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter mCliente =
             new Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter();
            mCliente.InsertQuery(Nombre, Estado);

            return true;

        }

        public bool Get_Datos()
        {
            Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter mCliente =
            new Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter();
            Datos.DAL.DsAdmin mds = new Datos.DAL.DsAdmin();
            mCliente.FillByIdCliente(mds.Cliente, IdCliente);
            if (mds.Cliente.Rows.Count == 1)
            {
                DsAdmin.ClienteRow mrow = (DsAdmin.ClienteRow)mds.Cliente.Rows[0];
                Nombre = mrow.Nombre.Trim();
                Estado = mrow.Estado.Trim();
                return true;
            }
            else  return false; }

            public bool Borrar_Datos()
            {
                Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter mCliente =
                new Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter();
                mCliente.DeleteQuery(IdCliente);
                return true;
            }

            public bool Actualizar_Cliente()
            {
                AccesoDatos.Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter mCliente =
               new AccesoDatos.Datos.DAL.DsAdminTableAdapters.ClienteTableAdapter();

                mCliente.UpdateQuery(Nombre, Estado, IdCliente);
               

                //            poner instruccion pendiente
                return true;
            }
            public DsAdmin.ClienteDataTable Get_Lista()
            {
                AccesoDatos.Datos.BL.Admin mAdmin = new AccesoDatos.Datos.BL.Admin();
                return mAdmin.GetClienteLista();
            }
        Actualizar_Cli
            fhgfjhfhjfhjf
        }

    }

