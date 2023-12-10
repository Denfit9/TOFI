using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TOFIiBank.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TOFIiBank.UserControls
{
    public partial class UC_Credist : UserControl
    {
        private static UC_Credist _instance;

        public static UC_Credist Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Credist();
                return _instance;
            }
        }
        public UC_Credist()
        {
            InitializeComponent();
            List<CreditType> credits = Tools.getAllCreditTypes();
            summNumeric.Maximum = 200000;
            //List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].DataPropertyName = "creditTypeID";
            dataGridView1.Columns[1].DataPropertyName = "percentage";
            dataGridView1.Columns[3].DataPropertyName = "minSum";
            dataGridView1.Columns[4].DataPropertyName = "maxSum";
            dataGridView1.Columns[2].DataPropertyName = "creditName";
            dataGridView1.Columns[5].DataPropertyName = "minMonths";
            dataGridView1.Columns[6].DataPropertyName = "maxMonths";
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.DataSource = credits;

            foreach (CreditType credit in credits)
            {
                creditNumber.Items.Add(credit.creditTypeID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error = 0;
            string errorMessage = "";
            if (creditNumber.SelectedIndex < 0)
            {
                errorMessage += "Выберите кредит\n";
                error++;
            }
            else
            {
                int sel = creditNumber.SelectedIndex;
                List<CreditType> creditOne = Tools.getOneCreditTypes(Convert.ToInt32(creditNumber.Items[sel]));
                if (summNumeric.Value > creditOne[0].maxSum || summNumeric.Value < creditOne[0].minSum)
                {
                    errorMessage += "Некорректное значение суммы кредита\n";
                    error++;
                }
                if (monthsNumeric.Value > creditOne[0].maxMonths || monthsNumeric.Value < creditOne[0].minMonths)
                {
                    errorMessage += "Некорректное значение месяцев кредита\n";
                    error++;
                }
            }

            if(error>0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                int sel = creditNumber.SelectedIndex;
                List<CreditType> creditOne = Tools.getOneCreditTypes(Convert.ToInt32(creditNumber.Items[sel]));
                double percentage = (creditOne[0].percentage/100) / 12;
                double finalSum = Math.Round(Convert.ToDouble(summNumeric.Value) + Convert.ToDouble(summNumeric.Value) * creditOne[0].percentage / 100 - Convert.ToDouble(summNumeric.Value) * 0.07, 0);
                double monthPay = Math.Round(finalSum / Convert.ToDouble(monthsNumeric.Value), 0);
                outPutInfoData.Text = "Финальная сумма для выплаты составит: " + finalSum  + " рублей\nC ежемесячной выплатой: " + monthPay + " рублей";
            }
        }
    }
}
