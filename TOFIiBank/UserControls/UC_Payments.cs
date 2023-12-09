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

namespace TOFIiBank.UserControls
{
    public partial class UC_Payments : UserControl
    {

        private static UC_Payments _instance;

        public static UC_Payments Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Payments();
                return _instance;
            }
        }
        public UC_Payments()
        {
            InitializeComponent();
            List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
            foreach(BancAccount account in accounts)
            {
                comboBox1.Items.Add(account.accountNumber);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
            string currency = "";
            float sum = 0;
            string type = "";
            foreach (BancAccount account in accounts)
            {
                if(account.accountNumber == comboBox1.SelectedItem.ToString())
                {
                    currency = account.currency;
                    sum = account.balance;
                    type = account.bancAccountType.ToString();
                }
            }
            accountCurrency.Text = currency;
            sumLabel.Text = sum.ToString();
            accountType.Text = type;    
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
