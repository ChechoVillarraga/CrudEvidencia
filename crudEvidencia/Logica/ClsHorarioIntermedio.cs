using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class ClsHorarioIntermedio
    {

        int idcurso;

        public int Idcurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }
        int idHorario;

        public int IdHorario
        {
            get { return idHorario; }
            set { idHorario = value; }
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
