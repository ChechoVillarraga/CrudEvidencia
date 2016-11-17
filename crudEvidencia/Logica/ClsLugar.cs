using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class ClsLugar
    {
        private int idLugar;

        public int IdLugar
        {
            get { return idLugar; }
            set { idLugar = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from lugares");
            conn.desconectar();
            return ds;
        }

        public void getById(int WidLugar)
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from lugares where idLugar= " + WidLugar);
            idLugar = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            nombre = ds.Tables[0].Rows[0][1].ToString();
            direccion = ds.Tables[0].Rows[0][2].ToString();
            telefono = ds.Tables[0].Rows[0][3].ToString();
            
            conn.desconectar();
            

        }



        public void insert()
        {

            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "INSERT INTO [dbo].[Lugares]([NombreLugar],[Direccion],[Telefono])" +
             "VALUES('" + nombre + "', '" + direccion+ "', '" + telefono+ "')";

            conn.ejecutar(consulta);
            conn.desconectar();

        }

        public void update()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "update lugares set ";

            consulta = consulta + "NombreLugar" + " = '" + nombre + "', ";
            consulta = consulta + "Direccion" + " = '" + direccion+ "', ";
            consulta = consulta + "Telefono" + " = '" + telefono+ "' ";
            consulta = consulta + "where idLugar = " + idLugar;

            conn.ejecutar(consulta);
            conn.desconectar();

        }
        public void delete()
        {
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            string consulta = "delete lugares ";

            consulta = consulta + "where idLugar = " + idLugar;

            conn.ejecutar(consulta);
            conn.desconectar();

        }








    }
}
