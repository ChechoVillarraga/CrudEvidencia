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

    }
}
