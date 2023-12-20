using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proiect
{
    public partial class Register : Form
    {
        //UserDatabaseManager userManager= new UserDatabaseManager();
        public Register()
        {
            InitializeComponent();
            //txtPasR.PasswordChar = checkPasR.Checked ? '\0' : '*';
        }

        private void btLogR_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkPas_CheckedChanged(object sender, EventArgs e)
        {
            txtPasR.PasswordChar = checkPasR.Checked ? '\0' : '*';
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btSingR_Click(object sender, EventArgs e)
        {
            //userManager.AddUser(txtUser.Text, txtPasR.Text);
        }
    }
}
