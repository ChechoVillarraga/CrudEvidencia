using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
    public class ClsHorario
    {
        int idHorario;

        public int IdHorario
        {
            get { return idHorario; }
            set { idHorario = value; }
        }
        string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        DateTime dia;

        public DateTime Dia
        {
            get { return dia; }
            set { dia = value; }
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
