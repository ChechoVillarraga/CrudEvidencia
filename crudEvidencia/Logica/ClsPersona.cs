using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ClsPersona
    {



        private int documentoIdentidad;
        private string nombres;
        private string apellidos;
        private string direccion;
        private int barrio;
        private int telefono;
        private string correoElectronico;
        private string clave;
        private string claveAntigua;
        private int idSecretaria;
        private int estado;
        private int HabeasData;
        //Para validar en el Login su rol
        private int rol;

        public int DocumentoIdentidad1
        {
            get
            {
                return documentoIdentidad;
            }

            set
            {
                documentoIdentidad = value;
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
                return correoElectronico;
            }

            set
            {
                correoElectronico = value;
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

        public int Barrio
        {
            get
            {
                return barrio;
            }

            set
            {
                barrio = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int IdSecretaria
        {
            get
            {
                return idSecretaria;
            }

            set
            {
                idSecretaria = value;
            }
        }

        public int Login()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia =
                "SELECT rp.idRol " +
                "FROM Personas p " +
                "JOIN RolPersonas rp " +
                "ON p.idPersona = rp.idPersona " +
                "WHERE p.documentoIdentidad = '" + documentoIdentidad + "' AND p.clave = '" + clave + "' AND rp.idRol = '" + rol + "'";
            ds = objConexion.consultar(sentencia);
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
            ClsConexion objConexion = new ClsConexion();
            bool ds;
            string consulta = "INSERT INTO Personas" +
                "(documentoIdentidad,[nombres],[apellidos],[direccion],[Barrio],[telefono],[correoElectronico],[clave],[claveAntigua],[idSecretaria],[estado],[HabeasData])" +
                "VALUES ('" + documentoIdentidad + "','" + nombres + "','" + apellidos + "','" + direccion + "','" + barrio + "','" + Telefono + "','" + correoElectronico + "','" + clave + "','" + claveAntigua + "','" + IdSecretaria + "','" + estado + "','" + HabeasData + "')";
            return ds = objConexion.ejecutar(consulta);
        }

        public bool Modificar(int idPersona)
        {
            ClsConexion objConexion = new ClsConexion();
            bool ds;
            string sentencia =
                "UPDATE[dbo].[Personas]" +
                "SET[documentoIdentidad] = '" + documentoIdentidad + "'" +
                ",[nombres] = '" + nombres + "'" +
                ",[apellidos] = '" + apellidos + "'" +
                ",[direccion] = '" + direccion + "'" +
                ",[Barrio] = '" + barrio + "'" +
                ",[telefono] = '" + telefono + "'" +
                ",[correoElectronico] = '" + correoElectronico + "'" +
                ",[clave] = '" + clave + "'" +
                ",[claveAntigua] = '" + claveAntigua + "'" +
                ",[idSecretaria] = '" + idSecretaria + "'" +
                ",[estado] = '" + estado + "'" +
                ",[HabeasData] = '" + HabeasData + "'" +
                " WHERE [idPersona] = '" + idPersona + "'";
            return ds = objConexion.ejecutar(sentencia);
        }


    }
}
