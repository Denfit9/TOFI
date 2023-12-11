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
            sumUpDown2.Maximum = 200000;
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
            List<BancAccount> account = Tools.getAllAccountForCredit(Program.userID);

            foreach (CreditType credit in credits)
            {
                creditNumber.Items.Add(credit.creditTypeID);
            }

            foreach (CreditType credit in credits)
            {
                creditNumberComboBox2.Items.Add(credit.creditTypeID);
            }

            foreach (BancAccount acc in account)
            {
                receiverAccauntComboBox.Items.Add(acc.accountNumber);
            }
        }

        public void askCreditConfirm(int sum, int finalSum, int months, int monthPayment, string creditName)
        {
            DialogResult result = MessageBox.Show(
                "Подтвердить оформление кредита?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                /*int sel = comboBox1.SelectedIndex;
                Tools.updateMoneyTransfer(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'));
                MessageBox.Show("Перевод совершён");
                textBox1.Text = "";
                sumTextBox.Text = "";
                comboBox1.SelectedIndex = 0;*/
                int sel = receiverAccauntComboBox.SelectedIndex;
                int numberAccount = Tools.getAccountIDS(Convert.ToString(receiverAccauntComboBox.Items[sel]));
                Tools.openCredit(Program.userID, Convert.ToString(numberAccount), sum, finalSum, months, monthPayment, creditName);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error = 0;
            string errorMessage = "";
            double percentage = 0;
            double finalSum = 0;
            double monthPay = 0;
            outPutInfoData.Text = "";
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
                percentage = (creditOne[0].percentage/100) / 12;
                finalSum = Math.Round(Convert.ToDouble(summNumeric.Value) + Convert.ToDouble(summNumeric.Value)/Convert.ToDouble(monthsNumeric.Value) * percentage * Convert.ToDouble(monthsNumeric.Value) + Convert.ToDouble(summNumeric.Value) * 0.1, 0);
                monthPay = Math.Round(finalSum / Convert.ToDouble(monthsNumeric.Value), 0);
                outPutInfoData.Text = "Финальная сумма для выплаты составит: " + finalSum  + " рублей\nC ежемесячной выплатой: " + monthPay + " рублей";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int error = 0;
            string errorMessage = "";
            double percentage = 0;
            double finalSum = 0;
            double monthPay = 0;
            //outPutInfoData.Text = "";

            if (receiverAccauntComboBox.SelectedIndex < 0)
            {
                errorMessage += "Выберите счёт получателя\n";
                error++;
            }
            if (creditNumberComboBox2.SelectedIndex < 0)
            {
                errorMessage += "Выберите кредит\n";
                error++;
            }
            if(Tools.openCreditsCount(Program.userID) >= 2)
            {
                errorMessage += "Слишком много активных кредитов\n";
                error++;
            }
            else
            {
                int sel = creditNumberComboBox2.SelectedIndex;
                List<CreditType> creditOne = Tools.getOneCreditTypes(Convert.ToInt32(creditNumberComboBox2.Items[sel]));
                if (sumUpDown2.Value > creditOne[0].maxSum || sumUpDown2.Value < creditOne[0].minSum)
                {
                    errorMessage += "Некорректное значение суммы кредита\n";
                    error++;
                }
                if (monthsUpDown2.Value > creditOne[0].maxMonths || monthsUpDown2.Value < creditOne[0].minMonths)
                {
                    errorMessage += "Некорректное значение месяцев кредита\n";
                    error++;
                }
            }

            if (error > 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                int sel = creditNumberComboBox2.SelectedIndex;
                List<CreditType> creditOne = Tools.getOneCreditTypes(Convert.ToInt32(creditNumberComboBox2.Items[sel]));
                percentage = (creditOne[0].percentage / 100) / 12;
                finalSum = Math.Round(Convert.ToDouble(sumUpDown2.Value) + Convert.ToDouble(sumUpDown2.Value) / Convert.ToDouble(monthsUpDown2.Value) * percentage * Convert.ToDouble(monthsUpDown2.Value) + Convert.ToDouble(sumUpDown2.Value) * 0.1, 0);
                monthPay = Math.Round(finalSum / Convert.ToDouble(monthsUpDown2.Value), 0);
                askCreditConfirm(Convert.ToInt32(sumUpDown2.Value), Convert.ToInt32(finalSum), Convert.ToInt32(monthsUpDown2.Value), Convert.ToInt32(monthPay), creditOne[0].creditName);
            }
        }
    }
}
