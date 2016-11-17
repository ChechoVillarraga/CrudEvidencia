using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
    public class ClsBarrio
    {
        int idBarrio;

        public int IdBarrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string limites;

        public string Limites
        {
            get { return limites; }
            set { limites = value; }
        }


        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from Barrios");
            conn.desconectar();
            return ds;
        }

        public void getById(int widBarrio)
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from barrios where idBarrio = " + widBarrio);
            idBarrio = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            nombre = ds.Tables[0].Rows[0][1].ToString();
            limites = ds.Tables[0].Rows[0][2].ToString();
            conn.desconectar();
            //idBarrio = ds.Tables[0].Rows[0].ToString();

        }



        public void insert()
        {

            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "INSERT INTO [dbo].[Barrios]([nombre], [limites])" +
             "VALUES('" + nombre + "', '" + limites +  "')";


            conn.ejecutar(consulta);
            conn.desconectar();

        }

        public void update()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "update barrios set ";

            consulta = consulta + "nombre" + " = '" + nombre + "', ";
            consulta = consulta + "limites" + " = '" + limites + "' ";
            consulta = consulta + "where idBarrio = " + idBarrio;

            conn.ejecutar(consulta);
            conn.desconectar();

        }
        public void delete()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "delete barrios ";

            consulta = consulta + "where idBarrio = " + idBarrio;

            conn.ejecutar(consulta);
            conn.desconectar();

        }




    }
}
