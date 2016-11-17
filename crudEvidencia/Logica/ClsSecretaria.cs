using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
   public class ClsSecretaria
    {

        int idSecretaria;

        public int IdSecretaria
        {
            get { return idSecretaria; }
            set { idSecretaria = value; }
        }
       string nombre;

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
       string descripcion;

       public string Descripcion
       {
           get { return descripcion; }
           set { descripcion = value; }
       }
       string direccion;

       public string Direccion
       {
           get { return direccion; }
           set { direccion = value; }
       }
       string telefono;

       public string Telefono
       {
           get { return telefono; }
           set { telefono = value; }
       }
       string Email;

       public string Email1
       {
           get { return Email; }
           set { Email = value; }
       }

       public DataSet getAll()
       {
           DataSet ds = new DataSet();
           Datos.ClsConexion conn = new Datos.ClsConexion();
           conn.conectar();
           ds = conn.consultar("select * from secretarias");
           conn.desconectar();
           return ds;
       }

       public void getById(int WidSecretaria)
       {
           DataSet ds = new DataSet();
           Datos.ClsConexion conn = new Datos.ClsConexion();
           conn.conectar();
           ds = conn.consultar("select * from secretarias where idsecretaria = "+WidSecretaria);
           idSecretaria = int.Parse(ds.Tables[0].Rows[0][0].ToString());
           nombre = ds.Tables[0].Rows[0][1].ToString();
           descripcion = ds.Tables[0].Rows[0][2].ToString();
           direccion = ds.Tables[0].Rows[0][3].ToString();
           telefono = ds.Tables[0].Rows[0][4].ToString();
           Email = ds.Tables[0].Rows[0][5].ToString();
           conn.desconectar();
           //idSecretaria = ds.Tables[0].Rows[0].ToString();
           
       }



       public void insert()
       {
        
           Datos.ClsConexion conn = new Datos.ClsConexion();
           conn.conectar();
           string consulta = "INSERT INTO [dbo].[Secretarias]([nombreSec],[descripcion],[direccion],[telefono],[correo])"+
            "VALUES('"+nombre+"', '"+descripcion +"', '"+direccion+"', '"+telefono+"', '"+Email+"')";


           conn.ejecutar(consulta);
           conn.desconectar();

       }

       public void update()
       {
           Datos.ClsConexion conn = new Datos.ClsConexion();
           conn.conectar();
           string consulta = "update SECRETARIAs set ";
           
           consulta = consulta + "nombreSec" + " = '" + nombre + "', ";
           consulta = consulta + "descripcion" + " = '" + descripcion + "', ";
           consulta = consulta + "direccion" + " = '" + direccion + "', ";
           consulta = consulta + "telefono" + " = '" + telefono + "', ";
           consulta = consulta + "correo" + " = '" + Email + "' ";
           consulta = consulta + "where idsecretaria = " + idSecretaria;

           conn.ejecutar(consulta);
           conn.desconectar();

       }
       public void delete() {
           Datos.ClsConexion conn = new Datos.ClsConexion();
           conn.conectar();
           string consulta = "delete SECRETARIAS ";

           consulta = consulta + "where idsecretaria = " + idSecretaria;

           conn.ejecutar(consulta);
           conn.desconectar();

       }


    }
}
