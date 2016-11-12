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
    public partial class secretarias : Form
    {
        public secretarias()
        {
            InitializeComponent();
        }

        private void secretariasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.secretariasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void secretarias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Secretarias' Puede moverla o quitarla según sea necesario.
            this.secretariasTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Secretarias);

        }
    }
}
