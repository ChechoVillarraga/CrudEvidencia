﻿using System;
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
    }
}
