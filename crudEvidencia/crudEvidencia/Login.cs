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


namespace crudEvidencia
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejercicioAlcaldiaDataSet.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.ejercicioAlcaldiaDataSet.Rol);

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ClsPersona objPersona = new ClsPersona();
            objPersona.DocumentoIdentidad1 = int.Parse(TBdocIdentidad.Text);
            objPersona.Clave = TBcontrasenia.Text;
            objPersona.Rol = int.Parse(CBrol.SelectedValue.ToString());
            
            if (objPersona.Login() == 0)
            {
                MenuPrincipal form = new MenuPrincipal();
                form.Show();
                

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
