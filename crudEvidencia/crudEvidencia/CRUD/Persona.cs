using System;
using System.Windows.Forms;
using Logica;

namespace crudEvidencia.CRUD
{
    public partial class Persona : Form
    {

        public Persona()
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
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Rol);
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Rol);
            // TODO: esta línea de código carga datos en la tabla 'ejercicioAlcaldiaDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Personas);
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.Secretarias' table. You can move, or remove it, as needed.
            this.secretariasTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Secretarias);
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.Barrios' table. You can move, or remove it, as needed.
            this.barriosTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Barrios);

            habeasDataTextBox.Items.Insert(0, "No Acepta");
            habeasDataTextBox.Items.Insert(1, "Si Acepta");
            estadoTextBox.Items.Insert(0, "Inhabilitado");
            estadoTextBox.Items.Insert(1, "Habilitado");




        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ClsPersona p = new ClsPersona();
            Utiles utilesObj = new Utiles();
            int barrio, secretaria, est, h;
            bool parseOK;
            p.DocumentoIdentidad1 = int.Parse(documentoIdentidadTextBox.Text);
            p.Nombres = nombresTextBox.Text;
            p.Apellidos = apellidosTextBox.Text;
            p.Direccion = direccionTextBox.Text;
            //Metodo para forzar la conversion del id del CB
            parseOK = Int32.TryParse(barrioTextBox.SelectedValue.ToString(), out barrio);
            p.Barrio = barrio;
            parseOK = Int32.TryParse(idSecretariaTextBox.SelectedValue.ToString(), out secretaria);
            p.IdSecretaria = secretaria;
            //fin
            p.Telefono = int.Parse(telefonoTextBox.Text);
            p.CorreoE = correoElectronicoTextBox.Text;
            p.Clave = claveTextBox.Text;
            p.ClaveAntigua = claveAntiguaTextBox.Text;
            est = estadoTextBox.SelectedIndex;
            p.Estado = est;
            h = habeasDataTextBox.SelectedIndex;
            p.HabeasData1 = h;
            if (p.registrar() == true)
            {
                MessageBox.Show("Persona ingresada en la Base de Datos correctamente");
                utilesObj.ClearAllText(this);
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            Utiles utilesObj = new Utiles();
            utilesObj.ClearAllText(this);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //documentoIdentidadTextBox.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //nombresTextBox.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //apellidosTextBox.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //direccionTextBox.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //barrioTextBox.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //telefonoTextBox.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //correoElectronicoTextBox.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //claveTextBox.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //claveAntiguaTextBox.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //idSecretariaTextBox.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //estadoTextBox.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            //habeasDataTextBox.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonaModificar p = new PersonaModificar();
            p.Show();
        }
    }
}
