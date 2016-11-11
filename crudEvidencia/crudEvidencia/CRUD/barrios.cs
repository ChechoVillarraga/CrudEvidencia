﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudEvidencia.CRUD
{
    public partial class barrios : Form
    {
        public barrios()
        {
            InitializeComponent();
        }

        private void barriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.barriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void barrios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Barrios' Puede moverla o quitarla según sea necesario.
            this.barriosTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Barrios);

        }
    }
}