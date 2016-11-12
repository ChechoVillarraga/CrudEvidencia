using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
 public   class ClsPersona
    {

        private int DocumentoIdentidad;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string correoE;
        private string clave;
        private string claveAntigua;
        private int estado;
        private int HabeasData;
        private int rol;

        public int DocumentoIdentidad1
        {
            get
            {
                return DocumentoIdentidad;
            }

            set
            {
                DocumentoIdentidad = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string CorreoE
        {
            get
            {
                return correoE;
            }

            set
            {
                correoE = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string ClaveAntigua
        {
            get
            {
                return claveAntigua;
            }

            set
            {
                claveAntigua = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int HabeasData1
        {
            get
            {
                return HabeasData;
            }

            set
            {
                HabeasData = value;
            }
        }

        public int Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        public int Login()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = 
                "SELECT rp.idRol "+
                "FROM Personas p " +
                "JOIN RolPersonas rp "+
                "ON p.idPersona = rp.idPersona "+
                "WHERE p.documentoIdentidad = '" + DocumentoIdentidad + "' AND p.clave = '" + clave + "' AND rp.idRol = '" + rol + "'";
            ds =  objConexion.consultar(sentencia);
            if (ds.Tables[0].Rows.Count == 0)
            {
                rol = 3;
            }
            else
            {
                rol = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return rol;

        }

        public bool registrar()
        {
            bool rta=true;
            string consulta = "INSERT INTO Personas (" +
                ") " + 
                "VALUES "



            return rta;
        }
        

    }
}
