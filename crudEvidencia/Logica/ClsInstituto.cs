using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class ClsInstituto
    {
        int idInstituto;

        public int IdInstituto
        {
            get { return idInstituto; }
            set { idInstituto = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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
        int idContacto;

        public int IdContacto
        {
            get { return idContacto; }
            set { idContacto = value; }
        }
        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from institutos");
            conn.desconectar();
            return ds;
        }

    }
}
