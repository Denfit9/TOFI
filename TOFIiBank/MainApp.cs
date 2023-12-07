using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOFIiBank
{
    public partial class Banking : Form
    {
        public Banking()
        {
            InitializeComponent();
            if(Program.userID == -1)
            {
                //Login loginForm = new Login();
               // loginForm.Show();
                //this.Visible = false;

            }
        }

        private void myAccounts_Click(object sender, EventArgs e)
        {
            myAccountsPanel.Visible = true;
            paymentsPanel.Visible = false;

        }

        private void payments_Click(object sender, EventArgs e)
        {
            myAccountsPanel.Visible = false;
            paymentsPanel.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
