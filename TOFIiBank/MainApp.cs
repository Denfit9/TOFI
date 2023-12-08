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
            if (!mainPanel.Controls.Contains(UserControls.UC_Accounts.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_Accounts.Instance);
                UserControls.UC_Accounts.Instance.Dock = DockStyle.Fill;
                UserControls.UC_Accounts.Instance.BringToFront();   
            }
            else
            {
                UserControls.UC_Accounts.Instance.BringToFront();
            }
        }

        private void payments_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControls.UC_Payments.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_Payments.Instance);
                UserControls.UC_Payments.Instance.Dock = DockStyle.Fill;
                UserControls.UC_Payments.Instance.BringToFront();
            }
            else
            {
                UserControls.UC_Payments.Instance.BringToFront();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void paymentsHistory_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControls.UC_PaymentsHistory.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_PaymentsHistory.Instance);
                UserControls.UC_PaymentsHistory.Instance.Dock = DockStyle.Fill;
                UserControls.UC_PaymentsHistory.Instance.BringToFront();
            }
            else
            {
                UserControls.UC_PaymentsHistory.Instance.BringToFront();
            }
        }

        private void myCredits_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControls.UC_MyCredits.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_MyCredits.Instance);
                UserControls.UC_MyCredits.Instance.Dock = DockStyle.Fill;
                UserControls.UC_MyCredits.Instance.BringToFront();
            }
            else
            {
                UserControls.UC_MyCredits.Instance.BringToFront();
            }
        }

        private void credits_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControls.UC_Credist.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_Credist.Instance);
                UserControls.UC_Credist.Instance.Dock = DockStyle.Fill;
                UserControls.UC_Credist.Instance.BringToFront();
            }
            else
            {
                UserControls.UC_Credist.Instance.BringToFront();
            }
        }

        private void notifications_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControls.UC_Notifications.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_Notifications.Instance);
                UserControls.UC_Notifications.Instance.Dock = DockStyle.Fill;
                UserControls.UC_Notifications.Instance.BringToFront();
            }
            else
            {
                UserControls.UC_Notifications.Instance.BringToFront();
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UserControls.UC_Settings.Instance))
            {
                mainPanel.Controls.Add(UserControls.UC_Settings.Instance);
                UserControls.UC_Settings.Instance.Dock = DockStyle.Fill;
                UserControls.UC_Settings.Instance.BringToFront();
            }
            else
            {
                UserControls.UC_Settings.Instance.BringToFront();
            }
        }
    }
}
