using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logica
{
    public class ClsCurso
    {
        int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
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
        DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        int asistentes;

        public int Asistentes
        {
            get { return asistentes; }
            set { asistentes = value; }
        }
        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        DateTime inicioInscripcion;

        public DateTime InicioInscripcion1
        {
            get { return inicioInscripcion; }
            set { inicioInscripcion = value; }
        }

        public DateTime InicioInscripcion
        {
            get { return inicioInscripcion; }
            set { inicioInscripcion = value; }
        }
        DateTime finInscripcion;

        public DateTime FinInscripcion
        {
            get { return finInscripcion; }
            set { finInscripcion = value; }
        }
        int horasCurso;

        public int HorasCurso
        {
            get { return horasCurso; }
            set { horasCurso = value; }
        }

        public DataSet getAll()
        {
            DataSet ds = new DataSet();
            Datos.ClsConexion conn = new Datos.ClsConexion();
            conn.conectar();
            ds = conn.consultar("select * from cursos");
            conn.desconectar();
            return ds;
        }


    }
}
