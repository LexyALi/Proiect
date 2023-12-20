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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
           
            
        }

        private void btX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

    

        private void btDas_Click(object sender, EventArgs e)
        {
            UserControl1 dashboard = new UserControl1();
            ReturBooks returnbooks = new ReturBooks();
            IssueBooks issuesbooks = new IssueBooks();
            ADD addbooks = new ADD();
            dashboard.Visible = true;
            returnbooks.Visible = false;
            issuesbooks.Visible = false;
            addbooks.Visible = false;


        }

        private void btAddB_Click(object sender, EventArgs e)
        {
            UserControl1 dashboard = new UserControl1();
            ReturBooks returnbooks = new ReturBooks();
            IssueBooks issuesbooks = new IssueBooks();
            ADD addbooks = new ADD();
            dashboard.Visible = false;
            returnbooks.Visible = false;
            issuesbooks.Visible = false;
            addbooks.Visible = true;

        }

        private void btIssB_Click(object sender, EventArgs e)
        {
            UserControl1 dashboard = new UserControl1();
            ReturBooks returnbooks = new ReturBooks();
            IssueBooks issuesbooks = new IssueBooks();
            ADD addbooks = new ADD();
            dashboard.Visible = false;
            returnbooks.Visible = false;
            issuesbooks.Visible = true;
            addbooks.Visible = false;
        }

        private void btRetB_Click(object sender, EventArgs e)
        {
            UserControl1 dashboard = new UserControl1();
            ReturBooks returnbooks = new ReturBooks();
            IssueBooks issuesbooks = new IssueBooks();
            ADD addbooks = new ADD();
            dashboard.Visible = false;
            returnbooks.Visible = true;
            issuesbooks.Visible = false;
            addbooks.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
