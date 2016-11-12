using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
   public class ClsRol
    {
        int idrol;

        public int Idrol
        {
            get { return idrol; }
            set { idrol = value; }
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

       public DataSet getAll()
       {
           DataSet ds = new DataSet();
           Datos.ClsConexion conn = new Datos.ClsConexion();
           conn.conectar();
           ds = conn.consultar("select * from rol");
           conn.desconectar();
           return ds;
       }
    }
}
