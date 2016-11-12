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
    public partial class institutos : Form
    {
        public institutos()
        {
            InitializeComponent();
        }

        private void institutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.institutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void institutos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Institutos' Puede moverla o quitarla según sea necesario.
            this.institutosTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Institutos);

        }
    }
}
