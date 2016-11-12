using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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



    }
}
