using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
    public class ClsInscritos
    {
        int idCursol;

        public int IdCursol
        {
            get { return idCursol; }
            set { idCursol = value; }
        }
        int idPersonal;

        public int IdPersonal
        {
            get { return idPersonal; }
            set { idPersonal = value; }
        }
        int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from view_asistencia");
            conn.desconectar();
            return ds;
        }


    }
}
