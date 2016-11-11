using System;
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
    public partial class RegistroPersona : Form
    {
        public RegistroPersona()
        {
            InitializeComponent();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void RegistroPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Personas);

        }
    }
}
