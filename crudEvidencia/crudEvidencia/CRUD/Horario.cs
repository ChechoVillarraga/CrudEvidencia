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
    public partial class Horario : Form
    {
        public Horario()
        {
            InitializeComponent();
        }

        private void Horario_Load(object sender, EventArgs e)
        {
            cargarDatos();


        }
        public void crearSecrretaria()
        {

            if ((txtDia.Text).Equals(""))
            {
                MessageBox.Show("Debe seleccionar una Hora");

            }
            else
            {
                
                Logica.ClsHorario objHorario= new Logica.ClsHorario();
                objHorario.Hora= cmbHora.Text;
                objHorario.Dia = DtpDia.Value;
                objHorario.insert();
                cargarDatos();

            }
        }
        public void cargarDatos()
        {

            Logica.ClsHorario objHorario= new Logica.ClsHorario();
            DataSet ds = objHorario.getAll();
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
            TraerHorario();
        }

        private void TraerHorario()
        {
            Logica.ClsHorario objHorario= new Logica.ClsHorario();
            DataSet ds = new DataSet();
            int widSecretaria = int.Parse(dgvResumen.Rows[SeleccionarSecreataria()].Cells[0].Value.ToString());
            objHorario.getById(widSecretaria);
            lblValorId.Text = objHorario.IdHorario.ToString();
            cmbHora.SelectedItem = objHorario.Hora;
            DtpDia.Value = DateTime.Parse(""+objHorario.Hora);

        }
        private void actualizarSecretaria()
        {

            Logica.ClsHorario objHorario= new Logica.ClsHorario();
            objHorario.IdHorario = int.Parse(lblValorId.Text);
            objHorario.Hora = (cmbHora.SelectedValue.ToString());
            objHorario.Dia = DtpDia.Value;
            objHorario.update();

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
            cmbHora.SelectedValue = 0;
            DtpDia.Value = DateTime.Parse("00-00-0000");
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
            Logica.ClsHorario objHorario= new Logica.ClsHorario();
            objHorario.IdHorario = int.Parse(lblValorId.Text);
            objHorario.delete();
            cargarDatos();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }


    }
}
