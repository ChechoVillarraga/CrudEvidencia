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

                private void secretarias_Load(object sender, EventArgs e)
                            {
                                cargarDatos();
        }
                public void crearSecrretaria() {

                    if ( (txtNombre.Text).Equals(""))
                    {
                        MessageBox.Show("Debe seleccionar una secretaria");

                    }
                    else
                    {

                        Logica.ClsSecretaria secre = new Logica.ClsSecretaria();
                        secre.Nombre = txtNombre.Text;
                        secre.Descripcion = txtDescripcion.Text;
                        secre.Direccion = txtDireccion.Text;
                        secre.Telefono = txtTelefono.Text;
                        secre.Email1 = txtEmail.Text;
                        secre.insert();
                        cargarDatos();

                    }
                }
                public void cargarDatos() {
                    
                    Logica.ClsSecretaria secre = new Logica.ClsSecretaria();
                    DataSet ds = secre.getAll();
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
                    crearSecrretaria();
                }

                private void dgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    TraerSecretaria();
                }

                private void TraerSecretaria() {
                    Logica.ClsSecretaria secre = new Logica.ClsSecretaria();
                    DataSet ds = new DataSet();
                    int  widSecretaria =int.Parse(dgvResumen.Rows[SeleccionarSecreataria()].Cells[0].Value.ToString());
                    secre.getById(widSecretaria);
                    lblValorId.Text = secre.IdSecretaria.ToString();
                    txtNombre.Text = secre.Nombre;
                    txtDescripcion.Text = secre.Descripcion;
                    txtDireccion.Text = secre.Direccion;
                    txtTelefono.Text = secre.Telefono;
                    txtEmail.Text = secre.Email1;
        
                }
        private void actualizarSecretaria(){
            
                Logica.ClsSecretaria secre = new Logica.ClsSecretaria();
                secre.IdSecretaria = int.Parse(lblValorId.Text);
                secre.Nombre = txtNombre.Text;
                secre.Descripcion = txtDescripcion.Text;
                secre.Direccion = txtDireccion.Text;
                secre.Telefono = txtTelefono.Text;
                secre.Email1 = txtEmail.Text;
                secre.update();
                        
            
        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarSecretaria();
            cargarDatos();
            limpiar();
        }
        private void limpiar() {
            lblValorId.Text = "---";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            
            btnCrear.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void eliminar() {
            Logica.ClsSecretaria secre = new Logica.ClsSecretaria();
            secre.IdSecretaria = int.Parse(lblValorId.Text);
            secre.delete();
            cargarDatos();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

    }
}
