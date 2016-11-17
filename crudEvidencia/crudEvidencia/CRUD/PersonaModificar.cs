using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace crudEvidencia.CRUD
{
    public partial class PersonaModificar : Form
    {
        public PersonaModificar()
        {
            InitializeComponent();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercicioAlcaldiaDataSet);

        }

        private void PersonaModificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.Personas' table. You can move, or remove it, as needed.
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

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Persona persona = new CRUD.Persona();
            persona.Show();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
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
    }
}
