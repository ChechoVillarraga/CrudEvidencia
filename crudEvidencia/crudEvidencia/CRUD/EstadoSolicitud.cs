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
    public partial class EstadoSolicitud : Form
    {
        public EstadoSolicitud()
        {
            InitializeComponent();
        }

        private void estadoSolicitudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoSolicitudBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void EstadoSolicitud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.EstadoSolicitud' table. You can move, or remove it, as needed.
            this.estadoSolicitudTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.EstadoSolicitud);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
