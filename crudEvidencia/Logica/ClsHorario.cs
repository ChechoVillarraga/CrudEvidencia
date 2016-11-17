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
            ds = conn.consultar("select * from Horario");
            conn.desconectar();
            return ds;
        }

        public void getById(int WidHorario)
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from horario where idHorario = " + WidHorario);
            idHorario = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            hora = ds.Tables[0].Rows[0][1].ToString();
            dia = DateTime.Parse( ds.Tables[0].Rows[0][2].ToString());
            conn.desconectar();
            

        }



        public void insert()
        {

            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "INSERT INTO [dbo].[horario]([hora],[dia])" +
             "VALUES('" + hora + "', '" + dia+ "')";
            conn.ejecutar(consulta);
            conn.desconectar();

        }

        public void update()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "update horario set ";

            consulta = consulta + "hora" + " = '" + hora + "', ";
            consulta = consulta + "dia" + " = '" + dia + "', ";
            consulta = consulta + "where idsecretaria = " + idHorario;

            conn.ejecutar(consulta);
            conn.desconectar();

        }
        public void delete()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "delete horario ";

            consulta = consulta + "where idHorario= " + idHorario;

            conn.ejecutar(consulta);
            conn.desconectar();

        }



    }
}
