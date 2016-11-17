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
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void crearLugar()
        {

            if ((txtNombre.Text).Equals(""))
            {
                MessageBox.Show("Debe seleccionar un Lugar");

            }
            else
            {
                
                Logica.ClsLugar lugar = new Logica.ClsLugar();
                lugar.Nombre = txtNombre.Text;
                lugar.Direccion = txtDireccion.Text;
                lugar.Telefono = txtTelefono.Text;
                lugar.insert();
                cargarDatos();
                limpiar();
            }
        }
        public void cargarDatos()

        {

            Logica.ClsLugar lugar = new Logica.ClsLugar();
            DataSet ds = lugar.getAll();
            dgvResumen.DataSource = ds.Tables[0];

        }
        public int SeleccionarLugar()
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
            //SeleccionarLugar();
            crearLugar();
        }

        private void dgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            traerLugar();
        }

        private void traerLugar()
        {
            Logica.ClsLugar lugar = new Logica.ClsLugar();
            DataSet ds = new DataSet();
            int wIdLugar = int.Parse(dgvResumen.Rows[SeleccionarLugar()].Cells[0].Value.ToString());
            lugar.getById(wIdLugar);
            lblValorId.Text = lugar.IdLugar.ToString();
            txtNombre.Text = lugar.Nombre;
            txtDireccion.Text = lugar.Direccion;
            txtTelefono.Text = lugar.Telefono;
            
        }
        private void actualizarLugar()
        {

            Logica.ClsLugar lugar = new Logica.ClsLugar();
            lugar.IdLugar = int.Parse(lblValorId.Text);
            lugar.Nombre = txtNombre.Text;
            lugar.Direccion = txtDireccion.Text;
            lugar.Telefono = txtTelefono.Text;
            lugar.update();



        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarLugar();
            cargarDatos();
            limpiar();
        }
        private void limpiar()
        {
            lblValorId.Text = "---";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
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
            Logica.ClsLugar lugar = new Logica.ClsLugar();
            lugar.IdLugar = int.Parse(lblValorId.Text);
            lugar.delete();
            cargarDatos();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }




    }
}
