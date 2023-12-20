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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassL.PasswordChar = checkPasL.Checked ? '\0' : '*';
        }

        private void btX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkPas_CheckedChanged(object sender, EventArgs e)
        {
            txtPassL.PasswordChar = checkPasL.Checked ? '\0' : '*';
        }

        private void btSing_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
