using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
   public class ClsRolPersona
    {
        int idPersona;

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        int idRol;

        public int IdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }
        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from Rolpersonas");
            conn.desconectar();
            return ds;
        }


    }
}
