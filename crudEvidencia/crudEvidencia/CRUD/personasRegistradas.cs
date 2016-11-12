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
    public partial class personasRegistradas : Form
    {
        public personasRegistradas()
        {
            InitializeComponent();
        }

        private void personasRegistradas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Personas);

        }
    }
}
