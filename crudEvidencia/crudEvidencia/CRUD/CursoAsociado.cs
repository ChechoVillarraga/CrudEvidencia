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
    public partial class CursoAsociado : Form
    {
        public CursoAsociado()
        {
            InitializeComponent();
        }

        private void cursosAsociadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosAsociadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void CursoAsociado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.CursosAsociados' table. You can move, or remove it, as needed.
            this.cursosAsociadosTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.CursosAsociados);

        }
    }
}
