using System;
using System.Windows.Forms;


namespace crudEvidencia
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            SplashScreen splasForm = new SplashScreen();

            splasForm.Closed += (s, args) => this.Close();

            loginForm.Show();

            timer1.Stop();
        }


    }
}
