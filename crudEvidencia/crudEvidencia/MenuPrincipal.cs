using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudEvidencia
{
    
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD.Horario objHorario = new CRUD.Horario();
            objHorario.Show();
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD.EstadoSolicitud estadoOBJ = new CRUD.EstadoSolicitud();
            estadoOBJ.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD.Persona personaOBJ = new CRUD.Persona();
            personaOBJ.Show();
        }

        private void crearBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD.barrios barrio = new CRUD.barrios();
            barrio.Show();
        }

        private void lugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD.FrmLugares objLugar = new CRUD.FrmLugares();
            objLugar.Show();

        }
    }
}
