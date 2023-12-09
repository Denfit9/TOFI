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
    public partial class UC_PaymentsHistory : UserControl
    {
        private static UC_PaymentsHistory _instance;

        public static UC_PaymentsHistory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_PaymentsHistory();
                return _instance;
            }
        }
        public UC_PaymentsHistory()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "transactionID";
            dataGridView1.Columns[1].DataPropertyName = "summ";
            dataGridView1.Columns[2].DataPropertyName = "date";
            dataGridView1.Columns[3].DataPropertyName = "bancAccountNumber";
            dataGridView1.Columns[4].DataPropertyName = "bancAccountReceiverNumber";
            dataGridView1.Columns[5].DataPropertyName = "transactionMessage";
            dataGridView1.Columns[6].DataPropertyName = "transactionStatus";
            dataGridView1.Columns[7].DataPropertyName = "transactionType";
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[5].Width = 190;
            List<Payment> payments = Tools.getAllPayments(Program.userID);
            dataGridView1.DataSource = payments;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            List<Payment> payments = Tools.getAllPayments(Program.userID);
            dataGridView1.DataSource = payments;
        }
    }
}
