using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
    public class ClsEstadoSolicitud
    {
        int idEstadoSolicitud;

        public int IdEstadoSolicitud
        {
            get { return idEstadoSolicitud; }
            set { idEstadoSolicitud = value; }
        }
        string nombreEstado;

        public string NombreEstado
        {
            get { return nombreEstado; }
            set { nombreEstado = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from EstadoSolicitud");
            conn.desconectar();
            return ds;
        }
    }
}
