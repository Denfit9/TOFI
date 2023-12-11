using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOFIiBank.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TOFIiBank.UserControls
{
    public partial class UC_MyCredits : UserControl
    {
        private static UC_MyCredits _instance;

        public static UC_MyCredits Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_MyCredits();
                return _instance;
            }
        }
        public UC_MyCredits()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "creditID";
            dataGridView1.Columns[1].DataPropertyName = "sum";
            dataGridView1.Columns[2].DataPropertyName = "status";
            dataGridView1.Columns[3].DataPropertyName = "creditName";
            dataGridView1.Columns[4].DataPropertyName = "startedAt";
            dataGridView1.Columns[5].DataPropertyName = "finalSum";
            dataGridView1.Columns[6].DataPropertyName = "months";
            dataGridView1.Columns[7].DataPropertyName = "monthPayment";
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[3].Width = 105;
            dataGridView1.Columns[4].Width = 135;
            List <Credit> credits = Tools.getAllCredits(Program.userID);
            dataGridView1.DataSource = credits;
            foreach (Credit credit in credits)
            {
                creditNumberComboBox.Items.Add(credit.creditID);
            }
            List<BancAccount> account = Tools.getAllAccountForCredit(Program.userID);
            foreach (BancAccount acc in account)
            {
                accountToPayComboBox.Items.Add(acc.accountNumber);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Credit> credits = Tools.getAllCredits(Program.userID);
            dataGridView1.DataSource = credits;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int error = 0;
            string errorMessage = "";
            if (accountToPayComboBox.SelectedIndex < 0)
            {
                errorMessage += "Выберите счёт для оплаты\n";
                error++;
            }
            if (creditNumberComboBox.SelectedIndex < 0)
            {
                errorMessage += "Выберите кредит\n";
                error++;
            }

            if(error > 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                int sel = accountToPayComboBox.SelectedIndex;
                int accountBalance = Tools.getAccountBalance(Convert.ToString(accountToPayComboBox.Items[sel]));
                int sel2 = creditNumberComboBox.SelectedIndex;
                int creditID = Convert.ToInt32(creditNumberComboBox.Items[sel2]);
                
                List<Credit> creditExact = Tools.getOneCredit(creditID);
                if (creditExact[0].monthPayment > accountBalance)
                {
                    MessageBox.Show("На счету недостаточно средств для выплаты в: " + creditExact[0].monthPayment);
                }
                else
                {
                    Tools.PayForCredit(Convert.ToString(accountToPayComboBox.Items[sel]), creditExact[0].monthPayment, creditID);
                    MessageBox.Show("Платёж совершен");
                }




                List<Credit> credits = Tools.getAllCredits(Program.userID);
                dataGridView1.DataSource = credits;
            }
            

        }
    }
}
