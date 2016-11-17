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
    public partial class barrios : Form
    {
        public barrios()
        {
            InitializeComponent();
        }

        

        private void barrios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Barrios' Puede moverla o quitarla según sea necesario.
        
        }


        public void crearBarrio()
        {

            if ((txtNombre.Text).Equals(""))
            {
                MessageBox.Show("Debe seleccionar una Barrio");

            }
            else
            {

                Logica.ClsBarrio barrio = new Logica.ClsBarrio();
                barrio.Nombre = txtNombre.Text;
                barrio.Limites = txtDescripcion.Text;
                barrio.insert();
                cargarDatos();

            }
        }
        public void cargarDatos()
        {

            Logica.ClsBarrio barrio =new Logica.ClsBarrio();
            DataSet ds = barrio.getAll();
            dgvResumen.DataSource = ds.Tables[0];

        }
        public int SeleccionarSecreataria()
        {
            int seleccion;
            seleccion = dgvResumen.CurrentRow.Index;

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCrear.Enabled = false;
            return seleccion;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //SeleccionarSecreataria();
            crearBarrio();
        }

        private void dgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TraerSecretaria();
        }

        private void TraerSecretaria()
        {
            Logica.ClsBarrio barrio = new Logica.ClsBarrio();
            DataSet ds = new DataSet();
            int widSecretaria = int.Parse(dgvResumen.Rows[SeleccionarSecreataria()].Cells[0].Value.ToString());
            barrio.getById(widSecretaria);
            lblValorId.Text = barrio.IdBarrio.ToString();
            txtNombre.Text = barrio.Nombre;
            txtDescripcion.Text = barrio.Limites;
            
        }
        private void actualizarSecretaria()
        {

            Logica.ClsBarrio barrio = new Logica.ClsBarrio();
            barrio.IdBarrio = int.Parse(lblValorId.Text);
            barrio.Nombre = txtNombre.Text;
            barrio.Limites = txtDescripcion.Text;
            barrio.update();



        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarSecretaria();
            cargarDatos();
            limpiar();
        }
        private void limpiar()
        {
            lblValorId.Text = "---";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            btnCrear.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void eliminar()
        {
            Logica.ClsBarrio barrio= new Logica.ClsBarrio();
            barrio.IdBarrio = int.Parse(lblValorId.Text);
            barrio.delete();
            cargarDatos();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }


    }
}
