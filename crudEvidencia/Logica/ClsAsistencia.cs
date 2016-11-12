using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Logica
{
    public class ClsAsistencia
    {
        int idAsistencia;

        public int IdAsistencia
        {
            get { return idAsistencia; }
            set { idAsistencia = value; }
        }
        int idPersona;

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        DateTime fechaAsistencia;

        public DateTime FechaAsistencia
        {
            get { return fechaAsistencia; }
            set { fechaAsistencia = value; }
        }
        Boolean asistio;

        public Boolean Asistio
        {
            get { return asistio; }
            set { asistio = value; }
        }
        int estadoSolicitud;

        public int EstadoSolicitud
        {
            get { return estadoSolicitud; }
            set { estadoSolicitud = value; }
        }
        public DataSet getAll() {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds= conn.consultar("select * from view_asistencia");
            conn.desconectar();
            return ds;
        }


        public void insert() {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "insert into asistencia (idAsistencia,idPersona,idCurso,fechaasistencia,Asistio,EstadoSolicitud) values (";
            consulta=consulta+"0,"+idPersona+",";
            consulta = consulta + idCurso + ",";
            consulta = consulta + "'" + fechaAsistencia + "',";
            if (asistio)
            {
                consulta = consulta + 1+ "," + estadoSolicitud + ")";
            }
            else {
                consulta = consulta + 0 + "," + estadoSolicitud + ")";
            }
            
            
            conn.ejecutar(consulta);
            conn.desconectar();

        }
        public void update()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "update asistencia set ";
            consulta=consulta+"idPersona"+" = "+idPersona+", ";
            consulta=consulta+"idcurso"+" = "+idCurso+", ";
            consulta = consulta + "fechaAsistencia" + " = '" + fechaAsistencia + "', ";
            consulta = consulta + "Asistio" + " = '" + asistio+ "', ";
            consulta = consulta + "estadoSolicitud" + " = " + estadoSolicitud+ "where idAsistencia = "+idAsistencia;
            
            conn.ejecutar(consulta);
            conn.desconectar();

        }



    }
}
