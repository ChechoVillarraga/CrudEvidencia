using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class ClsCursoAsociado
    {
        int idsecreatria;

        public int Idsecreatria
        {
            get { return idsecreatria; }
            set { idsecreatria = value; }
        }
        int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
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
